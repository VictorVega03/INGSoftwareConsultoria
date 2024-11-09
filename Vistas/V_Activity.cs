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
    public partial class V_Activity : Form
    {
        private V_NavBar NavBar;

        public V_Activity(V_NavBar MainNavBar)
        {
            InitializeComponent();
            this.NavBar = MainNavBar;
        }

        private void Btn_Add_Act_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Act Add_Act = new V_CRUD_Add_Act();
            Add_Act.ShowDialog();
        }

        private void Btn_Upd_Act_Click(object sender, EventArgs e)
        {
            V_CRUD_Upd_Act Upd_Act = new V_CRUD_Upd_Act();
            Upd_Act.ShowDialog();
        }

        private void Btn_Eliminar_Act_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Hist_Act_Click(object sender, EventArgs e)
        {
            NavBar.AbrirFormularioEnPanel(new V_Hist_Act(), "Historial de Actividades");
        }
    }
}
