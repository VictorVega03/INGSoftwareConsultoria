﻿using System;
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
    public partial class V_Employee : Form
    {
        private DataTable empleadosDataTable;
        private V_NavBar NavBar;

        public V_Employee(V_NavBar MainNavBar)
        {
            InitializeComponent();
            this.NavBar = MainNavBar;
            LlenarComboBoxPermisos();
            CargarDatosEmpleados("");
            ConfigurarTabla();
            DGV_Table_Emp.Focus();
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

                // Agregar la opción "Todos" al ComboBox
                DataRow newRow = dataTable.NewRow();
                newRow["WorkPosition_Permits"] = "Todos";
                dataTable.Rows.InsertAt(newRow, 0); // Insertar al inicio                
            }
        }

        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            DGV_Table_Emp.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            DGV_Table_Emp.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Table_Emp.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            // Centrar el texto de las celdas de identificadores
            DGV_Table_Emp.Columns["Id_Emp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Table_Emp.Columns["RFC_Emp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Emp.Columns["Phone_Emp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear a la izquierda las columnas de texto
            DGV_Table_Emp.Columns["Nom_Emp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Emp.Columns["Permiso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Emp.Columns["Email_Emp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Emp.Columns["Direccion_Emp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Centrar el texto de los encabezados
            DGV_Table_Emp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            DGV_Table_Emp.Columns["Id_Emp"].HeaderText = "ID Empleado";
            DGV_Table_Emp.Columns["Nom_Emp"].HeaderText = "Nombre";
            DGV_Table_Emp.Columns["Permiso"].HeaderText = "Permisos";
            DGV_Table_Emp.Columns["RFC_Emp"].HeaderText = "RFC Empleado";
            DGV_Table_Emp.Columns["Email_Emp"].HeaderText = "Correo";
            DGV_Table_Emp.Columns["Phone_Emp"].HeaderText = "Teléfono";
            DGV_Table_Emp.Columns["Direccion_Emp"].HeaderText = "Dirección";

            // Habilitar scroll automático
            DGV_Table_Emp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Table_Emp.ScrollBars = ScrollBars.Both;

            DGV_Table_Emp.ReadOnly = true;
            DGV_Table_Emp.AllowUserToAddRows = false;

            // Configuración de colores
            DGV_Table_Emp.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            DGV_Table_Emp.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            DGV_Table_Emp.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            DGV_Table_Emp.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            DGV_Table_Emp.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            DGV_Table_Emp.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }


        private void Btn_Add_Emp_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Emp Add_Emp = new V_CRUD_Add_Emp();
            Add_Emp.ShowDialog();
            CargarDatosEmpleados("");
        }

        private void Btn_Upd_Emp_Click(object sender, EventArgs e)
        {
            if (DGV_Table_Emp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Table_Emp.SelectedRows[0];
                string idEmpleado = selectedRow.Cells["Id_Emp"].Value?.ToString() ?? "N/A";
                string nombre = selectedRow.Cells["Nom_Emp"].Value?.ToString() ?? "N/A";
                string puesto = selectedRow.Cells["Permiso"].Value?.ToString() ?? "N/A";
                string rfc = selectedRow.Cells["RFC_Emp"].Value?.ToString() ?? "N/A";
                string email = selectedRow.Cells["Email_Emp"].Value?.ToString() ?? "N/A";
                string telefono = selectedRow.Cells["Phone_Emp"].Value?.ToString() ?? "N/A";
                string direccion = selectedRow.Cells["Direccion_Emp"].Value?.ToString() ?? "N/A";

                V_CRUD_Upd_Emp upd_Emp = new V_CRUD_Upd_Emp(idEmpleado, nombre, puesto, rfc, email, telefono, direccion);             
                upd_Emp.ShowDialog();
                CargarDatosEmpleados("");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para actualizar.");
            }
        }

        private void Btn_Eliminar_Emp_Click(object sender, EventArgs e)
        {
            if (DGV_Table_Emp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Table_Emp.SelectedRows[0];
                var idCell = selectedRow.Cells["Id_Emp"];
                var nameCell = selectedRow.Cells["Nom_Emp"];

                if (idCell?.Value != null && nameCell?.Value != null)
                {
                    string idEmpleado = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de eliminar al empleado {nombre}, con el ID {idEmpleado}?", "Eliminar Empleado", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteEmpleado(idEmpleado);
                        MessageBox.Show("Empleado eliminado exitosamente.");
                        CargarDatosEmpleados("");
                    }
                }
                else
                {
                    MessageBox.Show("El empleado seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
            }
            CargarDatosEmpleados("");
        }

        private void deleteEmpleado(string idEmpleado)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE Empleados SET LifeOrDIe = 0 WHERE Id_Emp = @Id_Emp";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Emp", idEmpleado);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CargarDatosEmpleados(string filtro)
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
    LifeOrDIe = 1
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
                    DGV_Table_Emp.DataSource = empleadosDataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavBar.AbrirFormularioEnPanel(new V_EmployeeRemoved(), "Empleados Eliminados");
        }
    }
}
