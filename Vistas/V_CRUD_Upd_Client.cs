using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_CRUD_Upd_Client : Form
    {
        public int IdCliente { get; private set; }
        public string NombreCliente { get; private set; }
        public string RfcCliente { get; private set; }
        public string EmailCliente { get; private set; }
        public string TelefonoCliente { get; private set; }

        public V_CRUD_Upd_Client(string idCliente, string nombreCliente, string rfcCliente, string emailCliente, string telefonoCliente)
        {
            InitializeComponent();
            Txt_ID_Client.Text = idCliente.ToString();
            Txt_Nom_Cliente.Text = nombreCliente;
            Txt_RFC_Cliente.Text = rfcCliente;
            Txt_Email_Cliente.Text = emailCliente;
            Txt_Phone_Cliente.Text = telefonoCliente;
        }

        private void Btn_Aceptar_Cliente2_Click(object sender, EventArgs e)
        {
            NombreCliente = Txt_Nom_Cliente.Text;
            RfcCliente = Txt_RFC_Cliente.Text;
            EmailCliente = Txt_Email_Cliente.Text;
            TelefonoCliente = Txt_Phone_Cliente.Text;

            MessageBox.Show("Se ha editado el cliente");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Cancelar_Cliente2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pnl_Upd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
