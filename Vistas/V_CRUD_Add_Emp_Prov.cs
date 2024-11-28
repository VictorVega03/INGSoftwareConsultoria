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
    public partial class V_CRUD_Add_Emp_Prov : Form
    {
        private string Cuando;

        public V_CRUD_Add_Emp_Prov()
        {
            InitializeComponent();
            LlenarComboBoxProveedores();
        }
        private void LlenarComboBoxProveedores()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Prov, Nom_Prov FROM Proveedores WHERE LifeOrDie = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
            
                DataRow defaultRow = dataTable.NewRow();
                defaultRow["Id_Prov"] = DBNull.Value;
                defaultRow["Nom_Prov"] = "SELECCIONE PROVEEDOR";  
                dataTable.Rows.InsertAt(defaultRow, 0); 

                // Asignar el DataTable como origen de datos del ComboBox
                BoxProveedor.DataSource = dataTable;
                BoxProveedor.DisplayMember = "Nom_Prov";
                BoxProveedor.ValueMember = "Id_Prov"; 
            }
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
        private void Btn_Aceptar_Emp_Prov1_Click(object sender, EventArgs e)
        {
            // Validar si se ha seleccionado un proveedor válido
            if (BoxProveedor.SelectedValue == null || BoxProveedor.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Por favor, selecciona un proveedor válido antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si no se ha seleccionado un proveedor
            }

            // Recoger los valores de los campos
            string id = GenerarIdEmpleadoProveedor();
            string nombre = Txt_Nom_Emp_Prov.Text;
            string rfc = Txt_RFC_Emp_Prov.Text;
            string email = Txt_Email_Emp_Prov.Text;
            string telefono = Txt_Phone_Emp_Prov.Text;
            string idProveedor = BoxProveedor.SelectedValue.ToString(); // Guardar como string
            string contrasena = txtLoginPassword.Text;

            // Llamar al método de inserción
            InsertarEmpleadoProveedor(id, nombre, rfc, email, telefono, idProveedor);
            CrearUserLogin(id, nombre, contrasena, 5); // Contraseña por defecto
            // Mostrar mensaje de éxito
            MessageBox.Show("Empleado de Proveedor Agregado Exitosamente");
            this.Close();
        }


        private void Btn_Cancelar_Emp_Prov1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GenerarIdEmpleadoProveedor()
        {
            string nuevoId = "EP1001"; // ID inicial en caso de que no haya empleados en la tabla.
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Id_Emp_Prov FROM EmpleadosProveedor WHERE Id_Emp_Prov LIKE 'EP%' ORDER BY Id_Emp_Prov DESC";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                var result = command.ExecuteScalar();
                if (result != null)
                {
                    string ultimoId = result.ToString();
                    int numeroActual = int.Parse(ultimoId.Substring(2)); // Extrae el número quitando "PE"
                    int nuevoNumero = numeroActual + 1; // Suma 1 al último número
                    nuevoId = "EP" + nuevoNumero.ToString("D4"); // Formatea el nuevo ID
                }
            }

            return nuevoId;
        }

        private void InsertarEmpleadoProveedor(string id, string nombre, string rfc, string correo, string telefono, string idProveedor)
        {
            DateTime getFechayHora = DateTime.Now;
            Cuando = getFechayHora.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "INSERT INTO EmpleadosProveedor (Id_Emp_Prov, Nom_Emp_Prov, RFC_Emp_Prov, Email_Emp_Prov, Phone_Emp_Prov, LifeOrDie, Id_Prov, Cuando, Id_Permits) VALUES (@Id, @Nombre, @RFC, @Correo, @Telefono, @LifeOrDie, @Id_Prov, @Cuando, @Permisos)";

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
                    command.Parameters.AddWithValue("@Id_Prov", idProveedor);
                    command.Parameters.AddWithValue("@Cuando", Cuando);
                    command.Parameters.AddWithValue("@Permisos", 5);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
