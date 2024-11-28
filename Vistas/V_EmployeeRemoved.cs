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
    public partial class V_EmployeeRemoved : Form
    {
        private DataTable empleadosDataTable;

        public V_EmployeeRemoved()
        {

            InitializeComponent();
            CargarEmpleadosEliminados("");
            ConfigurarTabla();
        }
        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            TablaEmpRemoved.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            TablaEmpRemoved.DefaultCellStyle.Font = new Font("Arial", 14);
            TablaEmpRemoved.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            // Centrar el texto
            TablaEmpRemoved.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TablaEmpRemoved.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            TablaEmpRemoved.Columns["Id_Emp"].HeaderText = "ID Empleado";
            TablaEmpRemoved.Columns["Nom_Emp"].HeaderText = "Nombre";
            TablaEmpRemoved.Columns["Permiso"].HeaderText = "Permisos";
            TablaEmpRemoved.Columns["RFC_Emp"].HeaderText = "RFC Empleado";
            TablaEmpRemoved.Columns["Email_Emp"].HeaderText = "Correo";
            TablaEmpRemoved.Columns["Phone_Emp"].HeaderText = "Teléfono";
            TablaEmpRemoved.Columns["Direccion_Emp"].HeaderText = "Dirección";

            // Habilitar scroll automático
            TablaEmpRemoved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaEmpRemoved.ScrollBars = ScrollBars.Both;

            TablaEmpRemoved.ReadOnly = true;
            TablaEmpRemoved.AllowUserToAddRows = false;

            // Configuración de colores
            TablaEmpRemoved.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            TablaEmpRemoved.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            TablaEmpRemoved.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            TablaEmpRemoved.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            TablaEmpRemoved.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            TablaEmpRemoved.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }

        private void BActivarEmp_Click(object sender, EventArgs e)
        {
            if (TablaEmpRemoved.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TablaEmpRemoved.SelectedRows[0];
                var idCell = selectedRow.Cells["Id_Emp"];
                var nameCell = selectedRow.Cells["Nom_Emp"];

                if (idCell?.Value != null && nameCell?.Value != null)
                {
                    string idEmpleado = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de reactivar al empleado {nombre}, con el ID {idEmpleado}?", "Reacticar Empleado", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ActivarEmpleado(idEmpleado);
                        MessageBox.Show("Empleado reactivado exitosamente.");
                        CargarEmpleadosEliminados("");
                    }
                }
                else
                {
                    MessageBox.Show("El empleado seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para reactivar.");
            }
            CargarEmpleadosEliminados("");
        }

        private void ActivarEmpleado(string idEmpleado)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE Empleados SET LifeOrDIe = 1 WHERE Id_Emp = @Id_Emp";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Emp", idEmpleado);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CargarEmpleadosEliminados(string filtro)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
SELECT 
    Empleados.Id_Emp,
    Empleados.Nom_Emp,
    Permisos.WorkPosition_Permits AS Permiso,
    Empleados.RFC_Emp,
    Empleados.Email_Emp,
    Empleados.Phone_Emp,
    Empleados.Direccion_Emp,
    Empleados.Cuando
FROM 
    Empleados
INNER JOIN 
    Permisos ON Empleados.Id_Permits = Permisos.Id_Permits
WHERE 
    LifeOrDIe = 0
    AND (
        Empleados.Id_Emp LIKE @Filtro OR
        Empleados.Nom_Emp LIKE @Filtro OR
        Permisos.WorkPosition_Permits LIKE @Filtro OR
        Empleados.RFC_Emp LIKE @Filtro OR
        Empleados.Email_Emp LIKE @Filtro OR
        Empleados.Phone_Emp LIKE @Filtro OR
        Empleados.Direccion_Emp LIKE @Filtro OR
        CONVERT(VARCHAR, Empleados.Cuando, 120) LIKE @Filtro
    )
ORDER BY 
    Empleados.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el filtro con comodines para la búsqueda
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    empleadosDataTable = new DataTable();
                    dataAdapter.Fill(empleadosDataTable);
                    empleadosDataTable.Columns.Remove("Cuando");
                    TablaEmpRemoved.DataSource = empleadosDataTable;
                }
            }
        }


    }
}
