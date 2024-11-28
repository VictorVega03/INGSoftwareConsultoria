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
        string Cuando;

        public V_CRUD_Add_Client()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Cliente1_Click(object sender, EventArgs e)
        {
            string id = generar_IdCliente();
            string nombreCliente = Txt_Nom_Cliente.Text;
            string rfcCliente = Txt_RFC_Cliente.Text;
            string correoCliente = Txt_Email_Cliente.Text;
            string telefonoCliente = Txt_Phone_Cliente.Text;
            string DireccionCliente = txtDireccion.Text;

            InsertarCliente(id, nombreCliente, rfcCliente, correoCliente, telefonoCliente, DireccionCliente);

            MessageBox.Show("Cliente Agregado Exitosamente");
            this.Close();
        }

        private void Btn_Cancelar_Cliente1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string generar_IdCliente()
        {
            string nuevoId = "C1001"; // ID inicial en caso de que no haya clientes en la tabla.
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Id_Client FROM Clientes WHERE Id_Client LIKE 'C%' ORDER BY Id_Client DESC";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                var result = command.ExecuteScalar();
                if (result != null)
                {
                    string ultimoId = result.ToString();
                    int numeroActual = int.Parse(ultimoId.Substring(1)); // Extrae el número quitando la "C"
                    int nuevoNumero = numeroActual + 1; // Suma 1 al último número
                    nuevoId = "C" + nuevoNumero.ToString("D4"); // Formatea el nuevo ID
                }
            }

            return nuevoId;
        }

        private void InsertarCliente(string id, string nombre, string rfc, string correo, string telefono, string direccion)
        {
            DateTime getFechayHora = DateTime.Now;
            Cuando = getFechayHora.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "INSERT INTO Clientes (Id_Client, Nom_Client, RFC_Client, Email_Client, Phone_Client, LifeOrDie, Cuando, direccion) VALUES (@Id, @Nombre, @RFC, @Correo, @Telefono, @LifeOrDie, @Cuando, @Direccion)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@RFC", rfc);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@LifeOrDie", 1);
                    command.Parameters.AddWithValue("@Cuando", Cuando);
                    command.Parameters.AddWithValue("@Direccion", direccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
