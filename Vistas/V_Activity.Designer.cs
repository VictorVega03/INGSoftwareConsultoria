namespace Vistas
{
    partial class V_Activity
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
            Pnl_Act = new Panel();
            Pnl_Table_Act = new Panel();
            tablaActividad = new DataGridView();
            Pnl_Buttons = new Panel();
            Bnotas = new Button();
            Btn_FPC_Act = new Button();
            Pnl_Space2 = new Panel();
            BmodifAct = new Button();
            Pnl_Space1 = new Panel();
            Btn_Hist_Act = new Button();
            BagregarAct = new Button();
            Pnl_Filtro = new Panel();
            Pnl_Act.SuspendLayout();
            Pnl_Table_Act.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaActividad).BeginInit();
            Pnl_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Act
            // 
            Pnl_Act.AutoSize = true;
            Pnl_Act.Controls.Add(Pnl_Table_Act);
            Pnl_Act.Controls.Add(Pnl_Buttons);
            Pnl_Act.Controls.Add(Pnl_Filtro);
            Pnl_Act.Dock = DockStyle.Fill;
            Pnl_Act.Location = new Point(0, 0);
            Pnl_Act.Margin = new Padding(3, 4, 3, 4);
            Pnl_Act.Name = "Pnl_Act";
            Pnl_Act.Size = new Size(914, 600);
            Pnl_Act.TabIndex = 2;
            // 
            // Pnl_Table_Act
            // 
            Pnl_Table_Act.AutoSize = true;
            Pnl_Table_Act.BackColor = Color.White;
            Pnl_Table_Act.Controls.Add(tablaActividad);
            Pnl_Table_Act.Dock = DockStyle.Fill;
            Pnl_Table_Act.Location = new Point(0, 80);
            Pnl_Table_Act.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Act.Name = "Pnl_Table_Act";
            Pnl_Table_Act.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Act.Size = new Size(657, 520);
            Pnl_Table_Act.TabIndex = 7;
            // 
            // tablaActividad
            // 
            tablaActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaActividad.Dock = DockStyle.Fill;
            tablaActividad.Location = new Point(51, 33);
            tablaActividad.Margin = new Padding(3, 4, 3, 4);
            tablaActividad.Name = "tablaActividad";
            tablaActividad.RowHeadersWidth = 51;
            tablaActividad.Size = new Size(572, 427);
            tablaActividad.TabIndex = 4;
            tablaActividad.CellContentDoubleClick += tablaActividad_CellContentDoubleClick;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Bnotas);
            Pnl_Buttons.Controls.Add(Btn_FPC_Act);
            Pnl_Buttons.Controls.Add(Pnl_Space2);
            Pnl_Buttons.Controls.Add(BmodifAct);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(Btn_Hist_Act);
            Pnl_Buttons.Controls.Add(BagregarAct);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 6;
            // 
            // Bnotas
            // 
            Bnotas.BackColor = Color.DarkRed;
            Bnotas.Cursor = Cursors.Hand;
            Bnotas.Dock = DockStyle.Bottom;
            Bnotas.Font = new Font("Segoe UI", 11F);
            Bnotas.ForeColor = Color.White;
            Bnotas.Location = new Point(0, 340);
            Bnotas.Margin = new Padding(3, 4, 3, 4);
            Bnotas.Name = "Bnotas";
            Bnotas.Size = new Size(234, 60);
            Bnotas.TabIndex = 10;
            Bnotas.Text = "Notas de Actividad";
            Bnotas.UseVisualStyleBackColor = false;
            Bnotas.Click += Bnotas_Click;
            // 
            // Btn_FPC_Act
            // 
            Btn_FPC_Act.BackColor = Color.Green;
            Btn_FPC_Act.Cursor = Cursors.Hand;
            Btn_FPC_Act.Dock = DockStyle.Top;
            Btn_FPC_Act.Font = new Font("Segoe UI", 10F);
            Btn_FPC_Act.ForeColor = Color.White;
            Btn_FPC_Act.Location = new Point(0, 207);
            Btn_FPC_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_FPC_Act.Name = "Btn_FPC_Act";
            Btn_FPC_Act.Size = new Size(234, 60);
            Btn_FPC_Act.TabIndex = 9;
            Btn_FPC_Act.Text = "Finalizar Actividad";
            Btn_FPC_Act.UseVisualStyleBackColor = false;
            Btn_FPC_Act.Click += Btn_Eliminar_Act_Click;
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
            // BmodifAct
            // 
            BmodifAct.BackColor = Color.Green;
            BmodifAct.Cursor = Cursors.Hand;
            BmodifAct.Dock = DockStyle.Top;
            BmodifAct.Font = new Font("Segoe UI", 11F);
            BmodifAct.ForeColor = Color.White;
            BmodifAct.Location = new Point(0, 120);
            BmodifAct.Margin = new Padding(3, 4, 3, 4);
            BmodifAct.Name = "BmodifAct";
            BmodifAct.Size = new Size(234, 60);
            BmodifAct.TabIndex = 7;
            BmodifAct.Text = "Modificar Actividad";
            BmodifAct.UseVisualStyleBackColor = false;
            BmodifAct.Click += Btn_Upd_Act_Click;
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
            // Btn_Hist_Act
            // 
            Btn_Hist_Act.BackColor = Color.DarkRed;
            Btn_Hist_Act.Cursor = Cursors.Hand;
            Btn_Hist_Act.Dock = DockStyle.Bottom;
            Btn_Hist_Act.Font = new Font("Segoe UI", 11F);
            Btn_Hist_Act.ForeColor = Color.White;
            Btn_Hist_Act.Location = new Point(0, 400);
            Btn_Hist_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_Hist_Act.Name = "Btn_Hist_Act";
            Btn_Hist_Act.Size = new Size(234, 60);
            Btn_Hist_Act.TabIndex = 3;
            Btn_Hist_Act.Text = "Historial de Actividades";
            Btn_Hist_Act.UseVisualStyleBackColor = false;
            Btn_Hist_Act.Visible = false;
            Btn_Hist_Act.Click += Btn_Hist_Act_Click;
            // 
            // BagregarAct
            // 
            BagregarAct.BackColor = Color.Green;
            BagregarAct.Cursor = Cursors.Hand;
            BagregarAct.Dock = DockStyle.Top;
            BagregarAct.Font = new Font("Segoe UI", 11F);
            BagregarAct.ForeColor = Color.White;
            BagregarAct.Location = new Point(0, 33);
            BagregarAct.Margin = new Padding(3, 4, 3, 4);
            BagregarAct.Name = "BagregarAct";
            BagregarAct.Size = new Size(234, 60);
            BagregarAct.TabIndex = 0;
            BagregarAct.Text = "Añadir Nueva Actividad";
            BagregarAct.UseVisualStyleBackColor = false;
            BagregarAct.Click += Btn_Add_Act_Click;
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
            // V_Activity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Act);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Activity";
            Text = "V_Activity";
            Pnl_Act.ResumeLayout(false);
            Pnl_Act.PerformLayout();
            Pnl_Table_Act.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaActividad).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Act;
        private Panel Pnl_Filtro;
        private Panel Pnl_Table_Act;
        private DataGridView tablaActividad;
        private Panel Pnl_Buttons;
        private Button Btn_Hist_Act;
        private Button BagregarAct;
        private Button BmodifAct;
        private Panel Pnl_Space1;
        private Button Btn_FPC_Act;
        private Panel Pnl_Space2;
        private Button Bnotas;
    }
}