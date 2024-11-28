namespace Vistas
{
    partial class V_CRUD_Asig_Act
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
            Pnl_AsigEmp_Act = new Panel();
            Pnl_Table = new Panel();
            DGV_AsigEmp = new DataGridView();
            Pnl_Buttons = new Panel();
            Btn_Cancelar_AsigEmp_Act = new Button();
            Btn_Asignar_AsigEmp_Act = new Button();
            Pnl_Filtro = new Panel();
            Cmb_Filtro = new ComboBox();
            Lbl_Filtro = new Label();
            Pnl_AsigEmp_Act.SuspendLayout();
            Pnl_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_AsigEmp).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtro.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_AsigEmp_Act
            // 
            Pnl_AsigEmp_Act.Controls.Add(Pnl_Table);
            Pnl_AsigEmp_Act.Controls.Add(Pnl_Buttons);
            Pnl_AsigEmp_Act.Controls.Add(Pnl_Filtro);
            Pnl_AsigEmp_Act.Dock = DockStyle.Fill;
            Pnl_AsigEmp_Act.Location = new Point(0, 0);
            Pnl_AsigEmp_Act.Margin = new Padding(4, 5, 4, 5);
            Pnl_AsigEmp_Act.Name = "Pnl_AsigEmp_Act";
            Pnl_AsigEmp_Act.Size = new Size(762, 726);
            Pnl_AsigEmp_Act.TabIndex = 0;
            // 
            // Pnl_Table
            // 
            Pnl_Table.AutoSize = true;
            Pnl_Table.Controls.Add(DGV_AsigEmp);
            Pnl_Table.Dock = DockStyle.Fill;
            Pnl_Table.Location = new Point(0, 100);
            Pnl_Table.Margin = new Padding(4, 5, 4, 5);
            Pnl_Table.Name = "Pnl_Table";
            Pnl_Table.Size = new Size(762, 526);
            Pnl_Table.TabIndex = 2;
            // 
            // DGV_AsigEmp
            // 
            DGV_AsigEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_AsigEmp.Dock = DockStyle.Fill;
            DGV_AsigEmp.Location = new Point(0, 0);
            DGV_AsigEmp.Margin = new Padding(4, 5, 4, 5);
            DGV_AsigEmp.Name = "DGV_AsigEmp";
            DGV_AsigEmp.RowHeadersWidth = 51;
            DGV_AsigEmp.Size = new Size(762, 526);
            DGV_AsigEmp.TabIndex = 0;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Btn_Cancelar_AsigEmp_Act);
            Pnl_Buttons.Controls.Add(Btn_Asignar_AsigEmp_Act);
            Pnl_Buttons.Dock = DockStyle.Bottom;
            Pnl_Buttons.Location = new Point(0, 626);
            Pnl_Buttons.Margin = new Padding(4, 5, 4, 5);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new Size(762, 100);
            Pnl_Buttons.TabIndex = 1;
            // 
            // Btn_Cancelar_AsigEmp_Act
            // 
            Btn_Cancelar_AsigEmp_Act.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_AsigEmp_Act.BackColor = Color.DarkRed;
            Btn_Cancelar_AsigEmp_Act.Cursor = Cursors.Hand;
            Btn_Cancelar_AsigEmp_Act.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_AsigEmp_Act.ForeColor = Color.White;
            Btn_Cancelar_AsigEmp_Act.Location = new Point(462, 25);
            Btn_Cancelar_AsigEmp_Act.Margin = new Padding(4, 5, 4, 5);
            Btn_Cancelar_AsigEmp_Act.Name = "Btn_Cancelar_AsigEmp_Act";
            Btn_Cancelar_AsigEmp_Act.Size = new Size(142, 50);
            Btn_Cancelar_AsigEmp_Act.TabIndex = 9;
            Btn_Cancelar_AsigEmp_Act.Text = "Cancelar";
            Btn_Cancelar_AsigEmp_Act.UseVisualStyleBackColor = false;
            Btn_Cancelar_AsigEmp_Act.Click += Btn_Cancelar_AsigEmp_Act_Click;
            // 
            // Btn_Asignar_AsigEmp_Act
            // 
            Btn_Asignar_AsigEmp_Act.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Asignar_AsigEmp_Act.BackColor = Color.Green;
            Btn_Asignar_AsigEmp_Act.Cursor = Cursors.Hand;
            Btn_Asignar_AsigEmp_Act.Font = new Font("Segoe UI", 11F);
            Btn_Asignar_AsigEmp_Act.ForeColor = Color.White;
            Btn_Asignar_AsigEmp_Act.Location = new Point(158, 25);
            Btn_Asignar_AsigEmp_Act.Margin = new Padding(4, 5, 4, 5);
            Btn_Asignar_AsigEmp_Act.Name = "Btn_Asignar_AsigEmp_Act";
            Btn_Asignar_AsigEmp_Act.Size = new Size(142, 50);
            Btn_Asignar_AsigEmp_Act.TabIndex = 8;
            Btn_Asignar_AsigEmp_Act.Text = "Asignar";
            Btn_Asignar_AsigEmp_Act.UseVisualStyleBackColor = false;
            Btn_Asignar_AsigEmp_Act.Click += Btn_Asignar_AsigEmp_Act_Click;
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.BackColor = Color.White;
            Pnl_Filtro.Controls.Add(Cmb_Filtro);
            Pnl_Filtro.Controls.Add(Lbl_Filtro);
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(4, 5, 4, 5);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(762, 100);
            Pnl_Filtro.TabIndex = 0;
            // 
            // Cmb_Filtro
            // 
            Cmb_Filtro.Font = new Font("Segoe UI", 11F);
            Cmb_Filtro.FormattingEnabled = true;
            Cmb_Filtro.Location = new Point(186, 25);
            Cmb_Filtro.Margin = new Padding(4, 5, 4, 5);
            Cmb_Filtro.Name = "Cmb_Filtro";
            Cmb_Filtro.Size = new Size(392, 38);
            Cmb_Filtro.TabIndex = 1;
            // 
            // Lbl_Filtro
            // 
            Lbl_Filtro.AutoSize = true;
            Lbl_Filtro.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro.Location = new Point(42, 34);
            Lbl_Filtro.Margin = new Padding(4, 0, 4, 0);
            Lbl_Filtro.Name = "Lbl_Filtro";
            Lbl_Filtro.Size = new Size(113, 30);
            Lbl_Filtro.TabIndex = 0;
            Lbl_Filtro.Text = "Filtrar por:";
            // 
            // V_CRUD_Asig_Act
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 726);
            Controls.Add(Pnl_AsigEmp_Act);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "V_CRUD_Asig_Act";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar Actividad a Empleado";
            Pnl_AsigEmp_Act.ResumeLayout(false);
            Pnl_AsigEmp_Act.PerformLayout();
            Pnl_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_AsigEmp).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Filtro.ResumeLayout(false);
            Pnl_Filtro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_AsigEmp_Act;
        private Panel Pnl_Filtro;
        private Panel Pnl_Table;
        private Panel Pnl_Buttons;
        private ComboBox Cmb_Filtro;
        private Label Lbl_Filtro;
        private DataGridView DGV_AsigEmp;
        private Button Btn_Cancelar_AsigEmp_Act;
        private Button Btn_Asignar_AsigEmp_Act;
    }
}