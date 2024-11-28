using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_NavBar : Form
    {
        private string idProyectoActual;
        private Dictionary<Type, Action<string>> filtros; // Diccionario para asociar filtros con formularios
        private Dictionary<Type, Action<string, string>> filtrosconID; // Cambia a Action<string, string>
        private System.Windows.Forms.Timer filtroTimer; // Temporizador para manejar el filtro
        private Form formularioActual; // Referencia al formulario actual mostrado en el panel
        private Dictionary<Type, Action<string, DateTime?, DateTime?>> filtrosConFechas; // Diccionario para filtros con texto y fechas

        public V_NavBar()
        {
            InitializeComponent();
            Lbl_NameUser.Text = "Usuario:  " + dataLogin.userName;
            userType(dataLogin.userPermits);
            MnS_NavBar.RenderMode = ToolStripRenderMode.System;
            filtroTimer = new System.Windows.Forms.Timer(); // Inicializa el temporizador
            filtroTimer.Interval = 500; // Tiempo de espera en milisegundos
            filtroTimer.Tick += FiltroTimer_Tick;
            InicializarFiltros();
        }
        private void userType(int userPermits)
        {
             if (userPermits == 2) // promotor
            {
                TSMI_Prov.Enabled = false;
                empleadosProvToolStripMenuItem.Enabled = false;
                TSMI_Emp.Enabled = false;               
            }
            else if (userPermits == 3) // proveedor
            {                
                TSMI_Emp.Enabled = false;
                TSMI_Prov.Enabled = false;
                clientesToolStripMenuItem.Enabled = false;
            }
            else if (userPermits == 4) // empleado general
            {                
                TSMI_Prov.Enabled = false;
                TSMI_Emp.Enabled = false;
                empleadosProvToolStripMenuItem.Enabled = false;
            }
            else if (userPermits == 5) // empleado proveedor
            {
                TSMI_Prov.Enabled = false;
                TSMI_Emp.Enabled = false;
                clientesToolStripMenuItem.Enabled = false;
                empleadosProvToolStripMenuItem.Enabled = false;
            }
        }
        private void InicializarFiltros()
        {
            filtrosConFechas = new Dictionary<Type, Action<string, DateTime?, DateTime?>>
    {
        { typeof(V_Proyect), FiltroProyectosConFechas },
        { typeof(V_Hist_Proyect), FiltroHistorialProyectosConFechas }
    };

            filtrosconID = new Dictionary<Type, Action<string, string>>
    {
        { typeof(V_Activity), FiltroActividades },
        { typeof(V_Hist_Act), FiltroHistorialActividades }
    };

            filtros = new Dictionary<Type, Action<string>>
    {
        { typeof(V_Proyect), (filtro) => ((V_Proyect)formularioActual).CargarDatosProyectos(filtro) },
        { typeof(V_Hist_Proyect),(filtro) => ((V_Hist_Proyect)formularioActual).CargarHistorialProyectos(filtro) },
        { typeof(V_Proveedores), FiltroProveedores },
        { typeof(V_ProvRemoved), FiltroProveedoresRemoved },
        { typeof(V_Employe_Prov), FiltroEmpleadosProveedores },
        { typeof(V_EmpProvRemoved), FiltroEmpleadosProvRemoved },
        { typeof(V_Employee), FiltroEmpleados },
        { typeof(V_EmployeeRemoved), FiltroEmpleadosRemoved },
        { typeof(V_Clientes), FiltroClientes },
        { typeof(V_ClientesRemoved), FiltroClientesRemoved },
        { typeof(V_Notes), FiltroNotas } // Añade el filtro de notas
    };
        }
        private void FiltroProyectosConFechas(string filtro, DateTime? fechaInicio, DateTime? fechaFin)
        {
            if (formularioActual is V_Proyect vista)
            {
                vista.CargarDatosProyectos(filtro, fechaInicio, fechaFin); // Método que acepta filtro y rango de fechas
            }
        }

        private void FiltroHistorialProyectosConFechas(string filtro, DateTime? fechaInicio, DateTime? fechaFin)
        {
            if (formularioActual is V_Hist_Proyect vista)
            {
                vista.CargarHistorialProyectos(filtro, fechaInicio, fechaFin); // Similar al anterior
            }
        }

        public void ManejarIdProyecto(string idProyecto)
        {
            // metodo para recibir el id del proyecto desde el formulario de proyectos
            idProyectoActual = idProyecto;
        }

        private void FiltroActividades(string idProyecto, string filtro)
        {
            if (formularioActual is V_Activity vista)
            {
                vista.CargarDatosActividad(idProyecto, filtro);
            }
        }
        private void FiltroHistorialActividades(string idProyecto, string filtro)
        {
            if (formularioActual is V_Hist_Act vista)
            {
                vista.CargarHistActividades(idProyecto, filtro);
            }
        }
        private void FiltroNotas(string filtro)
        {
            if (formularioActual is V_Notes vista)
            {
                vista.CargarNotasActividad(filtro); // Llama al método de filtrado en la clase V_Notes
            }
        }

        private void FiltroTimer_Tick(object sender, EventArgs e)
        {
            filtroTimer.Stop(); // Detén el temporizador

            if (formularioActual != null)
            {
                // Obtiene el tipo del formulario actual
                Type tipoFormulario = formularioActual.GetType();

                // Detecta si el formulario admite filtros con fechas
                if (filtrosConFechas != null && filtrosConFechas.TryGetValue(tipoFormulario, out Action<string, DateTime?, DateTime?> filtroConFechas))
                {
                    // Obtén los valores de los DateTimePicker si están definidos, o usa null si no existen
                    DateTime? fechaInicio = null;
                    DateTime? fechaFin = null;

                    // Aplica el filtro combinado
                    filtroConFechas.Invoke(TxtBuscador.Text, fechaInicio, fechaFin);
                }
                else if (filtros.TryGetValue(tipoFormulario, out Action<string> filtro))
                {
                    // Aplica el filtro de texto
                    filtro.Invoke(TxtBuscador.Text);
                }
                else if (filtrosconID.TryGetValue(tipoFormulario, out Action<string, string> filtroconID))
                {
                    if (!string.IsNullOrEmpty(idProyectoActual))
                    {
                        // Aplica el filtro con el texto del buscador y el ID del proyecto
                        filtroconID.Invoke(idProyectoActual, TxtBuscador.Text);
                    }
                    else
                    {
                        MessageBox.Show("El ID del proyecto no está disponible.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay un filtro definido para esta vista.");
                }
            }
        }


        private void FiltroProyectos(string filtro)
        {
            if (formularioActual is V_Proyect vista)
            {
                vista.CargarDatosProyectos(filtro); // Llama al método de la vista de proyectos
            }
        }
        private void FiltroHistorialProyectos(string filtro)
        {
            if (formularioActual is V_Hist_Proyect vista)
            {
                vista.CargarHistorialProyectos(filtro); // Llama al método de la vista de historial
            }
        }

        private void FiltroProveedores(string filtro)
        {
            if (formularioActual is V_Proveedores vista)
            {
                vista.CargarDatosProveedores(filtro);
            }
        }
        private void FiltroProveedoresRemoved(string filtro)
        {
            if (formularioActual is V_ProvRemoved vista)
            {
                vista.CargarProveedoresEliminados(filtro);
            }
        }

        private void FiltroEmpleadosProveedores(string filtro)
        {
            if (formularioActual is V_Employe_Prov vista)
            {
                vista.CargarDatosEmpleadosProveedor(filtro);
            }
        }
        private void FiltroEmpleadosProvRemoved(string filtro)
        {
            if (formularioActual is V_EmpProvRemoved vista)
            {
                vista.CargarEmpleadosProvEliminados(filtro);
            }
        }

        private void FiltroEmpleados(string filtro)
        {
            if (formularioActual is V_Employee vista)
            {
                vista.CargarDatosEmpleados(filtro);
            }
        }
        private void FiltroEmpleadosRemoved(string filtro)
        {
            if (formularioActual is V_EmployeeRemoved vista)
            {
                vista.CargarEmpleadosEliminados(filtro);
            }
        }

        private void FiltroClientes(string filtro)
        {
            if (formularioActual is V_Clientes vista)
            {
                vista.CargarDatosClientes(filtro);
            }
        }
        private void FiltroClientesRemoved(string filtro)
        {
            if (formularioActual is V_ClientesRemoved vista)
            {
                vista.CargarClientesEliminados(filtro);
            }
        }

        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (filtroTimer.Enabled)
            {
                filtroTimer.Stop(); // Reinicia el temporizador si ya está corriendo
            }

            filtroTimer.Start(); // Inicia el temporizador para aplicar el filtro después de la pausa
        }
        private void V_NavBar_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Proyect(this), "Proyectos");
        }

        public void AbrirFormularioEnPanel(object FormularioHijo, string Titulo)
        {
            if (this.Pnl_Content.Controls.Count > 0)
            {
                this.Pnl_Content.Controls.RemoveAt(0);
            }

            Form fh = FormularioHijo as Form;

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            this.Pnl_Content.Controls.Add(fh);
            this.Pnl_Content.Tag = fh;
            formularioActual = fh; // Guarda referencia al formulario actual

            TSMI_Ventanas.Text = Titulo;

            fh.Show();
        }

        private void TSMI_Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Proyect(this), "Proyectos");
        }
        private void TSMI_Proyect_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Proyect(this), "Proyectos");
        }
        private void TSMI_Hist_Proyect_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Hist_Proyect(this), "Historial de Proyectos");
        }
        private void TSMI_Prov_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Proveedores(this), "Proveedores");
        }
        private void TSMI_Emp_Prov_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Employe_Prov(this), "Empleados del Prov");
        }
        private void TSMI_Emp_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Employee(this), "Empleados");
        }
        private void TSMI_Client_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Clientes(this), "Clientes");
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            // Confirmación del usuario
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Cierra todas las ventanas abiertas y regresa a la ventana de Login
                this.Hide(); // Oculta la ventana actual
                dataLogin.userName = null;
                dataLogin.userPermits = -1;
                // Abre la ventana de Login
                V_Login loginForm = new V_Login();
                loginForm.Show();

                // Cierra la ventana actual completamente
                this.Close();
            }
        }

    }
}
