namespace Vistas
{
    partial class V_ProvRemoved
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pnl_Filtro = new Panel();
            Pnl_Buttons = new Panel();
            BActivarProv = new Button();
            Pnl_Table_Prov = new Panel();
            TablaProvRemoved = new DataGridView();
            Pnl_Buttons.SuspendLayout();
            Pnl_Table_Prov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaProvRemoved).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.BackColor = Color.White;
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(914, 80);
            Pnl_Filtro.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(BActivarProv);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 8;
            // 
            // BActivarProv
            // 
            BActivarProv.BackColor = Color.Green;
            BActivarProv.Cursor = Cursors.Hand;
            BActivarProv.Dock = DockStyle.Top;
            BActivarProv.Font = new Font("Segoe UI", 11F);
            BActivarProv.ForeColor = Color.White;
            BActivarProv.Location = new Point(0, 33);
            BActivarProv.Margin = new Padding(3, 4, 3, 4);
            BActivarProv.Name = "BActivarProv";
            BActivarProv.Size = new Size(234, 60);
            BActivarProv.TabIndex = 0;
            BActivarProv.Text = "Reactivar Proveedor";
            BActivarProv.UseVisualStyleBackColor = false;
            BActivarProv.Click += BActivarProv_Click;
            // 
            // Pnl_Table_Prov
            // 
            Pnl_Table_Prov.AutoSize = true;
            Pnl_Table_Prov.BackColor = Color.White;
            Pnl_Table_Prov.Controls.Add(TablaProvRemoved);
            Pnl_Table_Prov.Dock = DockStyle.Fill;
            Pnl_Table_Prov.Location = new Point(0, 80);
            Pnl_Table_Prov.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Prov.Name = "Pnl_Table_Prov";
            Pnl_Table_Prov.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Prov.Size = new Size(657, 520);
            Pnl_Table_Prov.TabIndex = 9;
            // 
            // TablaProvRemoved
            // 
            TablaProvRemoved.AllowUserToAddRows = false;
            TablaProvRemoved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaProvRemoved.Dock = DockStyle.Fill;
            TablaProvRemoved.Location = new Point(51, 33);
            TablaProvRemoved.Margin = new Padding(3, 4, 3, 4);
            TablaProvRemoved.Name = "TablaProvRemoved";
            TablaProvRemoved.RowHeadersVisible = false;
            TablaProvRemoved.RowHeadersWidth = 51;
            TablaProvRemoved.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaProvRemoved.Size = new Size(572, 427);
            TablaProvRemoved.TabIndex = 4;
            // 
            // V_ProvRemoved
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Table_Prov);
            Controls.Add(Pnl_Buttons);
            Controls.Add(Pnl_Filtro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_ProvRemoved";
            Text = "V_ProvRemoved";
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Table_Prov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaProvRemoved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Filtro;
        private Panel Pnl_Buttons;
        private Button BProvRemoved;
        private Button Btn_Eliminar_Prov;
        private Panel panel1;
        private Button Btn_Upd_Prov;
        private Panel Pnl_Space1;
        private Button Btn_Emp_Prov;
        private Button BActivarProv;
        private Panel Pnl_Table_Prov;
        private DataGridView TablaProvRemoved;
    }
}