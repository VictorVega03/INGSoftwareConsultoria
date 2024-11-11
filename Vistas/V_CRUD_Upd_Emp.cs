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
    public partial class V_CRUD_Upd_Emp : Form
    {
        public string NombreEmpleado { get; private set; }
        public string RfcEmpleado { get; private set; }
        public string EmailEmpleado { get; private set; }
        public string TelefonoEmpleado { get; private set; }
        public string DireccionEmpleado { get; private set; }

        public V_CRUD_Upd_Emp(string idEmpleado, string nombreEmpleado, string PuestoEmpleado, string rfcEmpleado, string emailEmpleado, string telefonoEmpleado, string direccionEmpleado)
        {
            InitializeComponent();
            LlenarComboBoxPermisos();
            Txt_ID_Emp.Text = idEmpleado;
            Txt_Nom_Emp.Text = nombreEmpleado;
            BoxPuesto.SelectedIndex = BoxPuesto.FindStringExact(PuestoEmpleado);
            Txt_RFC_Emp.Text = rfcEmpleado;
            Txt_Email_Emp.Text = emailEmpleado;
            Txt_Phone_Emp.Text = telefonoEmpleado;
            Txt_Direccion_Emp.Text = direccionEmpleado;
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
        private void Btn_Aceptar_Emp2_Click(object sender, EventArgs e)
        {
            NombreEmpleado = Txt_Nom_Emp.Text;
            RfcEmpleado = Txt_RFC_Emp.Text;
            EmailEmpleado = Txt_Email_Emp.Text;
            TelefonoEmpleado = Txt_Phone_Emp.Text;
            DireccionEmpleado = Txt_Direccion_Emp.Text;

            UpdateEmpleado();
            MessageBox.Show("Se ha editado el Empleado");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateEmpleado()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"UPDATE Empleados 
                     SET Nom_Emp = @Nombre,
                         Id_Permits = @Puesto,
                         RFC_Emp = @RFC,
                         Email_Emp = @Correo,
                         Phone_Emp = @Telefono,
                         Direccion_Emp = @Direccion
                     WHERE Id_Emp = @IdEmpleado";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdEmpleado", Txt_ID_Emp.Text);
                    command.Parameters.AddWithValue("@Nombre", Txt_Nom_Emp.Text);
                    command.Parameters.AddWithValue("@Puesto", BoxPuesto.SelectedValue);
                    command.Parameters.AddWithValue("@RFC", Txt_RFC_Emp.Text);
                    command.Parameters.AddWithValue("@Correo", Txt_Email_Emp.Text);
                    command.Parameters.AddWithValue("@Telefono", Txt_Phone_Emp.Text);
                    command.Parameters.AddWithValue("@Direccion", Txt_Direccion_Emp.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Btn_Cancelar_Emp2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
