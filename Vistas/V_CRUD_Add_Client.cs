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
    public partial class V_CRUD_Add_Client : Form
    {
        public V_CRUD_Add_Client()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Cliente1_Click(object sender, EventArgs e)
        {
            string nombreCliente = Txt_Nom_Cliente.Text;
            string rfcCliente = Txt_RFC_Cliente.Text;
            string correoCliente = Txt_Email_Cliente.Text;
            string telefonoCliente = Txt_Phone_Cliente.Text;


            InsertarCliente(nombreCliente, rfcCliente, correoCliente, telefonoCliente);

            MessageBox.Show("Cliente Agregado Exitosamente");
        }

        private void Btn_Cancelar_Cliente1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertarCliente(string nombre, string rfc, string correo, string telefono)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string query = "INSERT INTO Clientes (Nom_Client, RFC_Client, Email_Client, Phone_Client) VALUES (@Nombre, @Correo, @Telefono)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@RFC", rfc);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);


                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Pnl_Add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_Add_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_Add_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
