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
    public partial class V_Proyect : Form
    {
        private V_NavBar NavBar;

        public V_Proyect(V_NavBar MainNavBar)
        {
            InitializeComponent();
            CargarAllProyectos();                      
            userType(dataLogin.userPermits);
            this.NavBar = MainNavBar;            
            ConfigurarTabla();
            FiltroFecha1.Value = DateTime.Now.AddDays(-5);         
        }
          
        private void userType(int userPermits)
        {
            if (userPermits == 3) // proveedor
            {
                Btn_Add_Proyect.Enabled = false;
                Btn_Add_Proyect.BackColor = Color.Gray;
                Btn_Upd_Proyect.Enabled = false;
                Btn_Upd_Proyect.BackColor = Color.Gray;
                Btn_FPC_Proyect.Enabled = false;
                Btn_FPC_Proyect.BackColor = Color.Gray;
            }
            else if (userPermits == 4) // empleado general
            {
                Btn_Add_Proyect.Enabled = false;
                Btn_Add_Proyect.BackColor = Color.Gray;
                Btn_Upd_Proyect.Enabled = false;
                Btn_Upd_Proyect.BackColor = Color.Gray;
                Btn_FPC_Proyect.Enabled = false;
                Btn_FPC_Proyect.BackColor = Color.Gray;
            }
            else if (userPermits == 5) // empleado proveedor
            {
                Btn_Add_Proyect.Enabled = false;
                Btn_Add_Proyect.BackColor = Color.Gray;
                Btn_Upd_Proyect.Enabled = false;
                Btn_Upd_Proyect.BackColor = Color.Gray;
                Btn_FPC_Proyect.Enabled = false;
                Btn_FPC_Proyect.BackColor = Color.Gray;
            }
        }
        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            DGV_Tabla_Proyect.Dock = DockStyle.Fill;

            // Configuración de colores
            DGV_Tabla_Proyect.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            DGV_Tabla_Proyect.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de encabezados
            DGV_Tabla_Proyect.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue; // Fondo del encabezado
            DGV_Tabla_Proyect.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto del encabezado
            DGV_Tabla_Proyect.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DodgerBlue; // Fondo al seleccionar encabezado
            DGV_Tabla_Proyect.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar encabezado

            // Configuración de las celdas
            DGV_Tabla_Proyect.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            DGV_Tabla_Proyect.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            DGV_Tabla_Proyect.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            DGV_Tabla_Proyect.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda

            // Configuración de texto
            DGV_Tabla_Proyect.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Tabla_Proyect.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

            DGV_Tabla_Proyect.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            DGV_Tabla_Proyect.Columns["Id_Proyecto"].HeaderText = "ID Proyecto";
            DGV_Tabla_Proyect.Columns["Nombre_Proyecto"].HeaderText = "Nombre Proyecto";
            DGV_Tabla_Proyect.Columns["Estado_Proyecto"].HeaderText = "Estado";
            DGV_Tabla_Proyect.Columns["Dia_Inicio"].HeaderText = "Fecha de Inicio";
            DGV_Tabla_Proyect.Columns["Nombre_Cliente"].HeaderText = "Cliente";
            DGV_Tabla_Proyect.Columns["Nombre_Empleado"].HeaderText = "Promotor Responsable";
            DGV_Tabla_Proyect.Columns["Nombre_Proveedor"].HeaderText = "Proveedor Responsable";

            // Alineación de las celdas de acuerdo a la columna
            // Centramos las columnas de identificadores
            DGV_Tabla_Proyect.Columns["Id_Proyecto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Tabla_Proyect.Columns["Estado_Proyecto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alineamos a la izquierda las columnas descriptivas
            DGV_Tabla_Proyect.Columns["Nombre_Proyecto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Tabla_Proyect.Columns["Dia_Inicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Tabla_Proyect.Columns["Nombre_Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Tabla_Proyect.Columns["Nombre_Empleado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Tabla_Proyect.Columns["Nombre_Proveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Habilitar scroll automático
            DGV_Tabla_Proyect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Tabla_Proyect.ScrollBars = ScrollBars.Both;

            // Configuración adicional
            DGV_Tabla_Proyect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Tabla_Proyect.RowHeadersVisible = false;
            DGV_Tabla_Proyect.ReadOnly = true;
            DGV_Tabla_Proyect.AllowUserToAddRows = false;
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
    C.Nom_Client AS Nombre_Cliente,
    E.Nom_Emp AS Nombre_Empleado,    
    PR.Nom_Prov AS Nombre_Proveedor           
FROM Proyect P
LEFT JOIN Clientes C ON P.Nombre_Cliente = C.Id_Client
LEFT JOIN Empleados E ON P.Id_Emp = E.Id_Emp
LEFT JOIN StatusProAct SP ON P.Id_SttProAct = SP.Id_SttProAct
LEFT JOIN Proveedores PR ON P.Id_Prov = PR.Id_Prov 
WHERE P.LifeOrDie = 1 ";

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
                    DGV_Tabla_Proyect.DataSource = proyectosDataTable;
                }
            }            
        }

        public void CargarDatosProyectos(string filtro = "", DateTime? fechaInicio = null, DateTime? fechaFin = null)
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
    C.Nom_Client AS Nombre_Cliente,
    E.Nom_Emp AS Nombre_Empleado,    
    PR.Nom_Prov AS Nombre_Proveedor           
FROM Proyect P
LEFT JOIN Clientes C ON P.Nombre_Cliente = C.Id_Client
LEFT JOIN Empleados E ON P.Id_Emp = E.Id_Emp
LEFT JOIN StatusProAct SP ON P.Id_SttProAct = SP.Id_SttProAct
LEFT JOIN Proveedores PR ON P.Id_Prov = PR.Id_Prov 
WHERE P.LifeOrDie = 1 ";

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
                    DGV_Tabla_Proyect.DataSource = proyectosDataTable;
                }
            }        
        }          

        private void Btn_Add_Proyect_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Proyect Add_Proyect = new V_CRUD_Add_Proyect();
            Add_Proyect.ShowDialog();            
            CargarDatosProyectos("");
            CargarAllProyectos();
        }

        private void Btn_Upd_Proyect_Click(object sender, EventArgs e)
        {
            if (DGV_Tabla_Proyect.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Tabla_Proyect.SelectedRows[0];
                string idProyecto = selectedRow.Cells["Id_Proyecto"].Value?.ToString() ?? "N/A";
                string nombreProyecto = selectedRow.Cells["Nombre_Proyecto"].Value?.ToString() ?? "N/A";
                string cliente = selectedRow.Cells["Nombre_Cliente"].Value?.ToString() ?? "N/A";
                string estadoProyecto = selectedRow.Cells["Estado_Proyecto"].Value?.ToString() ?? "N/A";
                string empleado = selectedRow.Cells["Nombre_Empleado"].Value?.ToString() ?? "N/A";
                string proveedor = selectedRow.Cells["Nombre_Proveedor"].Value?.ToString() ?? "N/A";

                V_CRUD_Upd_Proyect updProyect = new V_CRUD_Upd_Proyect(idProyecto, nombreProyecto, cliente, estadoProyecto, empleado, proveedor, 0, NavBar);
                updProyect.ShowDialog();                
                CargarDatosProyectos("");
                CargarAllProyectos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para actualizar.");
            }

        }

        private void Btn_FPC_Proyect_Click(object sender, EventArgs e)
        {
            if (DGV_Tabla_Proyect.SelectedRows.Count > 0)
            {
                string idProyecto = DGV_Tabla_Proyect.SelectedRows[0].Cells["Id_Proyecto"].Value.ToString();
                V_CRUD_FPC_Proyect FPC_Proyect = new V_CRUD_FPC_Proyect(idProyecto, 0);
                FPC_Proyect.ShowDialog();                
                CargarDatosProyectos("");
                CargarAllProyectos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para realizar la operacion.");
            }
        }

        private void Btn_Hist_Proyect_Click(object sender, EventArgs e)
        {
            NavBar.AbrirFormularioEnPanel(new V_Hist_Proyect(NavBar), "Historial de Proyectos");
        }

        private void Btn_Act_Click(object sender, EventArgs e)
        {
            if (DGV_Tabla_Proyect.SelectedRows.Count > 0)
            {                
                string idProyecto = DGV_Tabla_Proyect.SelectedRows[0].Cells["Id_Proyecto"].Value?.ToString() ?? "N/A";
                NavBar.ManejarIdProyecto(idProyecto); // Envia el id del proyecto al NavBar
                // Verificar si hay actividades para el proyecto seleccionado
                bool hayActividades = ExisteActividad(idProyecto);

                string hayProveedor = DGV_Tabla_Proyect.SelectedRows[0].Cells["Nombre_Proveedor"].Value?.ToString();
                if (hayProveedor == "Sin Asignar")
                {
                    // Preguntar si se desea agregar una nueva actividad
                    DialogResult result = MessageBox.Show($"No se asignó un proveedor para el proyecto {idProyecto}. Favor de asignar un proveedor.",
                                                          "Proveedor no asignado",
                                                          MessageBoxButtons.OK);
                    return;
                                                        
                }

                if (hayActividades)
                {
                    // Abrir el formulario de actividades pasando el ID del proyecto
                    NavBar.AbrirFormularioEnPanel(new V_Activity(NavBar, idProyecto), "Actividades");
                }
                else
                {
                    // Preguntar si se desea agregar una nueva actividad
                    DialogResult result = MessageBox.Show($"No se encontraron actividades para el proyecto {idProyecto}. ¿Deseas agregar una nueva actividad?",
                                                          "Actividades no encontradas",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Abrir el formulario para agregar una nueva actividad
                        V_CRUD_Add_Act addActivityForm = new V_CRUD_Add_Act(idProyecto);
                        addActivityForm.ShowDialog();
                        UpdateEstadoProyecto(idProyecto);
                        CargarAllProyectos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para ver sus actividades.");
            }
        }

        private void UpdateEstadoProyecto(string idProyecto)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"UPDATE Proyect 
                     SET Id_SttProAct = @Estado
                     WHERE Id_Proyecto = @IdProyecto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar los parámetros
                    command.Parameters.AddWithValue("@IdProyecto", idProyecto);
                    command.Parameters.AddWithValue("@Estado", 2);

                    // Abrir conexión y ejecutar consulta
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool ExisteActividad(string idProyecto)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT 1 FROM Actividad WHERE Id_Proyecto = @IdProyecto AND activo = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdProyecto", idProyecto);
                    connection.Open();

                    // Si la consulta devuelve algún resultado, significa que existen actividades
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        private void DGV_Tabla_Proyect_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Tabla_Proyect.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Tabla_Proyect.SelectedRows[0];
                string idProyecto = selectedRow.Cells["Id_Proyecto"].Value?.ToString() ?? "N/A";
                string nombreProyecto = selectedRow.Cells["Nombre_Proyecto"].Value?.ToString() ?? "N/A";
                string cliente = selectedRow.Cells["Nombre_Cliente"].Value?.ToString() ?? "N/A";
                string estadoProyecto = selectedRow.Cells["Estado_Proyecto"].Value?.ToString() ?? "N/A";
                string empleado = selectedRow.Cells["Nombre_Empleado"].Value?.ToString() ?? "N/A";
                string proveedor = selectedRow.Cells["Nombre_Proveedor"].Value?.ToString() ?? "N/A";

                V_CRUD_Upd_Proyect updProyect = new V_CRUD_Upd_Proyect(idProyecto, nombreProyecto, cliente, estadoProyecto, empleado, proveedor, 1, NavBar);
                updProyect.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para actualizar.");
            }
        }

        private void BFiltrarFecha_Click(object sender, EventArgs e)
        {
            // Obtén las fechas seleccionadas en los DateTimePickers
           

            // Valida que las fechas sean correctas
            if (FiltroFecha1.Value > FiltroFecha2.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.", "Error en las fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llama al método para cargar los datos con el rango de fechas
            //CargarProyectosPorFechas(fechaInicio, fechaFin);
            CargarDatosProyectos("", fechaInicio: FiltroFecha1.Value, fechaFin: FiltroFecha2.Value);

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
    WHERE P.LifeOrDie = 1 
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
                    DGV_Tabla_Proyect.DataSource = proyectosDataTable;
                }
            }
        }

    }
}
