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
    public partial class V_Employee : Form
    {
        public V_Employee()
        {
            InitializeComponent();
        }

        private void Btn_Add_Emp_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Emp Add_Emp = new V_CRUD_Add_Emp();
            Add_Emp.ShowDialog();
        }

        private void Btn_Upd_Emp_Click(object sender, EventArgs e)
        {
            V_CRUD_Upd_Emp Upd_Emp = new V_CRUD_Upd_Emp();
            Upd_Emp.ShowDialog();
        }

        private void Btn_Eliminar_Emp_Click(object sender, EventArgs e)
        {

        }
    }
}
