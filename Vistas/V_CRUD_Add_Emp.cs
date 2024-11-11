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
    public partial class V_CRUD_Add_Emp : Form
    {
        string Cuando;      

        public V_CRUD_Add_Emp()
        {
            InitializeComponent();
            LlenarComboBoxPermisos();           
        }

        private void LlenarComboBoxPermisos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Permits, WorkPosition_Permits FROM Permisos WHERE Id_Permits = 1 OR Id_Permits = 5";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Asignar el DataTable como origen de datos del ComboBox
                BoxPuesto.DataSource = dataTable;
                BoxPuesto.DisplayMember = "WorkPosition_Permits"; // Mostrar WorkPosition_Permits
                BoxPuesto.ValueMember = "Id_Permits";             // Guardar Id_Permits
            }
        }

        private void Btn_Aceptar_Emp1_Click(object sender, EventArgs e)
        {
            string id = generar_IdEmpleado();
            string nombre = Txt_Nom_Emp.Text;
            int permisos = Convert.ToInt32(BoxPuesto.SelectedValue);
            string rfc = Txt_RFC_Emp.Text;
            string email = Txt_Email_Emp.Text;
            string telefono = Txt_Phone_Emp.Text;
            string direccion = Txt_Direccion_Emp.Text;         

            InsertarEmpleado(id, nombre, permisos, rfc, email, telefono, direccion);
            MessageBox.Show("Empleado Agregado Exitosamente");
            this.Close();
        }

        private void Btn_Cancelar_Emp1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String generar_IdEmpleado()
        {
            string nuevoId = "E1001"; // ID inicial en caso de que no haya empleados en la tabla.
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Id_Emp FROM Empleados WHERE Id_Emp LIKE 'E%' ORDER BY Id_Emp DESC";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                var result = command.ExecuteScalar();
                if (result != null)
                {
                    string ultimoId = result.ToString();
                    int numeroActual = int.Parse(ultimoId.Substring(1)); // Extrae el número quitando la "E"
                    int nuevoNumero = numeroActual + 1; // Suma 1 al último número
                    nuevoId = "E" + nuevoNumero.ToString("D4"); // Formatea el nuevo ID
                }
            }

            return nuevoId;
        }

        private void InsertarEmpleado(string id, string nombre, int permisos, string rfc, string correo, string telefono, string direccion)
        {
            DateTime getFechayHora = DateTime.Now;
            Cuando = getFechayHora.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "INSERT INTO Empleados (Id_Emp, Nom_Emp, RFC_Emp, Email_Emp, Phone_Emp, Direccion_Emp, LifeOrDie, Id_Permits, Cuando) VALUES (@Id, @Nombre, @RFC, @Correo, @Telefono, @Direccion, @LifeOrDie, @Id_Permits, @Cuando)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@RFC", rfc);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@LifeOrDie", 1);
                    command.Parameters.AddWithValue("@Id_Permits", permisos);
                    command.Parameters.AddWithValue("@Cuando", Cuando);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
