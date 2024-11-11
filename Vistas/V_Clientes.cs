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
        public V_Clientes()
        {
            InitializeComponent();
            CargarDatosClientes();
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
                string idCliente = selectedRow.Cells["Id_Client"].Value.ToString();
                string nombre = selectedRow.Cells["Nom_Client"].Value.ToString();
                string rfc = selectedRow.Cells["RFC_Client"].Value.ToString();
                string email = selectedRow.Cells["Email_Client"].Value.ToString();
                string telefono = selectedRow.Cells["Phone_Client"].Value.ToString();

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

            CargarDatosClientes();
        }

        private void CargarDatosClientes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Client, Nom_Client, RFC_Client, Email_Client, Phone_Client FROM Clientes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                DGV_Table_Client.DataSource = dataTable;
            }
        }

        private void CmB_Filtro_Client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pnl_Filtro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
