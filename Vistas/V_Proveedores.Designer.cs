namespace Vistas
{
    partial class V_Proveedores
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
            Pnl_Prov = new Panel();
            Pnl_Table_Prov = new Panel();
            DGV_Table_Prov = new DataGridView();
            Pnl_Buttons = new Panel();
            Btn_Eliminar_Prov = new Button();
            panel1 = new Panel();
            Btn_Upd_Prov = new Button();
            Pnl_Space1 = new Panel();
            Btn_Emp_Prov = new Button();
            Btn_Add_Prov = new Button();
            Pnl_Filtro = new Panel();
            CmB_Filtro_Prov = new ComboBox();
            Lbl_Filtro_Prov = new Label();
            Pnl_Prov.SuspendLayout();
            Pnl_Table_Prov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Prov).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtro.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Prov
            // 
            Pnl_Prov.AutoSize = true;
            Pnl_Prov.Controls.Add(Pnl_Table_Prov);
            Pnl_Prov.Controls.Add(Pnl_Buttons);
            Pnl_Prov.Controls.Add(Pnl_Filtro);
            Pnl_Prov.Dock = DockStyle.Fill;
            Pnl_Prov.Location = new Point(0, 0);
            Pnl_Prov.Margin = new Padding(3, 4, 3, 4);
            Pnl_Prov.Name = "Pnl_Prov";
            Pnl_Prov.Size = new Size(914, 600);
            Pnl_Prov.TabIndex = 1;
            // 
            // Pnl_Table_Prov
            // 
            Pnl_Table_Prov.AutoSize = true;
            Pnl_Table_Prov.Controls.Add(DGV_Table_Prov);
            Pnl_Table_Prov.Dock = DockStyle.Fill;
            Pnl_Table_Prov.Location = new Point(0, 80);
            Pnl_Table_Prov.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Prov.Name = "Pnl_Table_Prov";
            Pnl_Table_Prov.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Prov.Size = new Size(657, 520);
            Pnl_Table_Prov.TabIndex = 8;
            // 
            // DGV_Table_Prov
            // 
            DGV_Table_Prov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Table_Prov.Dock = DockStyle.Fill;
            DGV_Table_Prov.Location = new Point(51, 33);
            DGV_Table_Prov.Margin = new Padding(3, 4, 3, 4);
            DGV_Table_Prov.Name = "DGV_Table_Prov";
            DGV_Table_Prov.RowHeadersVisible = false;
            DGV_Table_Prov.RowHeadersWidth = 51;
            DGV_Table_Prov.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Table_Prov.Size = new Size(572, 427);
            DGV_Table_Prov.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(Btn_Eliminar_Prov);
            Pnl_Buttons.Controls.Add(panel1);
            Pnl_Buttons.Controls.Add(Btn_Upd_Prov);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(Btn_Emp_Prov);
            Pnl_Buttons.Controls.Add(Btn_Add_Prov);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 7;
            // 
            // Btn_Eliminar_Prov
            // 
            Btn_Eliminar_Prov.Dock = DockStyle.Top;
            Btn_Eliminar_Prov.Font = new Font("Segoe UI", 11F);
            Btn_Eliminar_Prov.Location = new Point(0, 207);
            Btn_Eliminar_Prov.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Prov.Name = "Btn_Eliminar_Prov";
            Btn_Eliminar_Prov.Size = new Size(234, 60);
            Btn_Eliminar_Prov.TabIndex = 9;
            Btn_Eliminar_Prov.Text = "Eliminar Proveedor";
            Btn_Eliminar_Prov.UseVisualStyleBackColor = true;
            Btn_Eliminar_Prov.Click += Btn_Eliminar_Prov_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 180);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 27);
            panel1.TabIndex = 8;
            // 
            // Btn_Upd_Prov
            // 
            Btn_Upd_Prov.Dock = DockStyle.Top;
            Btn_Upd_Prov.Font = new Font("Segoe UI", 11F);
            Btn_Upd_Prov.Location = new Point(0, 120);
            Btn_Upd_Prov.Margin = new Padding(3, 4, 3, 4);
            Btn_Upd_Prov.Name = "Btn_Upd_Prov";
            Btn_Upd_Prov.Size = new Size(234, 60);
            Btn_Upd_Prov.TabIndex = 7;
            Btn_Upd_Prov.Text = "Modificar Proveedor";
            Btn_Upd_Prov.UseVisualStyleBackColor = true;
            Btn_Upd_Prov.Click += Btn_Upd_Prov_Click;
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
            // Btn_Emp_Prov
            // 
            Btn_Emp_Prov.Dock = DockStyle.Bottom;
            Btn_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Btn_Emp_Prov.Location = new Point(0, 400);
            Btn_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Btn_Emp_Prov.Name = "Btn_Emp_Prov";
            Btn_Emp_Prov.Size = new Size(234, 60);
            Btn_Emp_Prov.TabIndex = 3;
            Btn_Emp_Prov.Text = "Empleados Proveedor";
            Btn_Emp_Prov.UseVisualStyleBackColor = true;
            Btn_Emp_Prov.Click += Btn_Emp_Prov_Click;
            // 
            // Btn_Add_Prov
            // 
            Btn_Add_Prov.Dock = DockStyle.Top;
            Btn_Add_Prov.Font = new Font("Segoe UI", 11F);
            Btn_Add_Prov.Location = new Point(0, 33);
            Btn_Add_Prov.Margin = new Padding(3, 4, 3, 4);
            Btn_Add_Prov.Name = "Btn_Add_Prov";
            Btn_Add_Prov.Size = new Size(234, 60);
            Btn_Add_Prov.TabIndex = 0;
            Btn_Add_Prov.Text = "Añadir Nuevo Proveedor";
            Btn_Add_Prov.UseVisualStyleBackColor = true;
            Btn_Add_Prov.Click += Btn_Add_Prov_Click;
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.Controls.Add(CmB_Filtro_Prov);
            Pnl_Filtro.Controls.Add(Lbl_Filtro_Prov);
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(914, 80);
            Pnl_Filtro.TabIndex = 3;
            // 
            // CmB_Filtro_Prov
            // 
            CmB_Filtro_Prov.DropDownStyle = ComboBoxStyle.DropDownList;
            CmB_Filtro_Prov.Font = new Font("Segoe UI", 11F);
            CmB_Filtro_Prov.FormattingEnabled = true;
            CmB_Filtro_Prov.Location = new Point(154, 20);
            CmB_Filtro_Prov.Margin = new Padding(3, 4, 3, 4);
            CmB_Filtro_Prov.Name = "CmB_Filtro_Prov";
            CmB_Filtro_Prov.Size = new Size(199, 33);
            CmB_Filtro_Prov.TabIndex = 3;
            // 
            // Lbl_Filtro_Prov
            // 
            Lbl_Filtro_Prov.AutoSize = true;
            Lbl_Filtro_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro_Prov.Location = new Point(51, 27);
            Lbl_Filtro_Prov.Name = "Lbl_Filtro_Prov";
            Lbl_Filtro_Prov.Size = new Size(99, 25);
            Lbl_Filtro_Prov.TabIndex = 2;
            Lbl_Filtro_Prov.Text = "Filtrar por:";
            // 
            // V_Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Prov);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Proveedores";
            Text = "V_Proveedores";
            Pnl_Prov.ResumeLayout(false);
            Pnl_Prov.PerformLayout();
            Pnl_Table_Prov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Prov).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Filtro.ResumeLayout(false);
            Pnl_Filtro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Prov;
        private Panel Pnl_Filtro;
        private ComboBox CmB_Filtro_Prov;
        private Label Lbl_Filtro_Prov;
        private Panel Pnl_Table_Prov;
        private DataGridView DGV_Table_Prov;
        private Panel Pnl_Buttons;
        private Button Btn_Emp_Prov;
        private Button Btn_Add_Prov;
        private Button Btn_Upd_Prov;
        private Panel Pnl_Space1;
        private Button Btn_Eliminar_Prov;
        private Panel panel1;
    }
}