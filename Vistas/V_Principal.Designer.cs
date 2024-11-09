namespace Vistas {
    partial class V_Principal {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pnl_Principal = new Panel();
            SuspendLayout();
            // 
            // Pnl_Principal
            // 
            Pnl_Principal.Dock = DockStyle.Fill;
            Pnl_Principal.Location = new Point(0, 0);
            Pnl_Principal.Margin = new Padding(3, 4, 3, 4);
            Pnl_Principal.Name = "Pnl_Principal";
            Pnl_Principal.Size = new Size(914, 600);
            Pnl_Principal.TabIndex = 0;
            // 
            // V_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Principal);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "V_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultoria de Construccion";
            WindowState = FormWindowState.Maximized;
            Load += V_Principal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Principal;
    }
}
