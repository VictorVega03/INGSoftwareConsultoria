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
    public partial class V_Proyect : Form
    {
        private V_NavBar NavBar;

        public V_Proyect(V_NavBar MainNavBar)
        {
            InitializeComponent();
            this.NavBar = MainNavBar;
        }

        /*
        private void DGV_Table_Proyect_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                int Id_Client = Convert.ToInt32(DGV_Table_Proyect.Rows[e.RowIndex].Cells[""].Value);
                MostrarDetallesRegistros(Id_Client);
            }
        }
        
        private void CargarDatos(int Id_Client) {
            var DatosRegistro = 
        }

        private void MostrarDetallesRegistros(int Id_Client) {
            V_Info_Proyect Info_Proyect = new V_Info_Proyect();
            Info_Proyect.CargarDatos(Id_Client);
            Info_Proyect.ShowDialog();
        }
        */

        private void Btn_Add_Proyect_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Proyect Add_Proyect = new V_CRUD_Add_Proyect();
            Add_Proyect.ShowDialog();
        }

        private void Btn_Upd_Proyect_Click(object sender, EventArgs e)
        {
            V_CRUD_Upd_Proyect Upd_Proyect = new V_CRUD_Upd_Proyect();
            Upd_Proyect.ShowDialog();
        }

        private void Btn_FPC_Proyect_Click(object sender, EventArgs e)
        {
            V_CRUD_FPC_Proyect FPC_Proyect = new V_CRUD_FPC_Proyect();
            FPC_Proyect.ShowDialog();
        }

        private void Btn_Hist_Proyect_Click(object sender, EventArgs e)
        {
            NavBar.AbrirFormularioEnPanel(new V_Hist_Proyect(), "Historial de Proyectos");
        }

        private void Btn_Act_Click(object sender, EventArgs e)
        {
            NavBar.AbrirFormularioEnPanel(new V_Activity(NavBar), "Actividades");
        }
    }
}
