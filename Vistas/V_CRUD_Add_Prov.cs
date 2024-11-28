using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
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
        private void CrearUserLogin(string id, string nombre, string contrasena, int permisos)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "INSERT INTO InicioSesion (Id_LogIn, Pass_LogIn, Id_Permits, UserName) VALUES (@IdLogin, @Password, @Permits, @userNombre)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdLogin", id);
                        command.Parameters.AddWithValue("@Password", contrasena);
                        command.Parameters.AddWithValue("@Permits", permisos);
                        command.Parameters.AddWithValue("@userNombre", nombre);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar en InicioSesion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Aceptar_Prov1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Nom_Prov.Text) ||
   string .IsNullOrWhiteSpace(Txt_Repre_Prov.Text) ||
   string.IsNullOrWhiteSpace(txt_rfcProv.Text) ||
   string.IsNullOrWhiteSpace(Txt_Email_Prov.Text) ||
   string.IsNullOrWhiteSpace(Txt_Phone_Prov.Text) ||  
   string.IsNullOrWhiteSpace(txtLoginPassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = generar_IdProveedor();
            string nombreProveedor = Txt_Nom_Prov.Text;
            string representante = Txt_Repre_Prov.Text;
            string rfcProveedor = txt_rfcProv.Text;
            string correoProveedor = Txt_Email_Prov.Text;
            string telefonoProveedor = Txt_Phone_Prov.Text;
            string contrasena = txtLoginPassword.Text;

            InsertarProveedor(id, nombreProveedor, representante, rfcProveedor, correoProveedor, telefonoProveedor);
            CrearUserLogin(id, nombreProveedor, contrasena, 3);

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
                string query = "SELECT TOP 1 Id_Prov FROM Proveedores WHERE Id_Prov LIKE 'P%' ORDER BY Id_Prov DESC";

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

        private void InsertarProveedor(string id, string nombre, string representante, string rfcProveedor, string correo, string telefono)
        {
            DateTime getFechayHora = DateTime.Now;
            Cuando = getFechayHora.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "INSERT INTO Proveedores (Id_Prov, Nom_Prov, Rep_Prov, RFC_Prov, Email_Prov, Phone_Prov, LifeOrDie, Cuando, Id_Permits) VALUES (@Id, @Nombre, @Representante, @RFCproveedor, @Correo, @Telefono, @LifeOrDie, @Cuando, @Permisos)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Representante", representante);
                    command.Parameters.AddWithValue("@RFCproveedor", rfcProveedor);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@LifeOrDie", 1);
                    command.Parameters.AddWithValue("@Cuando", Cuando);
                    command.Parameters.AddWithValue("@Permisos", 3);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
