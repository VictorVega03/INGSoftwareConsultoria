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
    public partial class V_CRUD_Add_Act : Form
    {
        public V_CRUD_Add_Act()
        {
            InitializeComponent();
        }

        private void Btn_Asignar_Act1_Click(object sender, EventArgs e)
        {
            V_CRUD_Asig_Act Asig_Act = new V_CRUD_Asig_Act();
            Asig_Act.ShowDialog();
        }

        private void Btn_Cancelar_Act1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
