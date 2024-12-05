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
    public partial class V_CRUD_Add_Proyect : Form
    {
        string Cuando;

        public V_CRUD_Add_Proyect()
        {
            InitializeComponent();
            LlenarComboBoxProveedores();
            LlenarComboBoxEmpleados();
            LlenarComboBoxClientes();
        }
        private void LlenarComboBoxClientes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Client, Nom_Client FROM Clientes WHERE LifeOrDie = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DataRow defaultRow = dataTable.NewRow();
                defaultRow["Id_Client"] = DBNull.Value;
                defaultRow["Nom_Client"] = "SELECCIONE CLIENTE";
                dataTable.Rows.InsertAt(defaultRow, 0);

                // Asignar el DataTable como origen de datos del ComboBox
                BoxCliente.DataSource = dataTable;
                BoxCliente.DisplayMember = "Nom_Client";
                BoxCliente.ValueMember = "Id_Client";
            }
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
        private void LlenarComboBoxEmpleados()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Emp, Nom_Emp FROM Empleados WHERE LifeOrDie = 1 AND Id_Permits = 2";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DataRow defaultRow = dataTable.NewRow();
                defaultRow["Id_Emp"] = DBNull.Value;
                defaultRow["Nom_Emp"] = "SELECCIONE EMPLEADO";
                dataTable.Rows.InsertAt(defaultRow, 0);

                BoxEmpleado.DataSource = dataTable;
                BoxEmpleado.DisplayMember = "Nom_Emp";
                BoxEmpleado.ValueMember = "Id_Emp";
            }
        }
        private string GenerarIdProyecto()
        {
            string nuevoId = "PY1001"; // ID inicial en caso de que no haya proyectos en la tabla.
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Id_Proyecto FROM Proyect WHERE Id_Proyecto LIKE 'PY%' ORDER BY Id_Proyecto DESC";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                var result = command.ExecuteScalar();
                if (result != null)
                {
                    string ultimoId = result.ToString();
                    int numeroActual = int.Parse(ultimoId.Substring(2)); // Extrae el número quitando "PY"
                    int nuevoNumero = numeroActual + 1; // Suma 1 al último número
                    nuevoId = "PY" + nuevoNumero.ToString("D4"); // Formatea el nuevo ID
                }
            }

            return nuevoId;
        }

        private void Btn_Aceptar_Proyect1_Click(object sender, EventArgs e)
        {
            string idProyecto = GenerarIdProyecto(); // Método para generar un nuevo ID de proyecto
            string nombreProyecto = Txt_Name_Proyect.Text;
            string idEmpleado = BoxEmpleado.SelectedValue?.ToString(); // Obtener el empleado seleccionado           
            string idProveedor = BoxProveedor.SelectedValue?.ToString(); // Obtener el proveedor seleccionado
            string idCliente = BoxCliente.SelectedValue?.ToString(); // Obtener el cliente seleccionado
            string descripcion = Txt_Descrip_Proyect.Text;

            // Validar campos requeridos
            if (string.IsNullOrWhiteSpace(nombreProyecto) || string.IsNullOrWhiteSpace(idEmpleado) || string.IsNullOrWhiteSpace(idCliente) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int estado = 1;
            int hayProveedor = int.Parse(BoxProveedor.SelectedIndex.ToString());       
            if (hayProveedor == 0)
            {             
                estado = 0;
                idProveedor = "P0000";
            }
            // Llamar al método para insertar el proyecto            
            InsertarProyecto(idProyecto, nombreProyecto, idEmpleado, estado, idProveedor, idCliente, descripcion);

            MessageBox.Show("Proyecto Agregado Exitosamente");
            this.Close();
        }

        private void InsertarProyecto(string idProyecto, string nombreProyecto, string idEmpleado, int estado, string idProveedor, string idCliente, string descripcion)
        {
            DateTime getFechayHora = DateTime.Now;
            Cuando = getFechayHora.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
    INSERT INTO Proyect (Id_Proyecto, Nombre, Id_Emp, Id_SttProAct, Id_Prov, Nombre_Cliente, Descripcion, Dia_Inicio, Quien, Cuando, LifeOrDie)
    VALUES (@Id_Proyecto, @Nombre, @Id_Emp, @Id_SttProAct, @Id_Prov, @Nombre_Cliente, @Descripcion, @Dia_Inicio, @Quien, @Cuando, @LifeOrDie)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id_Proyecto", idProyecto);
                    command.Parameters.AddWithValue("@Nombre", nombreProyecto);
                    command.Parameters.AddWithValue("@Id_Emp", idEmpleado);
                    command.Parameters.AddWithValue("@Id_SttProAct", estado);
                    command.Parameters.AddWithValue("@Id_Prov", idProveedor);
                    command.Parameters.AddWithValue("@Nombre_Cliente", string.IsNullOrWhiteSpace(idCliente) ? (object)DBNull.Value : idCliente);
                    command.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion);
                    command.Parameters.AddWithValue("@Dia_Inicio", Cuando);
                    command.Parameters.AddWithValue("@Quien", "usuario_actual"); // Cambiar por el nombre del usuario actual si lo manejas
                    command.Parameters.AddWithValue("@Cuando", Cuando);                 
                    command.Parameters.AddWithValue("@LifeOrDie", 1);

                    connection.Open();              
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Btn_Cancelar_Proyect1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
