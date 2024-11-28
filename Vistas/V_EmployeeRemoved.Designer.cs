namespace Vistas
{
    partial class V_EmployeeRemoved
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
            Pnl_Table_Emp = new Panel();
            TablaEmpRemoved = new DataGridView();
            Pnl_Buttons = new Panel();
            BActivarEmp = new Button();
            Pnl_Table_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaEmpRemoved).BeginInit();
            Pnl_Buttons.SuspendLayout();
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
            // Pnl_Table_Emp
            // 
            Pnl_Table_Emp.AutoSize = true;
            Pnl_Table_Emp.BackColor = Color.White;
            Pnl_Table_Emp.Controls.Add(TablaEmpRemoved);
            Pnl_Table_Emp.Dock = DockStyle.Fill;
            Pnl_Table_Emp.Location = new Point(0, 80);
            Pnl_Table_Emp.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Emp.Name = "Pnl_Table_Emp";
            Pnl_Table_Emp.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Emp.Size = new Size(657, 520);
            Pnl_Table_Emp.TabIndex = 8;
            // 
            // TablaEmpRemoved
            // 
            TablaEmpRemoved.AllowUserToAddRows = false;
            TablaEmpRemoved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaEmpRemoved.Dock = DockStyle.Fill;
            TablaEmpRemoved.Location = new Point(51, 33);
            TablaEmpRemoved.Margin = new Padding(3, 4, 3, 4);
            TablaEmpRemoved.Name = "TablaEmpRemoved";
            TablaEmpRemoved.RowHeadersVisible = false;
            TablaEmpRemoved.RowHeadersWidth = 51;
            TablaEmpRemoved.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaEmpRemoved.Size = new Size(572, 427);
            TablaEmpRemoved.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(BActivarEmp);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 7;
            // 
            // BActivarEmp
            // 
            BActivarEmp.BackColor = Color.Green;
            BActivarEmp.Cursor = Cursors.Hand;
            BActivarEmp.Dock = DockStyle.Top;
            BActivarEmp.Font = new Font("Segoe UI", 11F);
            BActivarEmp.ForeColor = Color.White;
            BActivarEmp.Location = new Point(0, 33);
            BActivarEmp.Margin = new Padding(3, 4, 3, 4);
            BActivarEmp.Name = "BActivarEmp";
            BActivarEmp.Size = new Size(234, 60);
            BActivarEmp.TabIndex = 0;
            BActivarEmp.Text = "Reactivar Empleado";
            BActivarEmp.UseVisualStyleBackColor = false;
            BActivarEmp.Click += BActivarEmp_Click;
            // 
            // V_EmpolyeeRemoved
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Table_Emp);
            Controls.Add(Pnl_Buttons);
            Controls.Add(Pnl_Filtro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_EmpolyeeRemoved";
            Text = "V_EmpolyeeRemoved";
            Pnl_Table_Emp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaEmpRemoved).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Filtro;
        private Panel Pnl_Table_Emp;
        private DataGridView TablaEmpRemoved;
        private Panel Pnl_Buttons;
        private Button BActivarEmp;
    }
}