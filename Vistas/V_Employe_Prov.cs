﻿using System;
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
        private V_NavBar NavBar;
        private DataTable empleadosProveedorDataTable;

        public V_Employe_Prov(V_NavBar MainNavBar)
        {
            InitializeComponent();            
            this.NavBar = MainNavBar;
            LlenarComboBoxProveedores();
            CargarDatosEmpleadosProveedor("");
            ConfigurarTabla();
            DGV_Table_Emp_Prov.Focus();
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

                // Agregar la opción "Todos" al ComboBox
                DataRow newRow = dataTable.NewRow();
                newRow["Nom_Prov"] = "Todos";
                dataTable.Rows.InsertAt(newRow, 0);               
            }
        }

        private void ConfigurarTabla()
        {
            DGV_Table_Emp_Prov.Dock = DockStyle.Fill;

            DGV_Table_Emp_Prov.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Table_Emp_Prov.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            // Centrar el texto de las celdas de identificadores
            DGV_Table_Emp_Prov.Columns["Id_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Table_Emp_Prov.Columns["RFC_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Emp_Prov.Columns["Phone_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Table_Emp_Prov.Columns["Id_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear a la izquierda las columnas de texto
            DGV_Table_Emp_Prov.Columns["Nom_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Emp_Prov.Columns["Email_Emp_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Emp_Prov.Columns["Nom_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;    

            // Centrar el texto de los encabezados
            DGV_Table_Emp_Prov.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            DGV_Table_Emp_Prov.Columns["Id_Emp_Prov"].HeaderText = "ID Empleado Proveedor";
            DGV_Table_Emp_Prov.Columns["Nom_Emp_Prov"].HeaderText = "Nombre Empleado";
            DGV_Table_Emp_Prov.Columns["RFC_Emp_Prov"].HeaderText = "RFC Empleado";
            DGV_Table_Emp_Prov.Columns["Email_Emp_Prov"].HeaderText = "Correo";
            DGV_Table_Emp_Prov.Columns["Phone_Emp_Prov"].HeaderText = "Teléfono";
            DGV_Table_Emp_Prov.Columns["Nom_Prov"].HeaderText = "Proveedor";

            DGV_Table_Emp_Prov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Table_Emp_Prov.ScrollBars = ScrollBars.Both;

            DGV_Table_Emp_Prov.ReadOnly = true;
            DGV_Table_Emp_Prov.AllowUserToAddRows = false;

            // Configuración de colores
            DGV_Table_Emp_Prov.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            DGV_Table_Emp_Prov.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            DGV_Table_Emp_Prov.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            DGV_Table_Emp_Prov.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            DGV_Table_Emp_Prov.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            DGV_Table_Emp_Prov.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }


        private void Btn_Add_Emp_Prov_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Emp_Prov Add_Emp_Prov = new V_CRUD_Add_Emp_Prov();
            Add_Emp_Prov.ShowDialog();
            CargarDatosEmpleadosProveedor("");
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
                string idProveedor = selectedRow.Cells["Id_Prov"].Value?.ToString() ?? "N/A"; // Obtener Id_Prov en lugar de Nom_Prov

                V_CRUD_Upd_Emp_Prov Upd_Emp_Prov = new V_CRUD_Upd_Emp_Prov(idEmpProv, nombreEmp, rfc, email, telefono, idProveedor);
                Upd_Emp_Prov.ShowDialog();
                CargarDatosEmpleadosProveedor("");
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
                        CargarDatosEmpleadosProveedor("");
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
            string query = "UPDATE  EmpleadosProveedor SET LifeOrDie = 0 WHERE Id_Emp_Prov = @Id_Emp_Prov";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Emp_Prov", idEmpProv);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CargarDatosEmpleadosProveedor(string filtro)
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
        EmpleadosProveedor.LifeOrDie = 1 
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
                    DGV_Table_Emp_Prov.DataSource = empleadosProveedorDataTable;
                }
            }
        }


        private void BEmpProvRemoved_Click(object sender, EventArgs e)
        {
         NavBar.AbrirFormularioEnPanel(new V_EmpProvRemoved(), "Empleados de Proveedor Eliminados");   
        }
    }
}
