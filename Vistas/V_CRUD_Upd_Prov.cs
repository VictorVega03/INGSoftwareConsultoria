using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_CRUD_Upd_Prov : Form
    {
        public string NombreProveedor { get; private set; }
        public string RepresentanteProveedor { get; private set; }
        public string rfcProveedor { get; private set; }
        public string EmailProveedor { get; private set; }
        public string TelefonoProveedor { get; private set; }

        public V_CRUD_Upd_Prov(string idProveedor, string nombreProveedor, string representanteProveedor, string rfcProveedor, string emailProveedor, string telefonoProveedor)
        {
            InitializeComponent();
            Txt_ID_Prov.Text = idProveedor;
            Txt_Nom_Prov.Text = nombreProveedor;
            Txt_Repre_Prov.Text = representanteProveedor;
            txt_rfcProv.Text = rfcProveedor;
            Txt_Email_Prov.Text = emailProveedor;
            Txt_Phone_Prov.Text = telefonoProveedor;
        }

        private void Btn_Aceptar_Prov2_Click(object sender, EventArgs e)
        {
            NombreProveedor = Txt_Nom_Prov.Text;
            RepresentanteProveedor = Txt_Repre_Prov.Text;
            rfcProveedor = txt_rfcProv.Text;
            EmailProveedor = Txt_Email_Prov.Text;
            TelefonoProveedor = Txt_Phone_Prov.Text;

            UpdateProveedor();
            MessageBox.Show("Se ha editado el proveedor");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateProveedor()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"UPDATE Proveedores 
                             SET Nom_Prov = @Nombre,
                                 Rep_Prov = @Representante,
                                 RFC_Prov = @RFCproveedor,
                                 Email_Prov = @Correo,
                                 Phone_Prov = @Telefono
                             WHERE Id_Prov = @IdProveedor";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdProveedor", Txt_ID_Prov.Text);
                    command.Parameters.AddWithValue("@Nombre", Txt_Nom_Prov.Text);
                    command.Parameters.AddWithValue("@Representante", Txt_Repre_Prov.Text);
                    command.Parameters.AddWithValue("@RFCProveedor", txt_rfcProv.Text);
                    command.Parameters.AddWithValue("@Correo", Txt_Email_Prov.Text);
                    command.Parameters.AddWithValue("@Telefono", Txt_Phone_Prov.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Btn_Cancelar_Prov2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
