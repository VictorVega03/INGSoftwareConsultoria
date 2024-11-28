namespace Vistas
{
    partial class V_EmpProvRemoved
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
            BactivarEmpProv = new Button();
            Pnl_Table_Emp_Prov = new Panel();
            TablaEmpProvRemoved = new DataGridView();
            Pnl_Buttons.SuspendLayout();
            Pnl_Table_Emp_Prov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaEmpProvRemoved).BeginInit();
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
            Pnl_Buttons.Controls.Add(BactivarEmpProv);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 7;
            // 
            // BactivarEmpProv
            // 
            BactivarEmpProv.BackColor = Color.Green;
            BactivarEmpProv.Cursor = Cursors.Hand;
            BactivarEmpProv.Dock = DockStyle.Top;
            BactivarEmpProv.Font = new Font("Segoe UI", 11F);
            BactivarEmpProv.ForeColor = Color.White;
            BactivarEmpProv.Location = new Point(0, 33);
            BactivarEmpProv.Margin = new Padding(3, 4, 3, 4);
            BactivarEmpProv.Name = "BactivarEmpProv";
            BactivarEmpProv.Size = new Size(234, 60);
            BactivarEmpProv.TabIndex = 0;
            BactivarEmpProv.Text = "Reactivar Empleado";
            BactivarEmpProv.UseVisualStyleBackColor = false;
            BactivarEmpProv.Click += BactivarEmpProv_Click;
            // 
            // Pnl_Table_Emp_Prov
            // 
            Pnl_Table_Emp_Prov.AutoSize = true;
            Pnl_Table_Emp_Prov.BackColor = Color.White;
            Pnl_Table_Emp_Prov.Controls.Add(TablaEmpProvRemoved);
            Pnl_Table_Emp_Prov.Dock = DockStyle.Fill;
            Pnl_Table_Emp_Prov.Location = new Point(0, 80);
            Pnl_Table_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Emp_Prov.Name = "Pnl_Table_Emp_Prov";
            Pnl_Table_Emp_Prov.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Emp_Prov.Size = new Size(657, 520);
            Pnl_Table_Emp_Prov.TabIndex = 8;
            // 
            // TablaEmpProvRemoved
            // 
            TablaEmpProvRemoved.AllowUserToAddRows = false;
            TablaEmpProvRemoved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaEmpProvRemoved.Dock = DockStyle.Fill;
            TablaEmpProvRemoved.Location = new Point(51, 33);
            TablaEmpProvRemoved.Margin = new Padding(3, 4, 3, 4);
            TablaEmpProvRemoved.Name = "TablaEmpProvRemoved";
            TablaEmpProvRemoved.ReadOnly = true;
            TablaEmpProvRemoved.RowHeadersVisible = false;
            TablaEmpProvRemoved.RowHeadersWidth = 51;
            TablaEmpProvRemoved.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaEmpProvRemoved.Size = new Size(572, 427);
            TablaEmpProvRemoved.TabIndex = 4;
            // 
            // V_EmpProvRemoved
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Table_Emp_Prov);
            Controls.Add(Pnl_Buttons);
            Controls.Add(Pnl_Filtro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_EmpProvRemoved";
            Text = "V_EmpProvRemoved";
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Table_Emp_Prov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaEmpProvRemoved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Filtro;
        private Panel Pnl_Buttons;
        private Button BEmpProvRemoved;
        private Button Btn_Eliminar_Emp_Prov;
        private Panel Pnl_Space2;
        private Button Btn_Upd_Emp_Prov;
        private Panel Pnl_Space1;
        private Button BactivarEmpProv;
        private Panel Pnl_Table_Emp_Prov;
        private DataGridView TablaEmpProvRemoved;
    }
}