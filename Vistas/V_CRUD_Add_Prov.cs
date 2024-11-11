using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_CRUD_Add_Prov : Form
    {
        string Cuando;

        public V_CRUD_Add_Prov()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Prov1_Click(object sender, EventArgs e)
        {
            string id = generar_IdProveedor();
            string nombreProveedor = Txt_Nom_Prov.Text;
            string representante = Txt_Repre_Prov.Text;
            string correoProveedor = Txt_Email_Prov.Text;
            string telefonoProveedor = Txt_Phone_Prov.Text;

            InsertarProveedor(id, nombreProveedor, representante, correoProveedor, telefonoProveedor);

            MessageBox.Show("Proveedor Agregado Exitosamente");
            this.Close();
        }

        private void Btn_Cancelar_Prov1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string generar_IdProveedor()
        {
            string nuevoId = "P1001"; // ID inicial en caso de que no haya proveedores en la tabla.
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Id_Prov FROM Provedores WHERE Id_Prov LIKE 'P%' ORDER BY Id_Prov DESC";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                var result = command.ExecuteScalar();
                if (result != null)
                {
                    string ultimoId = result.ToString();
                    int numeroActual = int.Parse(ultimoId.Substring(1)); // Extrae el número quitando la "P"
                    int nuevoNumero = numeroActual + 1; // Suma 1 al último número
                    nuevoId = "P" + nuevoNumero.ToString("D4"); // Formatea el nuevo ID
                }
            }

            return nuevoId;
        }

        private void InsertarProveedor(string id, string nombre, string representante, string correo, string telefono)
        {
            DateTime getFechayHora = DateTime.Now;
            Cuando = getFechayHora.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "INSERT INTO Provedores (Id_Prov, Nom_Prov, Rep_Prov, Email_Prov, Phone_Prov, LifeOrDie, Cuando) VALUES (@Id, @Nombre, @Representante, @Correo, @Telefono, @LifeOrDie, @Cuando)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Representante", representante);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@LifeOrDie", 1);
                    command.Parameters.AddWithValue("@Cuando", Cuando);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
