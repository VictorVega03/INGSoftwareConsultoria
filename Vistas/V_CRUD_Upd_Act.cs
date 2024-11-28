using System;
using System.Collections;
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
    public partial class V_CRUD_Upd_Act : Form
    {
        private V_NavBar NavBar;
        public string NombreActividad { get; private set; }
        public string DescripcionActividad { get; private set; }
        private int tipo;

        public V_CRUD_Upd_Act(string idActividad, string idProyecto, string nombreActividad, string empleado, string empleadoProveedor, string estadoActividad, int tipo, V_NavBar MainNavBar)
        {
            InitializeComponent();
            this.NavBar = MainNavBar;
            VerificarTipo(tipo);
            LlenarComboBoxEstados(tipo);
            LlenarComboBoxEmpleados();
            LlenarComboBoxEmpleadosProveedor();
            ObtenerDescripcionActividad(idActividad);

            // Asignar valores a los campos
            txtIDActivity.Text = idActividad;
            txtProyecto.Text = idProyecto;
            txtNombreAct.Text = nombreActividad;
            BoxEmpleado.SelectedIndex = BoxEmpleado.FindStringExact(empleado);
            BoxEmpProv.SelectedIndex = BoxEmpProv.FindStringExact(empleadoProveedor);
            BoxEstado.SelectedIndex = BoxEstado.FindStringExact(estadoActividad);           
        }

        private void VerificarTipo(int tipo)
        {
            if (tipo == 1)
            {
                this.Text = "Ver Actividad";
                txtNombreAct.Enabled = false;
                BoxEmpleado.Enabled = false;
                BoxEmpProv.Enabled = false;
                BoxEstado.Enabled = false;
                txtDescripAct.Enabled = false;
                Btn_Asignar_Act.Visible = false;
            }
        }
        private void ObtenerDescripcionActividad(string idActividad)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Descripcion FROM Actividad WHERE Id_Activity = @IdActivity";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdActivity", idActividad);

                    connection.Open();
                    object descripcion = command.ExecuteScalar(); // Ejecuta la consulta y obtiene un solo valor

                    if (descripcion != null)
                    {
                        txtDescripAct.Text = descripcion.ToString(); // Asigna el valor al TextBox de descripción
                    }
                    else
                    {
                        txtDescripAct.Text = "No se encontró una descripción."; // Mensaje si no hay descripción
                    }
                }
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

                BoxEstado.DataSource = dataTable;
                BoxEstado.DisplayMember = "Name_SttProAct";
                BoxEstado.ValueMember = "Id_SttProAct";
            }
        }

        private void LlenarComboBoxEmpleados()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Emp, Nom_Emp FROM Empleados WHERE LifeOrDie = 1 AND Id_Permits = 4";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                BoxEmpleado.DataSource = dataTable;
                BoxEmpleado.DisplayMember = "Nom_Emp";
                BoxEmpleado.ValueMember = "Id_Emp";
            }
        }

        private void LlenarComboBoxEmpleadosProveedor()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Emp_Prov, Nom_Emp_Prov FROM EmpleadosProveedor WHERE LifeOrDie = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                BoxEmpProv.DataSource = dataTable;
                BoxEmpProv.DisplayMember = "Nom_Emp_Prov";
                BoxEmpProv.ValueMember = "Id_Emp_Prov";
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            NombreActividad = txtNombreAct.Text;
            DescripcionActividad = txtDescripAct.Text;

            ActualizarActividad();
            MessageBox.Show("Se ha editado la actividad.");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ActualizarActividad()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
            UPDATE Actividad 
            SET Nombre_Activity = @NombreActividad,
                Id_Emp = @IdEmpleado,
                Id_Emp_Prov = @IdEmpleadoProveedor,
                Id_SttProAct = @Estado,
                Descripcion = @Descripcion
            WHERE Id_Activity = @IdActividad";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdActividad", txtIDActivity.Text);
                    command.Parameters.AddWithValue("@NombreActividad", txtNombreAct.Text);
                    command.Parameters.AddWithValue("@IdEmpleado", BoxEmpleado.SelectedValue);
                    command.Parameters.AddWithValue("@IdEmpleadoProveedor", BoxEmpProv.SelectedValue);
                    command.Parameters.AddWithValue("@Estado", BoxEstado.SelectedValue);
                    command.Parameters.AddWithValue("@Descripcion", txtDescripAct.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}