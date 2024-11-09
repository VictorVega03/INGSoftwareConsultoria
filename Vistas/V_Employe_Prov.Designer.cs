namespace Vistas
{
    partial class V_Employe_Prov
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
            Pnl_Emp_Prov = new Panel();
            Pnl_Table_Emp_Prov = new Panel();
            DGV_Table_Emp_Prov = new DataGridView();
            Pnl_Buttons = new Panel();
            Btn_Eliminar_Emp_Prov = new Button();
            Pnl_Space2 = new Panel();
            Btn_Upd_Emp_Prov = new Button();
            Pnl_Space1 = new Panel();
            Btn_Add_Emp_Prov = new Button();
            Pnl_Filtro = new Panel();
            CmB_Filtro_Emp_Prov = new ComboBox();
            Lbl_Filtro_Emp_Prov = new Label();
            Pnl_Emp_Prov.SuspendLayout();
            Pnl_Table_Emp_Prov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Emp_Prov).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtro.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Emp_Prov
            // 
            Pnl_Emp_Prov.AutoSize = true;
            Pnl_Emp_Prov.Controls.Add(Pnl_Table_Emp_Prov);
            Pnl_Emp_Prov.Controls.Add(Pnl_Buttons);
            Pnl_Emp_Prov.Controls.Add(Pnl_Filtro);
            Pnl_Emp_Prov.Dock = DockStyle.Fill;
            Pnl_Emp_Prov.Location = new Point(0, 0);
            Pnl_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Pnl_Emp_Prov.Name = "Pnl_Emp_Prov";
            Pnl_Emp_Prov.Size = new Size(914, 600);
            Pnl_Emp_Prov.TabIndex = 1;
            // 
            // Pnl_Table_Emp_Prov
            // 
            Pnl_Table_Emp_Prov.AutoSize = true;
            Pnl_Table_Emp_Prov.Controls.Add(DGV_Table_Emp_Prov);
            Pnl_Table_Emp_Prov.Dock = DockStyle.Fill;
            Pnl_Table_Emp_Prov.Location = new Point(0, 80);
            Pnl_Table_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Emp_Prov.Name = "Pnl_Table_Emp_Prov";
            Pnl_Table_Emp_Prov.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Emp_Prov.Size = new Size(657, 520);
            Pnl_Table_Emp_Prov.TabIndex = 7;
            // 
            // DGV_Table_Emp_Prov
            // 
            DGV_Table_Emp_Prov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Table_Emp_Prov.Dock = DockStyle.Fill;
            DGV_Table_Emp_Prov.Location = new Point(51, 33);
            DGV_Table_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            DGV_Table_Emp_Prov.Name = "DGV_Table_Emp_Prov";
            DGV_Table_Emp_Prov.RowHeadersWidth = 51;
            DGV_Table_Emp_Prov.Size = new Size(572, 427);
            DGV_Table_Emp_Prov.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(Btn_Eliminar_Emp_Prov);
            Pnl_Buttons.Controls.Add(Pnl_Space2);
            Pnl_Buttons.Controls.Add(Btn_Upd_Emp_Prov);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(Btn_Add_Emp_Prov);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 6;
            // 
            // Btn_Eliminar_Emp_Prov
            // 
            Btn_Eliminar_Emp_Prov.Dock = DockStyle.Top;
            Btn_Eliminar_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Btn_Eliminar_Emp_Prov.Location = new Point(0, 207);
            Btn_Eliminar_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Emp_Prov.Name = "Btn_Eliminar_Emp_Prov";
            Btn_Eliminar_Emp_Prov.Size = new Size(234, 60);
            Btn_Eliminar_Emp_Prov.TabIndex = 9;
            Btn_Eliminar_Emp_Prov.Text = "Eliminar Empleado";
            Btn_Eliminar_Emp_Prov.UseVisualStyleBackColor = true;
            Btn_Eliminar_Emp_Prov.Click += Btn_Eliminar_Emp_Prov_Click;
            // 
            // Pnl_Space2
            // 
            Pnl_Space2.Dock = DockStyle.Top;
            Pnl_Space2.Location = new Point(0, 180);
            Pnl_Space2.Margin = new Padding(3, 4, 3, 4);
            Pnl_Space2.Name = "Pnl_Space2";
            Pnl_Space2.Size = new Size(234, 27);
            Pnl_Space2.TabIndex = 8;
            // 
            // Btn_Upd_Emp_Prov
            // 
            Btn_Upd_Emp_Prov.Dock = DockStyle.Top;
            Btn_Upd_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Btn_Upd_Emp_Prov.Location = new Point(0, 120);
            Btn_Upd_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Btn_Upd_Emp_Prov.Name = "Btn_Upd_Emp_Prov";
            Btn_Upd_Emp_Prov.Size = new Size(234, 60);
            Btn_Upd_Emp_Prov.TabIndex = 7;
            Btn_Upd_Emp_Prov.Text = "Modificar Empleado";
            Btn_Upd_Emp_Prov.UseVisualStyleBackColor = true;
            Btn_Upd_Emp_Prov.Click += Btn_Upd_Emp_Prov_Click;
            // 
            // Pnl_Space1
            // 
            Pnl_Space1.Dock = DockStyle.Top;
            Pnl_Space1.Location = new Point(0, 93);
            Pnl_Space1.Margin = new Padding(3, 4, 3, 4);
            Pnl_Space1.Name = "Pnl_Space1";
            Pnl_Space1.Size = new Size(234, 27);
            Pnl_Space1.TabIndex = 6;
            // 
            // Btn_Add_Emp_Prov
            // 
            Btn_Add_Emp_Prov.Dock = DockStyle.Top;
            Btn_Add_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Btn_Add_Emp_Prov.Location = new Point(0, 33);
            Btn_Add_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Btn_Add_Emp_Prov.Name = "Btn_Add_Emp_Prov";
            Btn_Add_Emp_Prov.Size = new Size(234, 60);
            Btn_Add_Emp_Prov.TabIndex = 0;
            Btn_Add_Emp_Prov.Text = "Añadir Nuevo Empleado";
            Btn_Add_Emp_Prov.UseVisualStyleBackColor = true;
            Btn_Add_Emp_Prov.Click += Btn_Add_Emp_Prov_Click;
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.Controls.Add(CmB_Filtro_Emp_Prov);
            Pnl_Filtro.Controls.Add(Lbl_Filtro_Emp_Prov);
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(914, 80);
            Pnl_Filtro.TabIndex = 3;
            // 
            // CmB_Filtro_Emp_Prov
            // 
            CmB_Filtro_Emp_Prov.Font = new Font("Segoe UI", 11F);
            CmB_Filtro_Emp_Prov.FormattingEnabled = true;
            CmB_Filtro_Emp_Prov.Location = new Point(154, 20);
            CmB_Filtro_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            CmB_Filtro_Emp_Prov.Name = "CmB_Filtro_Emp_Prov";
            CmB_Filtro_Emp_Prov.Size = new Size(199, 33);
            CmB_Filtro_Emp_Prov.TabIndex = 3;
            // 
            // Lbl_Filtro_Emp_Prov
            // 
            Lbl_Filtro_Emp_Prov.AutoSize = true;
            Lbl_Filtro_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro_Emp_Prov.Location = new Point(51, 27);
            Lbl_Filtro_Emp_Prov.Name = "Lbl_Filtro_Emp_Prov";
            Lbl_Filtro_Emp_Prov.Size = new Size(99, 25);
            Lbl_Filtro_Emp_Prov.TabIndex = 2;
            Lbl_Filtro_Emp_Prov.Text = "Filtrar por:";
            // 
            // V_Employe_Prov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Emp_Prov);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Employe_Prov";
            Text = "V_Employe_Prov";
            Pnl_Emp_Prov.ResumeLayout(false);
            Pnl_Emp_Prov.PerformLayout();
            Pnl_Table_Emp_Prov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Emp_Prov).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Filtro.ResumeLayout(false);
            Pnl_Filtro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Emp_Prov;
        private Panel Pnl_Filtro;
        private ComboBox CmB_Filtro_Emp_Prov;
        private Label Lbl_Filtro_Emp_Prov;
        private Panel Pnl_Table_Emp_Prov;
        private DataGridView DGV_Table_Emp_Prov;
        private Panel Pnl_Buttons;
        private Button Btn_Add_Emp_Prov;
        private Button Btn_Upd_Emp_Prov;
        private Panel Pnl_Space1;
        private Button Btn_Eliminar_Emp_Prov;
        private Panel Pnl_Space2;
    }
}