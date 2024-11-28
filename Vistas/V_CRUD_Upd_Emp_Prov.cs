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
    public partial class V_CRUD_Upd_Emp_Prov : Form
    {
        public string NombreEmpleado { get; private set; }
        public string RfcEmpleado { get; private set; }
        public string EmailEmpleado { get; private set; }
        public string TelefonoEmpleado { get; private set; }
        private string idProveedor;

        public V_CRUD_Upd_Emp_Prov(string idEmpleado, string nombreEmpleado, string rfcEmpleado, string emailEmpleado, string telefonoEmpleado, string idProveedor)
        {
            InitializeComponent();
            this.idProveedor = idProveedor;
            LlenarComboBoxProveedores();
            Txt_ID_Emp_Prov.Text = idEmpleado;
            Txt_Nom_Emp_Prov.Text = nombreEmpleado;
            Txt_RFC_Emp_Prov.Text = rfcEmpleado;
            Txt_Email_Emp_Prov.Text = emailEmpleado;
            Txt_Phone_Emp_Prov.Text = telefonoEmpleado;
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
                BoxProveedor.ValueMember = "Id_Prov";    // Guardar el ID del proveedor

                // Establecer SelectedValue después de que el ComboBox se haya llenado
                BoxProveedor.SelectedValue = idProveedor;
            }
        }

        private void Btn_Aceptar_Emp_Prov2_Click(object sender, EventArgs e)
        {
            NombreEmpleado = Txt_Nom_Emp_Prov.Text;
            RfcEmpleado = Txt_RFC_Emp_Prov.Text;
            EmailEmpleado = Txt_Email_Emp_Prov.Text;
            TelefonoEmpleado = Txt_Phone_Emp_Prov.Text;

            UpdateEmpleadoProveedor();
            MessageBox.Show("Se ha editado el Empleado de Proveedor");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateEmpleadoProveedor()
        {
            if (BoxProveedor.SelectedValue == null)
            {
                MessageBox.Show("El proveedor no puede estar vacío");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"UPDATE EmpleadosProveedor 
                         SET Nom_Emp_Prov = @Nombre,
                             RFC_Emp_Prov = @RFC,
                             Email_Emp_Prov = @Correo,
                             Phone_Emp_Prov = @Telefono,
                             Id_Prov = @IdProveedor
                         WHERE Id_Emp_Prov = @IdEmpleado";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdEmpleado", Txt_ID_Emp_Prov.Text);
                    command.Parameters.AddWithValue("@Nombre", Txt_Nom_Emp_Prov.Text);
                    command.Parameters.AddWithValue("@RFC", Txt_RFC_Emp_Prov.Text);
                    command.Parameters.AddWithValue("@Correo", Txt_Email_Emp_Prov.Text);
                    command.Parameters.AddWithValue("@Telefono", Txt_Phone_Emp_Prov.Text);
                    command.Parameters.AddWithValue("@IdProveedor", BoxProveedor.SelectedValue);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Btn_Cancelar_Emp_Prov2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
