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
    public partial class V_Proveedores : Form
    {
        private V_NavBar NavBar;

        public V_Proveedores(V_NavBar MainNavBar)
        {
            InitializeComponent();
            this.NavBar = MainNavBar;
        }

        private void Btn_Add_Prov_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Prov Add_Prov = new V_CRUD_Add_Prov();
            Add_Prov.ShowDialog();
        }

        private void Btn_Upd_Prov_Click(object sender, EventArgs e)
        {
            V_CRUD_Upd_Prov Upd_Prov = new V_CRUD_Upd_Prov();
            Upd_Prov.ShowDialog();
        }

        private void Btn_Eliminar_Prov_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Emp_Prov_Click(object sender, EventArgs e)
        {
            NavBar.AbrirFormularioEnPanel(new V_Employe_Prov(), "Empleados del Prov");
        }
    }
}
