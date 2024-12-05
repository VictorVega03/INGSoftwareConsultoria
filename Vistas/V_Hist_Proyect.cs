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
    public partial class V_Hist_Proyect : Form
    {
        private V_NavBar NavBar;
        public V_Hist_Proyect(V_NavBar MainNavBar)
        {
            InitializeComponent();
            this.NavBar = MainNavBar;
            CargarAllProyectos();
            ConfigurarTabla();
            FiltroFecha1.Value = DateTime.Now.AddDays(-5);
        }
        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            TablaHistProyect.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            TablaHistProyect.DefaultCellStyle.Font = new Font("Arial", 14);
            TablaHistProyect.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

            // Centrar el texto de las celdas de identificadores
            TablaHistProyect.Columns["Id_Proyecto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TablaHistProyect.Columns["Estado_Proyecto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear a la izquierda las columnas descriptivas
            TablaHistProyect.Columns["Nombre_Proyecto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaHistProyect.Columns["Dia_Inicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaHistProyect.Columns["Dia_Termino"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaHistProyect.Columns["Nombre_Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaHistProyect.Columns["Nombre_Empleado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TablaHistProyect.Columns["Nombre_Proveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Centrar el texto de los encabezados
            TablaHistProyect.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            TablaHistProyect.Columns["Id_Proyecto"].HeaderText = "ID Proyecto";
            TablaHistProyect.Columns["Nombre_Proyecto"].HeaderText = "Nombre Proyecto";
            TablaHistProyect.Columns["Estado_Proyecto"].HeaderText = "Estado";
            TablaHistProyect.Columns["Dia_Inicio"].HeaderText = "Fecha de Inicio";
            TablaHistProyect.Columns["Dia_Termino"].HeaderText = "Fecha de Cierre";
            TablaHistProyect.Columns["Nombre_Cliente"].HeaderText = "Cliente";
            TablaHistProyect.Columns["Nombre_Empleado"].HeaderText = "Promotor Responsable";
            TablaHistProyect.Columns["Nombre_Proveedor"].HeaderText = "Proveedor Responsable";

            // Habilitar scroll automático
            TablaHistProyect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaHistProyect.ScrollBars = ScrollBars.Both;

            TablaHistProyect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaHistProyect.RowHeadersVisible = false;
            TablaHistProyect.ReadOnly = true;
            TablaHistProyect.AllowUserToAddRows = false;

            // Configuración de colores
            TablaHistProyect.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            TablaHistProyect.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            TablaHistProyect.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            TablaHistProyect.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            TablaHistProyect.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            TablaHistProyect.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }

        public void CargarAllProyectos(string filtro = "", DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // Construcción dinámica de la consulta SQL
            string query = @"
SELECT 
    P.Id_Proyecto,
    P.Nombre AS Nombre_Proyecto,
    SP.Name_SttProAct AS Estado_Proyecto,
    P.Dia_Inicio, 
    P.Dia_Termino,
    C.Nom_Client AS Nombre_Cliente,
    E.Nom_Emp AS Nombre_Empleado,    
    PR.Nom_Prov AS Nombre_Proveedor           
FROM Proyect P
LEFT JOIN Clientes C ON P.Nombre_Cliente = C.Id_Client
LEFT JOIN Empleados E ON P.Id_Emp = E.Id_Emp
LEFT JOIN StatusProAct SP ON P.Id_SttProAct = SP.Id_SttProAct
LEFT JOIN Proveedores PR ON P.Id_Prov = PR.Id_Prov 
WHERE P.LifeOrDie = 0 ";

            // Agregar condición para fechas si los valores están presentes
            if (fechaInicio.HasValue && fechaFin.HasValue)
            {
                query += "AND P.Dia_Inicio BETWEEN @FechaInicio AND @FechaFin ";
            }

            // Agregar condición para el filtro de texto
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                query += @"
AND (
    P.Id_Proyecto LIKE @Filtro OR 
    P.Nombre LIKE @Filtro OR 
    SP.Name_SttProAct LIKE @Filtro OR 
    CONVERT(VARCHAR, P.Dia_Inicio, 120) LIKE @Filtro OR 
    C.Nom_Client LIKE @Filtro OR 
    E.Nom_Emp LIKE @Filtro OR 
    PR.Nom_Prov LIKE @Filtro
)";
            }

            query += "ORDER BY P.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el filtro con comodines para la búsqueda, si corresponde
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");
                    }

                    // Agregar parámetros de fechas si están presentes
                    if (fechaInicio.HasValue && fechaFin.HasValue)
                    {
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio.Value);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin.Value);
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable proyectosDataTable = new DataTable();
                    dataAdapter.Fill(proyectosDataTable);

                    // Actualiza la tabla con los datos filtrados
                    TablaHistProyect.DataSource = proyectosDataTable;
                }
            }
        }

        public void CargarHistorialProyectos(string filtro = "", DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            fechaInicio = FiltroFecha1.Value.Date;
            fechaFin = FiltroFecha2.Value.Date;
            // Construcción dinámica de la consulta SQL
            string query = @"
SELECT 
    P.Id_Proyecto,
    P.Nombre AS Nombre_Proyecto,
    SP.Name_SttProAct AS Estado_Proyecto,
    P.Dia_Inicio, 
    P.Dia_Termino,
    C.Nom_Client AS Nombre_Cliente,
    E.Nom_Emp AS Nombre_Empleado,    
    PR.Nom_Prov AS Nombre_Proveedor           
FROM Proyect P
LEFT JOIN Clientes C ON P.Nombre_Cliente = C.Id_Client
LEFT JOIN Empleados E ON P.Id_Emp = E.Id_Emp
LEFT JOIN StatusProAct SP ON P.Id_SttProAct = SP.Id_SttProAct
LEFT JOIN Proveedores PR ON P.Id_Prov = PR.Id_Prov 
WHERE P.LifeOrDie = 0 ";

            // Agregar condición para fechas si los valores están presentes
            if (fechaInicio.HasValue && fechaFin.HasValue)
            {
                query += "AND P.Dia_Inicio BETWEEN @FechaInicio AND @FechaFin ";
            }

            // Agregar condición para el filtro de texto
            query += @"
AND (
    P.Id_Proyecto LIKE @Filtro OR 
    P.Nombre LIKE @Filtro OR 
    SP.Name_SttProAct LIKE @Filtro OR 
    CONVERT(VARCHAR, P.Dia_Inicio, 120) LIKE @Filtro OR 
    CONVERT(VARCHAR, P.Dia_Termino, 120) LIKE @Filtro OR 
    C.Nom_Client LIKE @Filtro OR 
    E.Nom_Emp LIKE @Filtro OR 
    PR.Nom_Prov LIKE @Filtro
)
ORDER BY P.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el filtro con comodines para la búsqueda
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    // Agregar parámetros de fechas si están presentes
                    if (fechaInicio.HasValue && fechaFin.HasValue)
                    {
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio.Value);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin.Value);
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable proyectosDataTable = new DataTable();
                    dataAdapter.Fill(proyectosDataTable);

                    // Actualiza la tabla con los datos filtrados
                    TablaHistProyect.DataSource = proyectosDataTable;
                }
            }
        }

        private void BverProyecto_Click(object sender, EventArgs e)
        {
            if (TablaHistProyect.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TablaHistProyect.SelectedRows[0];
                string idProyecto = selectedRow.Cells["Id_Proyecto"].Value?.ToString() ?? "N/A";
                string nombreProyecto = selectedRow.Cells["Nombre_Proyecto"].Value?.ToString() ?? "N/A";
                string cliente = selectedRow.Cells["Nombre_Cliente"].Value?.ToString() ?? "N/A";
                string estadoProyecto = selectedRow.Cells["Estado_Proyecto"].Value?.ToString() ?? "N/A";
                string empleado = selectedRow.Cells["Nombre_Empleado"].Value?.ToString() ?? "N/A";
                string proveedor = selectedRow.Cells["Nombre_Proveedor"].Value?.ToString() ?? "N/A";

                V_CRUD_Upd_Proyect updProyect = new V_CRUD_Upd_Proyect(idProyecto, nombreProyecto, cliente, estadoProyecto, empleado, proveedor, 1, null);
                updProyect.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para actualizar.");
            }
        }

        private void Bnota_Click(object sender, EventArgs e)
        {
            if (TablaHistProyect.SelectedRows.Count > 0)
            {
                string idProyecto = TablaHistProyect.SelectedRows[0].Cells["Id_Proyecto"].Value.ToString();
                V_CRUD_FPC_Proyect FPC_Proyect = new V_CRUD_FPC_Proyect(idProyecto, 1);
                FPC_Proyect.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para realizar la operacion.");
            }
        }

        private void BFiltrarFecha_Click(object sender, EventArgs e)
        {
            // Obtén las fechas seleccionadas en los DateTimePickers
            DateTime fechaInicio = FiltroFecha1.Value.Date;
            DateTime fechaFin = FiltroFecha2.Value.Date;

            // Valida que las fechas sean correctas
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.", "Error en las fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llama al método para cargar los datos con el rango de fechas
            CargarProyectosPorFechas(fechaInicio, fechaFin);
        }
        private void CargarProyectosPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string query = @"
    SELECT 
        P.Id_Proyecto,
        P.Nombre AS Nombre_Proyecto,
        SP.Name_SttProAct AS Estado_Proyecto,
        P.Dia_Inicio, 
        C.Nom_Client AS Nombre_Cliente,
        E.Nom_Emp AS Nombre_Empleado,    
        PR.Nom_Prov AS Nombre_Proveedor           
    FROM Proyect P
    LEFT JOIN Clientes C ON P.Nombre_Cliente = C.Id_Client
    LEFT JOIN Empleados E ON P.Id_Emp = E.Id_Emp
    LEFT JOIN StatusProAct SP ON P.Id_SttProAct = SP.Id_SttProAct
    LEFT JOIN Proveedores PR ON P.Id_Prov = PR.Id_Prov 
    WHERE P.LifeOrDie = 0 
    AND P.Dia_Inicio BETWEEN @FechaInicio AND @FechaFin
    ORDER BY P.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar los parámetros de las fechas al comando
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable proyectosDataTable = new DataTable();
                    dataAdapter.Fill(proyectosDataTable);

                    // Actualiza la tabla con los datos filtrados
                    TablaHistProyect.DataSource = proyectosDataTable;
                }
            }
        }
    }
}
