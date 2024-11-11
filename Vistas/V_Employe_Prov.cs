using System;
using System.Collections.Generic;
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
    public partial class V_Employe_Prov : Form
    {
        private DataTable empleadosProveedorDataTable;

        public V_Employe_Prov()
        {
            InitializeComponent();
            LlenarComboBoxProveedores();
            CargarDatosEmpleadosProveedor();
            ConfigurarTabla();
            DGV_Table_Emp_Prov.Focus();
        }

        private void LlenarComboBoxProveedores()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Prov, Nom_Prov FROM Provedores WHERE LifeOrDie = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Agregar la opción "Todos" al ComboBox
                DataRow newRow = dataTable.NewRow();
                newRow["Nom_Prov"] = "Todos";
                dataTable.Rows.InsertAt(newRow, 0);

                // Asignar el DataTable como origen de datos del ComboBox
                BoxFiltroEmpProv.DataSource = dataTable;
                BoxFiltroEmpProv.DisplayMember = "Nom_Prov";
                BoxFiltroEmpProv.ValueMember = "Id_Prov";
                BoxFiltroEmpProv.SelectedIndex = 0; // Seleccionar "Todos" por defecto
            }
        }

        private void ConfigurarTabla()
        {
            DGV_Table_Emp_Prov.Dock = DockStyle.Fill;

            DGV_Table_Emp_Prov.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Table_Emp_Prov.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            DGV_Table_Emp_Prov.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Table_Emp_Prov.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGV_Table_Emp_Prov.Columns["Id_Emp_Prov"].HeaderText = "ID Empleado Proveedor";
            DGV_Table_Emp_Prov.Columns["Nom_Emp_Prov"].HeaderText = "Nombre Empleado";
            DGV_Table_Emp_Prov.Columns["RFC_Emp_Prov"].HeaderText = "RFC Empleado";
            DGV_Table_Emp_Prov.Columns["Email_Emp_Prov"].HeaderText = "Correo";
            DGV_Table_Emp_Prov.Columns["Phone_Emp_Prov"].HeaderText = "Teléfono";
            DGV_Table_Emp_Prov.Columns["Nom_Prov"].HeaderText = "Proveedor";

            DGV_Table_Emp_Prov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Table_Emp_Prov.ScrollBars = ScrollBars.Both;
        }

        private void Btn_Add_Emp_Prov_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Emp_Prov Add_Emp_Prov = new V_CRUD_Add_Emp_Prov();
            Add_Emp_Prov.ShowDialog();
            CargarDatosEmpleadosProveedor();
        }

        private void Btn_Upd_Emp_Prov_Click(object sender, EventArgs e)
        {
            if (DGV_Table_Emp_Prov.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Table_Emp_Prov.SelectedRows[0];
                string idEmpProv = selectedRow.Cells["Id_Emp_Prov"].Value?.ToString() ?? "N/A";
                string nombreEmp = selectedRow.Cells["Nom_Emp_Prov"].Value?.ToString() ?? "N/A";
                string rfc = selectedRow.Cells["RFC_Emp_Prov"].Value?.ToString() ?? "N/A";
                string email = selectedRow.Cells["Email_Emp_Prov"].Value?.ToString() ?? "N/A";
                string telefono = selectedRow.Cells["Phone_Emp_Prov"].Value?.ToString() ?? "N/A";
                string proveedor = selectedRow.Cells["Nom_Prov"].Value?.ToString() ?? "N/A";

                V_CRUD_Upd_Emp_Prov Upd_Emp_Prov = new V_CRUD_Upd_Emp_Prov(idEmpProv, nombreEmp, rfc, email, telefono, proveedor);
                Upd_Emp_Prov.ShowDialog();
                CargarDatosEmpleadosProveedor();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado de proveedor para actualizar.");
            }
        }

        private void Btn_Eliminar_Emp_Prov_Click(object sender, EventArgs e)
        {
            if (DGV_Table_Emp_Prov.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Table_Emp_Prov.SelectedRows[0];
                var idCell = selectedRow.Cells["Id_Emp_Prov"];
                var nameCell = selectedRow.Cells["Nom_Emp_Prov"];

                if (idCell?.Value != null && nameCell?.Value != null)
                {
                    string idEmpProv = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de eliminar al empleado {nombre}, con el ID de Proveedor {idEmpProv}?", "Eliminar Empleado Proveedor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteEmpleadoProveedor(idEmpProv);
                        MessageBox.Show("Empleado eliminado exitosamente.");
                        CargarDatosEmpleadosProveedor();
                    }
                }
                else
                {
                    MessageBox.Show("El empleado de proveedor seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado de proveedor para eliminar.");
            }
        }

        private void deleteEmpleadoProveedor(string idEmpProv)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE  ProvedoresEmpleados SET LifeOrDie = 0 WHERE Id_Emp_Prov = @Id_Emp_Prov";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Emp_Prov", idEmpProv);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void CargarDatosEmpleadosProveedor()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
    SELECT 
        ProvedoresEmpleados.Id_Emp_Prov,
        ProvedoresEmpleados.Nom_Emp_Prov,
        ProvedoresEmpleados.RFC_Emp_Prov,
        ProvedoresEmpleados.Email_Emp_Prov,
        ProvedoresEmpleados.Phone_Emp_Prov,
        Provedores.Nom_Prov
    FROM ProvedoresEmpleados
    INNER JOIN Provedores ON ProvedoresEmpleados.Id_Prov = Provedores.Id_Prov 
    WHERE ProvedoresEmpleados.LifeOrDie = 1 ORDER BY ProvedoresEmpleados.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                empleadosProveedorDataTable = new DataTable();
                dataAdapter.Fill(empleadosProveedorDataTable);
                DGV_Table_Emp_Prov.DataSource = empleadosProveedorDataTable;
            }
        }

        private void BoxFiltroEmpProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDatosEmpleadosProveedor();
        }

        private void FiltrarDatosEmpleadosProveedor()
        {
            if (!string.IsNullOrEmpty(BoxFiltroEmpProv.Text))
            {
                if (BoxFiltroEmpProv.Text == "Todos")
                {
                    DGV_Table_Emp_Prov.DataSource = empleadosProveedorDataTable;
                }
                else
                {
                    string proveedor = BoxFiltroEmpProv.Text;

                    DataView dataView = new DataView(empleadosProveedorDataTable);
                    dataView.RowFilter = $"Nom_Prov = '{proveedor}'";

                    DGV_Table_Emp_Prov.DataSource = dataView;
                }
            }
        }
    }
}
