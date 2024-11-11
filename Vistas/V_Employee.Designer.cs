namespace Vistas
{
    partial class V_Employee
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
            Pnl_Emp = new Panel();
            Pnl_Table_Emp = new Panel();
            DGV_Table_Emp = new DataGridView();
            Pnl_Buttons = new Panel();
            Btn_Eliminar_Emp = new Button();
            Pnl_Space2 = new Panel();
            Btn_Upd_Emp = new Button();
            Pnl_Space1 = new Panel();
            Btn_Add_Emp = new Button();
            Pnl_Filtro = new Panel();
            BoxFiltroEmp = new ComboBox();
            Lbl_Filtro_Emp = new Label();
            Pnl_Emp.SuspendLayout();
            Pnl_Table_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Emp).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtro.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Emp
            // 
            Pnl_Emp.AutoSize = true;
            Pnl_Emp.Controls.Add(Pnl_Table_Emp);
            Pnl_Emp.Controls.Add(Pnl_Buttons);
            Pnl_Emp.Controls.Add(Pnl_Filtro);
            Pnl_Emp.Dock = DockStyle.Fill;
            Pnl_Emp.Location = new Point(0, 0);
            Pnl_Emp.Margin = new Padding(3, 4, 3, 4);
            Pnl_Emp.Name = "Pnl_Emp";
            Pnl_Emp.Size = new Size(914, 600);
            Pnl_Emp.TabIndex = 0;
            // 
            // Pnl_Table_Emp
            // 
            Pnl_Table_Emp.AutoSize = true;
            Pnl_Table_Emp.Controls.Add(DGV_Table_Emp);
            Pnl_Table_Emp.Dock = DockStyle.Fill;
            Pnl_Table_Emp.Location = new Point(0, 80);
            Pnl_Table_Emp.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Emp.Name = "Pnl_Table_Emp";
            Pnl_Table_Emp.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Emp.Size = new Size(657, 520);
            Pnl_Table_Emp.TabIndex = 7;
            // 
            // DGV_Table_Emp
            // 
            DGV_Table_Emp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Table_Emp.Dock = DockStyle.Fill;
            DGV_Table_Emp.Location = new Point(51, 33);
            DGV_Table_Emp.Margin = new Padding(3, 4, 3, 4);
            DGV_Table_Emp.Name = "DGV_Table_Emp";
            DGV_Table_Emp.RowHeadersVisible = false;
            DGV_Table_Emp.RowHeadersWidth = 51;
            DGV_Table_Emp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Table_Emp.Size = new Size(572, 427);
            DGV_Table_Emp.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(Btn_Eliminar_Emp);
            Pnl_Buttons.Controls.Add(Pnl_Space2);
            Pnl_Buttons.Controls.Add(Btn_Upd_Emp);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(Btn_Add_Emp);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 6;
            // 
            // Btn_Eliminar_Emp
            // 
            Btn_Eliminar_Emp.Dock = DockStyle.Top;
            Btn_Eliminar_Emp.Font = new Font("Segoe UI", 11F);
            Btn_Eliminar_Emp.Location = new Point(0, 207);
            Btn_Eliminar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Emp.Name = "Btn_Eliminar_Emp";
            Btn_Eliminar_Emp.Size = new Size(234, 60);
            Btn_Eliminar_Emp.TabIndex = 9;
            Btn_Eliminar_Emp.Text = "Eliminar Empleado";
            Btn_Eliminar_Emp.UseVisualStyleBackColor = true;
            Btn_Eliminar_Emp.Click += Btn_Eliminar_Emp_Click;
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
            // Btn_Upd_Emp
            // 
            Btn_Upd_Emp.Dock = DockStyle.Top;
            Btn_Upd_Emp.Font = new Font("Segoe UI", 11F);
            Btn_Upd_Emp.Location = new Point(0, 120);
            Btn_Upd_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Upd_Emp.Name = "Btn_Upd_Emp";
            Btn_Upd_Emp.Size = new Size(234, 60);
            Btn_Upd_Emp.TabIndex = 7;
            Btn_Upd_Emp.Text = "Modificar Empleado";
            Btn_Upd_Emp.UseVisualStyleBackColor = true;
            Btn_Upd_Emp.Click += Btn_Upd_Emp_Click;
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
            // Btn_Add_Emp
            // 
            Btn_Add_Emp.Dock = DockStyle.Top;
            Btn_Add_Emp.Font = new Font("Segoe UI", 11F);
            Btn_Add_Emp.Location = new Point(0, 33);
            Btn_Add_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Add_Emp.Name = "Btn_Add_Emp";
            Btn_Add_Emp.Size = new Size(234, 60);
            Btn_Add_Emp.TabIndex = 0;
            Btn_Add_Emp.Text = "Añadir Nuevo Empleado";
            Btn_Add_Emp.UseVisualStyleBackColor = true;
            Btn_Add_Emp.Click += Btn_Add_Emp_Click;
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.Controls.Add(BoxFiltroEmp);
            Pnl_Filtro.Controls.Add(Lbl_Filtro_Emp);
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(914, 80);
            Pnl_Filtro.TabIndex = 3;
            // 
            // BoxFiltroEmp
            // 
            BoxFiltroEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxFiltroEmp.Font = new Font("Segoe UI", 11F);
            BoxFiltroEmp.FormattingEnabled = true;
            BoxFiltroEmp.Location = new Point(236, 24);
            BoxFiltroEmp.Margin = new Padding(3, 4, 3, 4);
            BoxFiltroEmp.Name = "BoxFiltroEmp";
            BoxFiltroEmp.Size = new Size(199, 33);
            BoxFiltroEmp.TabIndex = 3;
            BoxFiltroEmp.SelectedIndexChanged += BoxFiltroEmp_SelectedIndexChanged;
            // 
            // Lbl_Filtro_Emp
            // 
            Lbl_Filtro_Emp.AutoSize = true;
            Lbl_Filtro_Emp.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro_Emp.Location = new Point(51, 27);
            Lbl_Filtro_Emp.Name = "Lbl_Filtro_Emp";
            Lbl_Filtro_Emp.Size = new Size(179, 25);
            Lbl_Filtro_Emp.TabIndex = 2;
            Lbl_Filtro_Emp.Text = "Filtrar por Permisos:";
            // 
            // V_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Emp);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Employee";
            Text = "V_Employee";
            Pnl_Emp.ResumeLayout(false);
            Pnl_Emp.PerformLayout();
            Pnl_Table_Emp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Emp).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Filtro.ResumeLayout(false);
            Pnl_Filtro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Emp;
        private Panel Pnl_Filtro;
        private Label Lbl_Filtro_Emp;
        private ComboBox BoxFiltroEmp;
        private Panel Pnl_Table_Emp;
        private DataGridView DGV_Table_Emp;
        private Panel Pnl_Buttons;
        private Button Btn_Add_Emp;
        private Button Btn_Upd_Emp;
        private Panel Pnl_Space1;
        private Button Btn_Eliminar_Emp;
        private Panel Pnl_Space2;
    }
}