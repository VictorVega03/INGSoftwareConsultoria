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
    public partial class V_ProvRemoved : Form
    {
        private DataTable proveedoresDataTable;

        public V_ProvRemoved()
        {
            InitializeComponent();
            CargarProveedoresEliminados("");
            ConfigurarTabla();
        }
        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            TablaProvRemoved.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            TablaProvRemoved.DefaultCellStyle.Font = new Font("Arial", 14);
            TablaProvRemoved.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            // Centrar el texto
            TablaProvRemoved.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TablaProvRemoved.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            TablaProvRemoved.Columns["Id_Prov"].HeaderText = "ID Proveedor";
            TablaProvRemoved.Columns["Nom_Prov"].HeaderText = "Nombre Proveedor";
            TablaProvRemoved.Columns["Rep_Prov"].HeaderText = "Representante";
            TablaProvRemoved.Columns["RFC_Prov"].HeaderText = "RFC Proveedor";
            TablaProvRemoved.Columns["Email_Prov"].HeaderText = "Correo";
            TablaProvRemoved.Columns["Phone_Prov"].HeaderText = "Teléfono";

            // Habilitar scroll automático
            TablaProvRemoved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaProvRemoved.ScrollBars = ScrollBars.Both;

            TablaProvRemoved.ReadOnly = true;
            TablaProvRemoved.AllowUserToAddRows = false;

            // Configuración de colores
            TablaProvRemoved.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            TablaProvRemoved.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            TablaProvRemoved.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            TablaProvRemoved.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            TablaProvRemoved.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            TablaProvRemoved.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }
        private void BActivarProv_Click(object sender, EventArgs e)
        {
            if (TablaProvRemoved.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TablaProvRemoved.SelectedRows[0];
                var idCell = selectedRow.Cells["Id_Prov"];
                var nameCell = selectedRow.Cells["Nom_Prov"];

                if (idCell?.Value != null && nameCell?.Value != null)
                {
                    string idProv = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de reactivar al proveedor {nombre}, con el ID {idProv}?", "Reactivar Proveedor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ActivarProveedor(idProv);
                        MessageBox.Show("Proveedor reactivado exitosamente.");
                        CargarProveedoresEliminados("");
                    }
                }
                else
                {
                    MessageBox.Show("El proveedor seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para reactivar.");
            }
            CargarProveedoresEliminados("");
        }
        private void ActivarProveedor(string idProv)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE Proveedores SET LifeOrDie = 1 WHERE Id_Prov = @Id_Prov";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Prov", idProv);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CargarProveedoresEliminados(string filtro)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
    SELECT 
        Id_Prov, 
        Nom_Prov, 
        Rep_Prov, 
        RFC_Prov, 
        Email_Prov, 
        Phone_Prov
    FROM 
        Proveedores 
    WHERE 
        LifeOrDie = 0 
        AND (
            Id_Prov LIKE @Filtro OR 
            Nom_Prov LIKE @Filtro OR 
            Rep_Prov LIKE @Filtro OR 
            RFC_Prov LIKE @Filtro OR 
            Email_Prov LIKE @Filtro OR 
            Phone_Prov LIKE @Filtro
        )
    ORDER BY 
        Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el filtro con comodines para la búsqueda
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    proveedoresDataTable = new DataTable();
                    dataAdapter.Fill(proveedoresDataTable);
                    TablaProvRemoved.DataSource = proveedoresDataTable;
                }
            }
        }

    }
}
