using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_ClientesRemoved : Form
    {
        private DataTable clientesDataTable;

        public V_ClientesRemoved()
        {
            InitializeComponent();
            CargarClientesEliminados("");
            ConfigurarTabla();
        }

        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            TablaClientesRemoved.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            TablaClientesRemoved.DefaultCellStyle.Font = new Font("Arial", 14);
            TablaClientesRemoved.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            // Centrar el texto
            TablaClientesRemoved.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TablaClientesRemoved.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el RFC a la izquierda
            TablaClientesRemoved.Columns["RFC_Client"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaClientesRemoved.Columns["Nom_Client"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaClientesRemoved.Columns["Email_Client"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaClientesRemoved.Columns["direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Cambiar nombres de encabezados
            TablaClientesRemoved.Columns["Id_Client"].HeaderText = "ID Cliente";
            TablaClientesRemoved.Columns["Nom_Client"].HeaderText = "Nombre";
            TablaClientesRemoved.Columns["RFC_Client"].HeaderText = "RFC Cliente";
            TablaClientesRemoved.Columns["Email_Client"].HeaderText = "Correo";
            TablaClientesRemoved.Columns["Phone_Client"].HeaderText = "Teléfono";
            TablaClientesRemoved.Columns["direccion"].HeaderText = "Dirección";

            // Habilitar scroll automático
            TablaClientesRemoved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaClientesRemoved.ScrollBars = ScrollBars.Both;

            TablaClientesRemoved.ReadOnly = true;
            TablaClientesRemoved.AllowUserToAddRows = false;

            // Configuración de colores
            TablaClientesRemoved.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            TablaClientesRemoved.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            TablaClientesRemoved.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            TablaClientesRemoved.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            TablaClientesRemoved.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            TablaClientesRemoved.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }


        private void BActivarClient_Click(object sender, EventArgs e)
        {
            if (TablaClientesRemoved.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TablaClientesRemoved.SelectedRows[0];
                var idCell = selectedRow.Cells["Id_Client"];
                var nameCell = selectedRow.Cells["Nom_Client"];

                if (idCell?.Value != null && nameCell?.Value != null)
                {
                    string idCliente = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de reactivar al cliente {nombre}, con el ID {idCliente}?", "Reactivar Cliente", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ActivarCliente(idCliente);
                        MessageBox.Show("Cliente reactivado exitosamente.");
                        CargarClientesEliminados("");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para reactivar.");
            }
            CargarClientesEliminados("");
        }

        private void ActivarCliente(string idCliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE Clientes SET LifeOrDIe = 1 WHERE Id_Client = @Id_Client";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Client", idCliente);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CargarClientesEliminados(string filtro)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
SELECT 
    Id_Client, 
    Nom_Client, 
    RFC_Client, 
    Email_Client, 
    Phone_Client, 
    direccion
FROM 
    Clientes
WHERE 
    LifeOrDIe = 0
    AND (
        Id_Client LIKE @Filtro OR
        Nom_Client LIKE @Filtro OR
        RFC_Client LIKE @Filtro OR
        Email_Client LIKE @Filtro OR
        Phone_Client LIKE @Filtro OR
        direccion LIKE @Filtro
    )
ORDER BY 
    Clientes.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el filtro con comodines para la búsqueda
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    clientesDataTable = new DataTable();
                    dataAdapter.Fill(clientesDataTable);
                    TablaClientesRemoved.DataSource = clientesDataTable;
                }
            }
        }


    }
}
