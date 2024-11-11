using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_Clientes : Form
    {
        private DataTable clientesDataTable;

        public V_Clientes()
        {
            InitializeComponent();
            LlenarComboBoxFiltro();
            CargarDatosClientes();
            ConfigurarTabla();
            DGV_Table_Client.Focus();
        }

        private void LlenarComboBoxFiltro()
        {
            // Aqui se llenara el combobox con los filtros que se saquen de la base de datos
        }
        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            DGV_Table_Client.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            DGV_Table_Client.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Table_Client.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            // Centrar el texto
            DGV_Table_Client.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Table_Client.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            DGV_Table_Client.Columns["Id_Client"].HeaderText = "ID Cliente";
            DGV_Table_Client.Columns["Nom_Client"].HeaderText = "Nombre";
            DGV_Table_Client.Columns["RFC_Client"].HeaderText = "RFC Cliente";
            DGV_Table_Client.Columns["Email_Client"].HeaderText = "Correo";
            DGV_Table_Client.Columns["Phone_Client"].HeaderText = "Teléfono";

            // Habilitar scroll automático
            DGV_Table_Client.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Table_Client.ScrollBars = ScrollBars.Both;
        }
        private void Btn_Add_Client_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Client add_Client = new V_CRUD_Add_Client();
            add_Client.ShowDialog();
            CargarDatosClientes();
        }

        private void Btn_Upd_Client_Click(object sender, EventArgs e)
        {
            if (DGV_Table_Client.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Table_Client.SelectedRows[0];
                string idCliente = selectedRow.Cells["Id_Client"].Value?.ToString() ?? "N/A";
                string nombre = selectedRow.Cells["Nom_Client"].Value?.ToString() ?? "N/A";
                string rfc = selectedRow.Cells["RFC_Client"].Value?.ToString() ?? "N/A";
                string email = selectedRow.Cells["Email_Client"].Value?.ToString() ?? "N/A";
                string telefono = selectedRow.Cells["Phone_Client"].Value?.ToString() ?? "N/A";

                V_CRUD_Upd_Client upd_Client = new V_CRUD_Upd_Client(idCliente, nombre, rfc, email, telefono);
                upd_Client.ShowDialog();
                CargarDatosClientes();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para actualizar.");
            }
        }

        private void Btn_Eliminar_Client_Click(object sender, EventArgs e)
        {
            if (DGV_Table_Client.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Table_Client.SelectedRows[0];
                var idCell = selectedRow.Cells["Id_Client"];
                var nameCell = selectedRow.Cells["Nom_Client"];

                if (idCell?.Value != null && nameCell?.Value != null)
                {
                    string idCliente = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de eliminar al cliente {nombre}, con el ID {idCliente}?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteCliente(idCliente);
                        MessageBox.Show("Cliente eliminado exitosamente.");
                        CargarDatosClientes();
                    }
                }
                else
                {
                    MessageBox.Show("El cliente seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
            }
            CargarDatosClientes();
        }
        private void deleteCliente(string idCliente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE Clientes SET LifeOrDIe = 0 WHERE Id_Client = @Id_Client";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Client", idCliente);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void CargarDatosClientes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Client, Nom_Client, RFC_Client, Email_Client, Phone_Client FROM Clientes  WHERE LifeOrDIe = 1 ORDER BY Clientes.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                clientesDataTable = new DataTable();
                dataAdapter.Fill(clientesDataTable);
                DGV_Table_Client.DataSource = clientesDataTable;
            }
        }
        private void BoxFiltroClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDatosClientes();
        }
        private void FiltrarDatosClientes()
        {
            // Metodo para filtrar (tratar de no usar query a DB, hacerlo desde el datatable).
        }

    }
}
