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
    public partial class V_Hist_Act : Form
    {
        public string idProyecto;
        private V_NavBar NavBar;

        public V_Hist_Act(V_NavBar MainNavBar, string idProyecto)
        {
            InitializeComponent();
            CargarHistActividades(idProyecto, "");
            ConfigurarTabla();
            this.idProyecto = idProyecto;
            this.NavBar = MainNavBar;
        }
        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            TablaHistAct.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            TablaHistAct.DefaultCellStyle.Font = new Font("Arial", 14);
            TablaHistAct.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);

            // Centrar el texto
            TablaHistAct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TablaHistAct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            TablaHistAct.Columns["ID Actividad"].HeaderText = "ID Actividad";
            TablaHistAct.Columns["ID Proyecto"].HeaderText = "ID Proyecto";
            TablaHistAct.Columns["Nombre Proyecto"].HeaderText = "Nombre Proyecto";
            TablaHistAct.Columns["Nombre Actividad"].HeaderText = "Nombre Actividad";
            TablaHistAct.Columns["Empleado Responsable"].HeaderText = "Empleado Responsable";
            TablaHistAct.Columns["Empleado Proveedor"].HeaderText = "Empleado Proveedor";
            TablaHistAct.Columns["Estado Actividad"].HeaderText = "Estado Actividad";
            //TablaHistAct.Columns["Creado Por"].HeaderText = "Creado Por";
            TablaHistAct.Columns["Fecha Inicio"].HeaderText = "Fecha de Inicio";
            TablaHistAct.Columns["Fecha Termino"].HeaderText = "Fecha de Cierre";

            // Habilitar scroll automático
            TablaHistAct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaHistAct.ScrollBars = ScrollBars.Both;

            TablaHistAct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaHistAct.RowHeadersVisible = false;
            TablaHistAct.ReadOnly = true;
            TablaHistAct.AllowUserToAddRows = false;

            // Configuración de colores
            TablaHistAct.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            TablaHistAct.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            TablaHistAct.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            TablaHistAct.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            TablaHistAct.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            TablaHistAct.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }
        public void CargarHistActividades(string idProyecto, string filtro)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
SELECT 
    A.Id_Activity AS [ID Actividad],
    A.Id_Proyecto AS [ID Proyecto],
    P.Nombre AS [Nombre Proyecto],
    A.Nombre_Activity AS [Nombre Actividad],
    E.Nom_Emp AS [Empleado Responsable],
    EP.Nom_Emp_Prov AS [Empleado Proveedor],
    SP.Name_SttProAct AS [Estado Actividad],          
    A.Dia_Inicio AS [Fecha Inicio],
    A.Dia_Termino AS [Fecha Termino]            
FROM Actividad A
LEFT JOIN Proyect P ON A.Id_Proyecto = P.Id_Proyecto
LEFT JOIN Empleados E ON A.Id_Emp = E.Id_Emp
LEFT JOIN EmpleadosProveedor EP ON A.Id_Emp_Prov = EP.Id_Emp_Prov
LEFT JOIN StatusProAct SP ON A.Id_SttProAct = SP.Id_SttProAct
WHERE A.activo = 0 
    AND A.Id_Proyecto = @idProyecto
    AND (
        A.Id_Activity LIKE @Filtro OR
        P.Nombre LIKE @Filtro OR
        A.Nombre_Activity LIKE @Filtro OR
        E.Nom_Emp LIKE @Filtro OR
        EP.Nom_Emp_Prov LIKE @Filtro OR
        SP.Name_SttProAct LIKE @Filtro OR
        CONVERT(VARCHAR, A.Dia_Inicio, 120) LIKE @Filtro OR
        CONVERT(VARCHAR, A.Dia_Termino, 120) LIKE @Filtro
    )
ORDER BY A.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar los parámetros para filtrar por idProyecto y el filtro general
                    command.Parameters.AddWithValue("@idProyecto", idProyecto);
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable actividadDataTable = new DataTable();
                    dataAdapter.Fill(actividadDataTable);

                    // Asumiendo que tienes un DataGridView llamado TablaHistAct
                    TablaHistAct.DataSource = actividadDataTable;
                }
            }
        }


        private void BverActividad_Click(object sender, EventArgs e)
        {
            if (TablaHistAct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TablaHistAct.SelectedRows[0];
                string idActividad = selectedRow.Cells["ID Actividad"].Value?.ToString() ?? "N/A";
                string idProyecto = selectedRow.Cells["ID Proyecto"].Value?.ToString() ?? "N/A";
                string nombreActividad = selectedRow.Cells["Nombre Actividad"].Value?.ToString() ?? "N/A";
                string empleado = selectedRow.Cells["Empleado Responsable"].Value?.ToString() ?? "N/A";
                string empleadoProveedor = selectedRow.Cells["Empleado Proveedor"].Value?.ToString() ?? "N/A";
                string estadoActividad = selectedRow.Cells["Estado Actividad"].Value?.ToString() ?? "N/A";
                string fechaInicio = selectedRow.Cells["Fecha Inicio"].Value?.ToString() ?? "N/A";

                // Llamar a la vista para actualizar actividades
                V_CRUD_Upd_Act updAct = new V_CRUD_Upd_Act(idActividad, idProyecto, nombreActividad, empleado, empleadoProveedor, estadoActividad, 1, NavBar);
                updAct.ShowDialog();

                // Recargar los datos de actividades después de la actualización
                CargarHistActividades(idProyecto, "");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una actividad para actualizar.");
            }
        }
    }
}
