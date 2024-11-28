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
    public partial class V_Activity : Form
    {
        private V_NavBar NavBar;
        private string idProyecto;
        private string idActividad;
        private int estadoTipo;
        public V_Activity(V_NavBar MainNavBar, string idProyecto)
        {
            InitializeComponent();
            userType(dataLogin.userPermits);
            this.NavBar = MainNavBar;
            this.idProyecto = idProyecto;
            CargarDatosActividad(idProyecto, "");
            ConfigurarTabla();
        }
        private void userType(int userPermits)
        {
            if (userPermits == 3) // proveedor
            {
                Btn_FPC_Act.Enabled = false;
                Btn_FPC_Act.BackColor = Color.Gray;
            }
            else if (userPermits == 4) // empleado general
            {
                BagregarAct.Enabled = false;
                BagregarAct.BackColor = Color.Gray;
                BmodifAct.Enabled = false;
                BmodifAct.BackColor = Color.Gray;
                Btn_FPC_Act.Enabled = false;
                Btn_FPC_Act.BackColor = Color.Gray;

            }
            else if (userPermits == 5) // empleado proveedor
            {
                BagregarAct.Enabled = false;
                BagregarAct.BackColor = Color.Gray;
                BmodifAct.Enabled = false;
                BmodifAct.BackColor = Color.Gray;
                Btn_FPC_Act.Enabled = false;
                Btn_FPC_Act.BackColor = Color.Gray;
            }
        }
        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            tablaActividad.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            tablaActividad.DefaultCellStyle.Font = new Font("Arial", 14);
            tablaActividad.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);

            // Centrar el texto
            tablaActividad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaActividad.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tablaActividad.Columns["ID Actividad"].HeaderText = "ID Actividad";
            tablaActividad.Columns["ID Proyecto"].HeaderText = "ID Proyecto";
            tablaActividad.Columns["Nombre Proyecto"].HeaderText = "Nombre Proyecto";
            tablaActividad.Columns["Nombre Actividad"].HeaderText = "Nombre Actividad";
            tablaActividad.Columns["Empleado Responsable"].HeaderText = "Empleado Responsable";
            tablaActividad.Columns["Empleado Proveedor"].HeaderText = "Empleado Proveedor";
            tablaActividad.Columns["Estado Actividad"].HeaderText = "Estado Actividad";
            //tablaActividad.Columns["Creado Por"].HeaderText = "Creado Por";
            tablaActividad.Columns["Fecha Inicio"].HeaderText = "Fecha Inicio";
            tablaActividad.Columns["Fecha Cierre"].HeaderText = "Fecha Cierre";

            // Habilitar scroll automático
            tablaActividad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaActividad.ScrollBars = ScrollBars.Both;

            tablaActividad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaActividad.RowHeadersVisible = false;
            tablaActividad.ReadOnly = true;
            tablaActividad.AllowUserToAddRows = false;

            // Configuración de colores
            tablaActividad.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            tablaActividad.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            tablaActividad.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            tablaActividad.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            tablaActividad.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            tablaActividad.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }
        
        public void CargarDatosActividad(string idProyecto, string filtro)
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
    A.Dia_Termino AS [Fecha Cierre]
FROM Actividad A
LEFT JOIN Proyect P ON A.Id_Proyecto = P.Id_Proyecto
LEFT JOIN Empleados E ON A.Id_Emp = E.Id_Emp
LEFT JOIN EmpleadosProveedor EP ON A.Id_Emp_Prov = EP.Id_Emp_Prov
LEFT JOIN StatusProAct SP ON A.Id_SttProAct = SP.Id_SttProAct
WHERE A.Id_Proyecto = @idProyecto
    AND (
        A.Id_Activity LIKE @Filtro OR
        A.Nombre_Activity LIKE @Filtro OR
        E.Nom_Emp LIKE @Filtro OR
        EP.Nom_Emp_Prov LIKE @Filtro OR
        SP.Name_SttProAct LIKE @Filtro OR
        CONVERT(VARCHAR, A.Dia_Inicio, 120) LIKE @Filtro OR
        P.Nombre LIKE @Filtro
    )
ORDER BY A.Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros para filtrar por idProyecto y filtro general
                    command.Parameters.AddWithValue("@idProyecto", idProyecto);
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable actividadDataTable = new DataTable();
                    dataAdapter.Fill(actividadDataTable);

                    // Asumiendo que tienes un DataGridView llamado tablaActividad
                    tablaActividad.DataSource = actividadDataTable;
                }
            }
        }
        private void Btn_Add_Act_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Act Add_Act = new V_CRUD_Add_Act(idProyecto);
            Add_Act.ShowDialog();
            CargarDatosActividad(idProyecto, "");
        }

        private void Btn_Upd_Act_Click(object sender, EventArgs e)
        {
            if (tablaActividad.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tablaActividad.SelectedRows[0];
                string idActividad = selectedRow.Cells["ID Actividad"].Value?.ToString() ?? "N/A";
                string idProyecto = selectedRow.Cells["ID Proyecto"].Value?.ToString() ?? "N/A";
                string nombreActividad = selectedRow.Cells["Nombre Actividad"].Value?.ToString() ?? "N/A";
                string empleado = selectedRow.Cells["Empleado Responsable"].Value?.ToString() ?? "N/A";
                string empleadoProveedor = selectedRow.Cells["Empleado Proveedor"].Value?.ToString() ?? "N/A";
                string estadoActividad = selectedRow.Cells["Estado Actividad"].Value?.ToString() ?? "N/A";
                string fechaInicio = selectedRow.Cells["Fecha Inicio"].Value?.ToString() ?? "N/A";

                // Validar si la actividad está marcada como "Finalizado"
                if (estadoActividad.Equals("Finalizado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("No se puede modificar una actividad marcada como finalizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método si la actividad no es modificable
                }

                // Llamar a la vista para actualizar actividades
                V_CRUD_Upd_Act updAct = new V_CRUD_Upd_Act(idActividad, idProyecto, nombreActividad, empleado, empleadoProveedor, estadoActividad, 0, NavBar);
                updAct.ShowDialog();

                // Recargar los datos de actividades después de la actualización
                CargarDatosActividad(idProyecto, "");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una actividad para actualizar.");
            }
        }

        private void Btn_Eliminar_Act_Click(object sender, EventArgs e)
        {
            if (tablaActividad.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tablaActividad.SelectedRows[0];
                var idCell = selectedRow.Cells["ID Actividad"];
                var nameCell = selectedRow.Cells["Nombre Actividad"];
                var estadoCell = selectedRow.Cells["Estado Actividad"];

                if (idCell?.Value != null && nameCell?.Value != null && estadoCell?.Value != null)
                {
                    string idAct = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();
                    string estadoActividad = estadoCell.Value.ToString();

                    // Validar si la actividad ya está marcada como finalizada
                    if (estadoActividad.Equals("Finalizado", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"La actividad '{nombre}' ya está marcada como finalizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método si la actividad ya está finalizada
                    }

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de finalizar la actividad '{nombre}' con el ID {idAct}?", "Finalizar Actividad", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        completarActividad(idAct);
                        MessageBox.Show("Actividad finalizada exitosamente.");
                        CargarDatosActividad(idProyecto, "");
                    }
                }
                else
                {
                    MessageBox.Show("El proveedor seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una actividad para eliminar.");
            }

            CargarDatosActividad(idProyecto, "");
        }

        private void completarActividad(string idActivity)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE Actividad SET activo = 0, Id_SttProAct = @Estado, Dia_Termino = @DiaTermino WHERE Id_Activity = @IdActivity";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdActivity", idActivity);
                command.Parameters.AddWithValue("@DiaTermino", DateTime.Now);
                command.Parameters.AddWithValue("@Estado", 3);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        private void Btn_Hist_Act_Click(object sender, EventArgs e)
        {
            NavBar.ManejarIdProyecto(idProyecto); // Envia el id del proyecto al NavBar
            NavBar.AbrirFormularioEnPanel(new V_Hist_Act(NavBar, idProyecto), "Historial de Actividades");
        }

        private void tablaActividad_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaActividad.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tablaActividad.SelectedRows[0];
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
                CargarDatosActividad(idProyecto, "");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una actividad para actualizar.");
            }
        }

        private void Bnotas_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (tablaActividad.SelectedRows.Count > 0)
            {
                // Obtener el ID de la actividad seleccionada
                DataGridViewRow selectedRow = tablaActividad.SelectedRows[0];
                idActividad = selectedRow.Cells["ID Actividad"].Value?.ToString();
                string estado = selectedRow.Cells["Estado Actividad"].Value?.ToString();
                if (estado == "Finalizado")
                {
                    estadoTipo = 1;
                }
                else
                {
                    estadoTipo = 0;
                }

                if (!string.IsNullOrEmpty(idActividad))
                {
                    // Abrir la ventana para añadir notas
                    NavBar.AbrirFormularioEnPanel(new V_Notes(idActividad, idProyecto, estadoTipo), "Notas de Actividad");                    
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una actividad válida para agregar notas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una actividad para agregar notas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
