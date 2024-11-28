using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_CRUD_Upd_Proyect : Form
    {
        private V_NavBar NavBar;
        public string NombreProyecto { get; private set; }
        public string NombreCliente { get; private set; }
        private int tipo;

        public V_CRUD_Upd_Proyect(string idProyecto, string nombreProyecto, string nombreCliente, string estadoProyecto, string idEmpleado, string idProveedor, int tipo, V_NavBar MainNavBar)
        {
            InitializeComponent();
            this.NavBar = MainNavBar;
            verificarTipo(tipo);
            LlenarComboBoxEstados(tipo);
            LlenarComboBoxEmpleados();
            LlenarComboBoxProveedores();
            LlenarComboBoxClientes();
            ObtenerDescripcionProyecto(idProyecto);

            // Asignar valores a los campos de texto
            BoxCliente.SelectedIndex = BoxCliente.FindStringExact(nombreCliente);
            BoxEstado.SelectedIndex = BoxEstado.FindStringExact(estadoProyecto);
            BoxProveedor.SelectedIndex = BoxProveedor.FindStringExact(idProveedor);
            BoxEmpleado.SelectedIndex = BoxEmpleado.FindStringExact(idEmpleado);
            Txt_ID_Proyect.Text = idProyecto;
            Txt_Name_Proyect.Text = nombreProyecto;            
        }

        private void verificarTipo(int tipo)
        {
            if (tipo == 1)
            {
                this.Text = "Ver Proyecto";
                Txt_Name_Proyect.Enabled = false;
                BoxCliente.Enabled = false;
                BoxEstado.Enabled = false;
                BoxEmpleado.Enabled = false;
                BoxProveedor.Enabled = false;
                Txt_Descrip_Proyect.Enabled = false;
                Btn_Aceptar_Proyect.Visible = false;
                Bactividades.Visible = false;
            }
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

                // Asignar el DataTable como origen de datos del ComboBox
                BoxCliente.DataSource = dataTable;
                BoxCliente.DisplayMember = "Nom_Client";
                BoxCliente.ValueMember = "Id_Client";
            }
        }
        private void LlenarComboBoxEstados(int tipo)
        {
            string query;
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (tipo == 0)
            {
                query = "SELECT Id_SttProAct, Name_SttProAct FROM StatusProAct WHERE Id_SttProAct IN (0,1,2)";
            }
            else
            {
                query = "SELECT Id_SttProAct, Name_SttProAct FROM StatusProAct WHERE Id_SttProAct IN (0,1,2,3,4)";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Asignar el DataTable como origen de datos del ComboBox
                BoxEstado.DataSource = dataTable;
                BoxEstado.DisplayMember = "Name_SttProAct"; // Mostrar nombre del estado
                BoxEstado.ValueMember = "Id_SttProAct";    // Guardar ID del estado               
            }
        }

        private void LlenarComboBoxEmpleados()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Emp, Nom_Emp FROM Empleados WHERE LifeOrDie = 1  AND Id_Permits = 2";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Asignar el DataTable como origen de datos del ComboBox
                BoxEmpleado.DataSource = dataTable;
                BoxEmpleado.DisplayMember = "Nom_Emp"; // Mostrar el nombre del empleado
                BoxEmpleado.ValueMember = "Id_Emp";   // Guardar el ID del empleado                             
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

                // Asignar el DataTable como origen de datos del ComboBox
                BoxProveedor.DataSource = dataTable;
                BoxProveedor.DisplayMember = "Nom_Prov"; // Mostrar el nombre del proveedor
                BoxProveedor.ValueMember = "Id_Prov";   // Guardar el ID del proveedor                              
            }
        }
        private void ObtenerDescripcionProyecto(string idProyecto)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Descripcion FROM Proyect WHERE Id_Proyecto = @IdProyecto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdProyecto", idProyecto);

                    connection.Open();
                    object descripcion = command.ExecuteScalar(); // Ejecuta la consulta y obtiene un solo valor

                    if (descripcion != null)
                    {
                        Txt_Descrip_Proyect.Text = descripcion.ToString(); // Asigna el valor al TextBox de descripción
                    }
                    else
                    {
                        Txt_Descrip_Proyect.Text = "No se encontró una descripción."; // Mensaje si no hay descripción
                    }
                }
            }
        }

        private void Btn_Aceptar_Proyect_Click(object sender, EventArgs e)
        {
            NombreProyecto = Txt_Name_Proyect.Text;
            UpdateProyecto();
            MessageBox.Show("Se ha editado el Proyecto");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateProyecto()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"UPDATE Proyect 
                     SET Nombre = @Nombre,
                         Nombre_Cliente = @IdCliente,                         
                         Id_SttProAct = @Estado,
                         Id_Emp = @IdEmpleado,
                         Id_Prov = @IdProveedor,
                         Descripcion = @Descripcion
                     WHERE Id_Proyecto = @IdProyecto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdProyecto", Txt_ID_Proyect.Text);
                    command.Parameters.AddWithValue("@Nombre", Txt_Name_Proyect.Text);
                    command.Parameters.AddWithValue("@IdCliente", BoxCliente.SelectedValue);
                    command.Parameters.AddWithValue("@Estado", BoxEstado.SelectedValue);
                    command.Parameters.AddWithValue("@IdEmpleado", BoxEmpleado.SelectedValue);
                    command.Parameters.AddWithValue("@IdProveedor", BoxProveedor.SelectedValue);
                    command.Parameters.AddWithValue("@Descripcion", Txt_Descrip_Proyect.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Btn_Cancelar_Proyect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bactividades_Click(object sender, EventArgs e)
        {
            // Obtener el ID del proyecto desde el campo de texto
            string idProyecto = Txt_ID_Proyect.Text;

            // Validar que el ID del proyecto no esté vacío
            if (string.IsNullOrEmpty(idProyecto))
            {
                MessageBox.Show("El ID del proyecto no es válido. Verifique la información.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Salir si no hay un ID de proyecto válido
            }

            // Verificar si existen actividades para el proyecto
            if (ExisteActividad(idProyecto))
            {
                // Si existen actividades, abrir la ventana de actividades
                NavBar.AbrirFormularioEnPanel(new V_Activity(NavBar, idProyecto), "Actividades");
                this.Close();
            }
            else
            {
                // Si no hay actividades, mostrar un mensaje y no hacer nada más
                MessageBox.Show("No hay actividades para este proyecto.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return; // Salir sin abrir la ventana
            }
        }
        private bool ExisteActividad(string idProyecto)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT 1 FROM Actividad WHERE Id_Proyecto = @IdProyecto AND activo = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdProyecto", idProyecto);
                    connection.Open();

                    // Si la consulta devuelve algún resultado, significa que existen actividades
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

    }
}
