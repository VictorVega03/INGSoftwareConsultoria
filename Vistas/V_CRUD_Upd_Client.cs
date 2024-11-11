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
    public partial class V_CRUD_Upd_Client : Form
    {
        public string NombreCliente { get; private set; }
        public string RfcCliente { get; private set; }
        public string EmailCliente { get; private set; }
        public string TelefonoCliente { get; private set; }

        public V_CRUD_Upd_Client(string idCliente, string nombreCliente, string rfcCliente, string emailCliente, string telefonoCliente)
        {
            InitializeComponent();
            Txt_ID_Client.Text = idCliente;
            Txt_Nom_Cliente.Text = nombreCliente;
            Txt_RFC_Cliente.Text = rfcCliente;
            Txt_Email_Cliente.Text = emailCliente;
            Txt_Phone_Cliente.Text = telefonoCliente;
        }

        private void Btn_Aceptar_Cliente2_Click(object sender, EventArgs e)
        {
            NombreCliente = Txt_Nom_Cliente.Text;
            RfcCliente = Txt_RFC_Cliente.Text;
            EmailCliente = Txt_Email_Cliente.Text;
            TelefonoCliente = Txt_Phone_Cliente.Text;

            UpdateCliente();
            MessageBox.Show("Se ha editado el cliente");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateCliente()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"UPDATE Clientes 
                             SET Nom_Client = @Nombre,
                                 RFC_Client = @RFC,
                                 Email_Client = @Correo,
                                 Phone_Client = @Telefono
                             WHERE Id_Client = @IdCliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCliente", Txt_ID_Client.Text);
                    command.Parameters.AddWithValue("@Nombre", Txt_Nom_Cliente.Text);
                    command.Parameters.AddWithValue("@RFC", Txt_RFC_Cliente.Text);
                    command.Parameters.AddWithValue("@Correo", Txt_Email_Cliente.Text);
                    command.Parameters.AddWithValue("@Telefono", Txt_Phone_Cliente.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Btn_Cancelar_Cliente2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
