using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas {
    public partial class V_NavBar : Form
    {
        public V_NavBar()
        {
            InitializeComponent();
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
            AbrirFormularioEnPanel(new V_Hist_Proyect(), "Historial de Proyectos");
        }

        private void TSMI_Activity_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Activity(this), "Actividades");
        }

        private void TSMI_Hist_Activity_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Hist_Act(), "Historial de Actividades");
        }

        private void TSMI_Prov_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Proveedores(this), "Proveedores");
        }

        private void TSMI_Emp_Prov_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Employe_Prov(), "Empleados del Prov");
        }

        private void TSMI_Emp_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Employee(), "Empleados");
        }

        private void TSMI_Client_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new V_Clientes(), "Clientes");
        }
    }
}
