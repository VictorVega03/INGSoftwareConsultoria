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
    public partial class V_Clientes : Form
    {
        public V_Clientes()
        {
            InitializeComponent();
        }

        private void Btn_Add_Client_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Client add_Client = new V_CRUD_Add_Client();
            add_Client.ShowDialog();
        }

        private void Btn_Upd_Client_Click(object sender, EventArgs e)
        {
            V_CRUD_Upd_Client Upd_Client = new V_CRUD_Upd_Client();
            Upd_Client.ShowDialog();
        }

        private void Btn_Eliminar_Client_Click(object sender, EventArgs e)
        {

        }
    }
}
