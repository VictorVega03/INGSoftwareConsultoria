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
            button1 = new Button();
            panel17 = new Panel();
            panel16 = new Panel();
            panel15 = new Panel();
            panel14 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel10 = new Panel();
            panel8 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel13 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            Btn_Eliminar_Emp = new Button();
            Pnl_Space2 = new Panel();
            Btn_Upd_Emp = new Button();
            Pnl_Space1 = new Panel();
            Btn_Add_Emp = new Button();
            Pnl_Filtro = new Panel();
            Pnl_Emp.SuspendLayout();
            Pnl_Table_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Emp).BeginInit();
            Pnl_Buttons.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
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
            Pnl_Table_Emp.BackColor = Color.White;
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
            DGV_Table_Emp.AllowUserToAddRows = false;
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
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(button1);
            Pnl_Buttons.Controls.Add(panel17);
            Pnl_Buttons.Controls.Add(panel16);
            Pnl_Buttons.Controls.Add(panel15);
            Pnl_Buttons.Controls.Add(panel14);
            Pnl_Buttons.Controls.Add(panel3);
            Pnl_Buttons.Controls.Add(panel1);
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
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 429);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(234, 60);
            button1.TabIndex = 17;
            button1.Text = "Empleados Eliminados";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel17
            // 
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 402);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(234, 27);
            panel17.TabIndex = 16;
            // 
            // panel16
            // 
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 375);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(234, 27);
            panel16.TabIndex = 15;
            // 
            // panel15
            // 
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 348);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(234, 27);
            panel15.TabIndex = 14;
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 321);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(234, 27);
            panel14.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 294);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 27);
            panel3.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 27);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 27);
            panel5.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 27);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(234, 27);
            panel7.TabIndex = 13;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 27);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(234, 27);
            panel9.TabIndex = 13;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel12);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 27);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(234, 27);
            panel11.TabIndex = 13;
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(234, 27);
            panel12.TabIndex = 12;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(234, 27);
            panel10.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(234, 27);
            panel8.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 27);
            panel6.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel13);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 27);
            panel4.TabIndex = 12;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(234, 27);
            panel13.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 267);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 27);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 27);
            panel2.TabIndex = 9;
            // 
            // Btn_Eliminar_Emp
            // 
            Btn_Eliminar_Emp.BackColor = Color.Green;
            Btn_Eliminar_Emp.Cursor = Cursors.Hand;
            Btn_Eliminar_Emp.Dock = DockStyle.Top;
            Btn_Eliminar_Emp.Font = new Font("Segoe UI", 11F);
            Btn_Eliminar_Emp.ForeColor = Color.White;
            Btn_Eliminar_Emp.Location = new Point(0, 207);
            Btn_Eliminar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Emp.Name = "Btn_Eliminar_Emp";
            Btn_Eliminar_Emp.Size = new Size(234, 60);
            Btn_Eliminar_Emp.TabIndex = 9;
            Btn_Eliminar_Emp.Text = "Eliminar Empleado";
            Btn_Eliminar_Emp.UseVisualStyleBackColor = false;
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
            Btn_Upd_Emp.BackColor = Color.Green;
            Btn_Upd_Emp.Cursor = Cursors.Hand;
            Btn_Upd_Emp.Dock = DockStyle.Top;
            Btn_Upd_Emp.Font = new Font("Segoe UI", 11F);
            Btn_Upd_Emp.ForeColor = Color.White;
            Btn_Upd_Emp.Location = new Point(0, 120);
            Btn_Upd_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Upd_Emp.Name = "Btn_Upd_Emp";
            Btn_Upd_Emp.Size = new Size(234, 60);
            Btn_Upd_Emp.TabIndex = 7;
            Btn_Upd_Emp.Text = "Modificar Empleado";
            Btn_Upd_Emp.UseVisualStyleBackColor = false;
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
            Btn_Add_Emp.BackColor = Color.Green;
            Btn_Add_Emp.Cursor = Cursors.Hand;
            Btn_Add_Emp.Dock = DockStyle.Top;
            Btn_Add_Emp.Font = new Font("Segoe UI", 11F);
            Btn_Add_Emp.ForeColor = Color.White;
            Btn_Add_Emp.Location = new Point(0, 33);
            Btn_Add_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Add_Emp.Name = "Btn_Add_Emp";
            Btn_Add_Emp.Size = new Size(234, 60);
            Btn_Add_Emp.TabIndex = 0;
            Btn_Add_Emp.Text = "Añadir Nuevo Empleado";
            Btn_Add_Emp.UseVisualStyleBackColor = false;
            Btn_Add_Emp.Click += Btn_Add_Emp_Click;
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.BackColor = Color.White;
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(914, 80);
            Pnl_Filtro.TabIndex = 3;
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
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Emp;
        private Panel Pnl_Table_Emp;
        private DataGridView DGV_Table_Emp;
        private Panel Pnl_Buttons;
        private Button Btn_Eliminar_Emp;
        private Panel Pnl_Space2;
        private Button Btn_Upd_Emp;
        private Panel Pnl_Space1;
        private Button Btn_Add_Emp;
        private Panel Pnl_Filtro;
        private Button button1;
        private Panel panel17;
        private Panel panel16;
        private Panel panel15;
        private Panel panel14;
        private Panel panel3;
        private Panel panel5;
        private Panel panel7;
        private Panel panel9;
        private Panel panel11;
        private Panel panel12;
        private Panel panel10;
        private Panel panel8;
        private Panel panel6;
        private Panel panel4;
        private Panel panel13;
        private Panel panel1;
        private Panel panel2;
    }
}