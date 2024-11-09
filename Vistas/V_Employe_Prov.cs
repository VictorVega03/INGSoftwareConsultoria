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
    public partial class V_Employe_Prov : Form
    {
        public V_Employe_Prov()
        {
            InitializeComponent();
        }

        private void Btn_Add_Emp_Prov_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Emp_Prov Add_Emp_Prov = new V_CRUD_Add_Emp_Prov();
            Add_Emp_Prov.ShowDialog();
        }

        private void Btn_Upd_Emp_Prov_Click(object sender, EventArgs e)
        {
            V_CRUD_Upd_Emp_Prov Upd_Emp_Prov = new V_CRUD_Upd_Emp_Prov();
            Upd_Emp_Prov.ShowDialog();
        }

        private void Btn_Eliminar_Emp_Prov_Click(object sender, EventArgs e)
        {

        }
    }
}
