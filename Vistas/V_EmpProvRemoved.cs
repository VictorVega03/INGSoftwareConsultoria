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
    public partial class V_EmpProvRemoved : Form
    {
        private DataTable empleadosProveedorDataTable;

        public V_EmpProvRemoved()
        {
            InitializeComponent();
            CargarEmpleadosProvEliminados("");
            ConfigurarTabla();
        }
        private void ConfigurarTabla()
        {
            TablaEmpProvRemoved.Dock = DockStyle.Fill;

            TablaEmpProvRemoved.DefaultCellStyle.Font = new Font("Arial", 14);
            TablaEmpProvRemoved.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            // Centrar el texto de las celdas de identificadores
            TablaEmpProvRemoved.Columns["Id_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TablaEmpProvRemoved.Columns["RFC_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaEmpProvRemoved.Columns["Phone_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TablaEmpProvRemoved.Columns["Id_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear a la izquierda las columnas de texto
            TablaEmpProvRemoved.Columns["Nom_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaEmpProvRemoved.Columns["Email_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaEmpProvRemoved.Columns["Nom_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Centrar el texto de los encabezados
            TablaEmpProvRemoved.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            TablaEmpProvRemoved.Columns["Id_Emp_Prov"].HeaderText = "ID Empleado Proveedor";
            TablaEmpProvRemoved.Columns["Nom_Emp_Prov"].HeaderText = "Nombre Empleado";
            TablaEmpProvRemoved.Columns["RFC_Emp_Prov"].HeaderText = "RFC Empleado";
            TablaEmpProvRemoved.Columns["Email_Emp_Prov"].HeaderText = "Correo";
            TablaEmpProvRemoved.Columns["Phone_Emp_Prov"].HeaderText = "Teléfono";
            TablaEmpProvRemoved.Columns["Nom_Prov"].HeaderText = "Proveedor";

            TablaEmpProvRemoved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaEmpProvRemoved.ScrollBars = ScrollBars.Both;

            TablaEmpProvRemoved.ReadOnly = true;
            TablaEmpProvRemoved.AllowUserToAddRows = false;

            // Configuración de colores
            TablaEmpProvRemoved.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            TablaEmpProvRemoved.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            TablaEmpProvRemoved.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            TablaEmpProvRemoved.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            TablaEmpProvRemoved.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            TablaEmpProvRemoved.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }

        private void BactivarEmpProv_Click(object sender, EventArgs e)
        {
            if (TablaEmpProvRemoved.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TablaEmpProvRemoved.SelectedRows[0];
                var idCell = selectedRow.Cells["Id_Emp_Prov"];
                var nameCell = selectedRow.Cells["Nom_Emp_Prov"];

                if (idCell?.Value != null && nameCell?.Value != null)
                {
                    string idEmpProv = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de reactivar al empleado {nombre}, con el ID de Proveedor {idEmpProv}?", "Reactivar Empleado Proveedor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        activarEmpleadoProveedor(idEmpProv);
                        MessageBox.Show("Empleado reactivado exitosamente.");
                        CargarEmpleadosProvEliminados("");
                    }
                }
                else
                {
                    MessageBox.Show("El empleado de proveedor seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado de proveedor para reactivar.");
            }
        }
        private void activarEmpleadoProveedor(string idEmpProv)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE  EmpleadosProveedor SET LifeOrDie = 1 WHERE Id_Emp_Prov = @Id_Emp_Prov";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Emp_Prov", idEmpProv);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void CargarEmpleadosProvEliminados(string filtro)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
    SELECT 
        EmpleadosProveedor.Id_Emp_Prov,
        EmpleadosProveedor.Nom_Emp_Prov,
        EmpleadosProveedor.RFC_Emp_Prov,
        EmpleadosProveedor.Email_Emp_Prov,
        EmpleadosProveedor.Phone_Emp_Prov,
        Proveedores.Id_Prov, 
        Proveedores.Nom_Prov
    FROM 
        EmpleadosProveedor
    INNER JOIN 
        Proveedores ON EmpleadosProveedor.Id_Prov = Proveedores.Id_Prov 
    WHERE 
        EmpleadosProveedor.LifeOrDie = 0
        AND (
            EmpleadosProveedor.Id_Emp_Prov LIKE @Filtro OR
            EmpleadosProveedor.Nom_Emp_Prov LIKE @Filtro OR
            EmpleadosProveedor.RFC_Emp_Prov LIKE @Filtro OR
            EmpleadosProveedor.Email_Emp_Prov LIKE @Filtro OR
            EmpleadosProveedor.Phone_Emp_Prov LIKE @Filtro OR
            Proveedores.Id_Prov LIKE @Filtro OR
            Proveedores.Nom_Prov LIKE @Filtro
        )
    ORDER BY 
        EmpleadosProveedor.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el filtro con comodines para la búsqueda
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    empleadosProveedorDataTable = new DataTable();
                    dataAdapter.Fill(empleadosProveedorDataTable);
                    TablaEmpProvRemoved.DataSource = empleadosProveedorDataTable;
                }
            }
        }

    }
}
