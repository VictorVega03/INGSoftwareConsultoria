namespace Vistas {
    public partial class V_Principal : Form {
        public V_Principal() {
            InitializeComponent();
        }

        private void V_Principal_Load(object sender, EventArgs e) {
            AbrirFormularioEnPanel(new V_NavBar());
        }

        private void AbrirFormularioEnPanel(object FormularioHijo) {
            if (this.Pnl_Principal.Controls.Count > 0) {
                this.Pnl_Principal.Controls.RemoveAt(0);
            }

            Form fh = FormularioHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            this.Pnl_Principal.Controls.Add(fh);
            this.Pnl_Principal.Tag = fh;
            fh.Show();
        }
    }
}
