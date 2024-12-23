﻿namespace Vistas
{
    partial class V_Proyect
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
            Pnl_Proyect = new Panel();
            Pnl_Table = new Panel();
            DGV_Tabla_Proyect = new DataGridView();
            Pnl_Buttons = new Panel();
            Btn_Hist_Proyect = new Button();
            Pnl_Space3 = new Panel();
            Btn_FPC_Proyect = new Button();
            Pnl_Space2 = new Panel();
            Btn_Upd_Proyect = new Button();
            Pnl_Space1 = new Panel();
            Btn_Act = new Button();
            Btn_Add_Proyect = new Button();
            Pnl_Filtros = new Panel();
            FiltroFecha1 = new DateTimePicker();
            BFiltrarFecha = new Button();
            FiltroFecha2 = new DateTimePicker();
            Lbl_Filtro2_Proyect = new Label();
            Lbl_Filtro1_Proyect = new Label();
            Pnl_Proyect.SuspendLayout();
            Pnl_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Tabla_Proyect).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtros.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Proyect
            // 
            Pnl_Proyect.Controls.Add(Pnl_Table);
            Pnl_Proyect.Controls.Add(Pnl_Buttons);
            Pnl_Proyect.Controls.Add(Pnl_Filtros);
            Pnl_Proyect.Dock = DockStyle.Fill;
            Pnl_Proyect.Location = new Point(0, 0);
            Pnl_Proyect.Margin = new Padding(3, 4, 3, 4);
            Pnl_Proyect.Name = "Pnl_Proyect";
            Pnl_Proyect.Size = new Size(914, 600);
            Pnl_Proyect.TabIndex = 0;
            // 
            // Pnl_Table
            // 
            Pnl_Table.BackColor = Color.White;
            Pnl_Table.Controls.Add(DGV_Tabla_Proyect);
            Pnl_Table.Dock = DockStyle.Fill;
            Pnl_Table.Location = new Point(0, 80);
            Pnl_Table.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table.Name = "Pnl_Table";
            Pnl_Table.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table.Size = new Size(657, 520);
            Pnl_Table.TabIndex = 4;
            // 
            // DGV_Tabla_Proyect
            // 
            DGV_Tabla_Proyect.BackgroundColor = SystemColors.ButtonFace;
            DGV_Tabla_Proyect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Tabla_Proyect.Dock = DockStyle.Fill;
            DGV_Tabla_Proyect.Location = new Point(51, 33);
            DGV_Tabla_Proyect.Margin = new Padding(3, 4, 3, 4);
            DGV_Tabla_Proyect.Name = "DGV_Tabla_Proyect";
            DGV_Tabla_Proyect.RowHeadersWidth = 51;
            DGV_Tabla_Proyect.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DGV_Tabla_Proyect.Size = new Size(572, 427);
            DGV_Tabla_Proyect.TabIndex = 0;
            DGV_Tabla_Proyect.CellContentDoubleClick += DGV_Tabla_Proyect_CellContentDoubleClick;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Btn_Hist_Proyect);
            Pnl_Buttons.Controls.Add(Pnl_Space3);
            Pnl_Buttons.Controls.Add(Btn_FPC_Proyect);
            Pnl_Buttons.Controls.Add(Pnl_Space2);
            Pnl_Buttons.Controls.Add(Btn_Upd_Proyect);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(Btn_Act);
            Pnl_Buttons.Controls.Add(Btn_Add_Proyect);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 3;
            // 
            // Btn_Hist_Proyect
            // 
            Btn_Hist_Proyect.BackColor = Color.FromArgb(25, 29, 42);
            Btn_Hist_Proyect.Cursor = Cursors.Hand;
            Btn_Hist_Proyect.Dock = DockStyle.Bottom;
            Btn_Hist_Proyect.Font = new Font("Segoe UI", 11F);
            Btn_Hist_Proyect.ForeColor = Color.White;
            Btn_Hist_Proyect.Location = new Point(0, 313);
            Btn_Hist_Proyect.Margin = new Padding(3, 4, 3, 4);
            Btn_Hist_Proyect.Name = "Btn_Hist_Proyect";
            Btn_Hist_Proyect.Size = new Size(234, 60);
            Btn_Hist_Proyect.TabIndex = 10;
            Btn_Hist_Proyect.Text = "Historial de Proyectos";
            Btn_Hist_Proyect.UseVisualStyleBackColor = false;
            Btn_Hist_Proyect.Click += Btn_Hist_Proyect_Click;
            // 
            // Pnl_Space3
            // 
            Pnl_Space3.Dock = DockStyle.Bottom;
            Pnl_Space3.Location = new Point(0, 373);
            Pnl_Space3.Margin = new Padding(3, 4, 3, 4);
            Pnl_Space3.Name = "Pnl_Space3";
            Pnl_Space3.Size = new Size(234, 27);
            Pnl_Space3.TabIndex = 9;
            // 
            // Btn_FPC_Proyect
            // 
            Btn_FPC_Proyect.BackColor = Color.Green;
            Btn_FPC_Proyect.Cursor = Cursors.Hand;
            Btn_FPC_Proyect.Dock = DockStyle.Top;
            Btn_FPC_Proyect.Font = new Font("Segoe UI", 10F);
            Btn_FPC_Proyect.ForeColor = Color.White;
            Btn_FPC_Proyect.Location = new Point(0, 207);
            Btn_FPC_Proyect.Margin = new Padding(3, 4, 3, 4);
            Btn_FPC_Proyect.Name = "Btn_FPC_Proyect";
            Btn_FPC_Proyect.Size = new Size(234, 60);
            Btn_FPC_Proyect.TabIndex = 8;
            Btn_FPC_Proyect.Text = "Finalizar/Cancelar";
            Btn_FPC_Proyect.UseVisualStyleBackColor = false;
            Btn_FPC_Proyect.Click += Btn_FPC_Proyect_Click;
            // 
            // Pnl_Space2
            // 
            Pnl_Space2.Dock = DockStyle.Top;
            Pnl_Space2.Location = new Point(0, 180);
            Pnl_Space2.Margin = new Padding(3, 4, 3, 4);
            Pnl_Space2.Name = "Pnl_Space2";
            Pnl_Space2.Size = new Size(234, 27);
            Pnl_Space2.TabIndex = 7;
            // 
            // Btn_Upd_Proyect
            // 
            Btn_Upd_Proyect.BackColor = Color.Green;
            Btn_Upd_Proyect.Cursor = Cursors.Hand;
            Btn_Upd_Proyect.Dock = DockStyle.Top;
            Btn_Upd_Proyect.Font = new Font("Segoe UI", 11F);
            Btn_Upd_Proyect.ForeColor = Color.White;
            Btn_Upd_Proyect.Location = new Point(0, 120);
            Btn_Upd_Proyect.Margin = new Padding(3, 4, 3, 4);
            Btn_Upd_Proyect.Name = "Btn_Upd_Proyect";
            Btn_Upd_Proyect.Size = new Size(234, 60);
            Btn_Upd_Proyect.TabIndex = 6;
            Btn_Upd_Proyect.Text = "Modificar Proyecto";
            Btn_Upd_Proyect.UseVisualStyleBackColor = false;
            Btn_Upd_Proyect.Click += Btn_Upd_Proyect_Click;
            // 
            // Pnl_Space1
            // 
            Pnl_Space1.Dock = DockStyle.Top;
            Pnl_Space1.Location = new Point(0, 93);
            Pnl_Space1.Margin = new Padding(3, 4, 3, 4);
            Pnl_Space1.Name = "Pnl_Space1";
            Pnl_Space1.Size = new Size(234, 27);
            Pnl_Space1.TabIndex = 5;
            // 
            // Btn_Act
            // 
            Btn_Act.BackColor = Color.DarkRed;
            Btn_Act.Cursor = Cursors.Hand;
            Btn_Act.Dock = DockStyle.Bottom;
            Btn_Act.Font = new Font("Segoe UI", 11F);
            Btn_Act.ForeColor = Color.White;
            Btn_Act.Location = new Point(0, 400);
            Btn_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_Act.Name = "Btn_Act";
            Btn_Act.Size = new Size(234, 60);
            Btn_Act.TabIndex = 3;
            Btn_Act.Text = "Actividades del Proyecto";
            Btn_Act.UseVisualStyleBackColor = false;
            Btn_Act.Click += Btn_Act_Click;
            // 
            // Btn_Add_Proyect
            // 
            Btn_Add_Proyect.AutoSize = true;
            Btn_Add_Proyect.BackColor = Color.Green;
            Btn_Add_Proyect.Cursor = Cursors.Hand;
            Btn_Add_Proyect.Dock = DockStyle.Top;
            Btn_Add_Proyect.Font = new Font("Segoe UI", 11F);
            Btn_Add_Proyect.ForeColor = Color.White;
            Btn_Add_Proyect.Location = new Point(0, 33);
            Btn_Add_Proyect.Margin = new Padding(0, 7, 0, 7);
            Btn_Add_Proyect.Name = "Btn_Add_Proyect";
            Btn_Add_Proyect.Size = new Size(234, 60);
            Btn_Add_Proyect.TabIndex = 0;
            Btn_Add_Proyect.Text = "Agregar Nuevo Proyecto";
            Btn_Add_Proyect.UseVisualStyleBackColor = false;
            Btn_Add_Proyect.Click += Btn_Add_Proyect_Click;
            // 
            // Pnl_Filtros
            // 
            Pnl_Filtros.BackColor = Color.White;
            Pnl_Filtros.Controls.Add(FiltroFecha1);
            Pnl_Filtros.Controls.Add(BFiltrarFecha);
            Pnl_Filtros.Controls.Add(FiltroFecha2);
            Pnl_Filtros.Controls.Add(Lbl_Filtro2_Proyect);
            Pnl_Filtros.Controls.Add(Lbl_Filtro1_Proyect);
            Pnl_Filtros.Dock = DockStyle.Top;
            Pnl_Filtros.Location = new Point(0, 0);
            Pnl_Filtros.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtros.Name = "Pnl_Filtros";
            Pnl_Filtros.Padding = new Padding(51, 27, 0, 27);
            Pnl_Filtros.Size = new Size(914, 80);
            Pnl_Filtros.TabIndex = 0;
            // 
            // FiltroFecha1
            // 
            FiltroFecha1.Location = new Point(173, 25);
            FiltroFecha1.Name = "FiltroFecha1";
            FiltroFecha1.Size = new Size(250, 27);
            FiltroFecha1.TabIndex = 5;
            // 
            // BFiltrarFecha
            // 
            BFiltrarFecha.BackColor = Color.FromArgb(25, 29, 42);
            BFiltrarFecha.Font = new Font("Segoe UI", 11F);
            BFiltrarFecha.ForeColor = SystemColors.Control;
            BFiltrarFecha.Location = new Point(769, 17);
            BFiltrarFecha.Name = "BFiltrarFecha";
            BFiltrarFecha.Size = new Size(97, 39);
            BFiltrarFecha.TabIndex = 4;
            BFiltrarFecha.Text = "Filtrar";
            BFiltrarFecha.UseVisualStyleBackColor = false;
            BFiltrarFecha.Click += BFiltrarFecha_Click;
            // 
            // FiltroFecha2
            // 
            FiltroFecha2.Location = new Point(498, 25);
            FiltroFecha2.Name = "FiltroFecha2";
            FiltroFecha2.Size = new Size(250, 27);
            FiltroFecha2.TabIndex = 2;
            // 
            // Lbl_Filtro2_Proyect
            // 
            Lbl_Filtro2_Proyect.AutoSize = true;
            Lbl_Filtro2_Proyect.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro2_Proyect.Location = new Point(429, 24);
            Lbl_Filtro2_Proyect.Name = "Lbl_Filtro2_Proyect";
            Lbl_Filtro2_Proyect.Size = new Size(63, 25);
            Lbl_Filtro2_Proyect.TabIndex = 1;
            Lbl_Filtro2_Proyect.Text = "Hasta:";
            // 
            // Lbl_Filtro1_Proyect
            // 
            Lbl_Filtro1_Proyect.AutoSize = true;
            Lbl_Filtro1_Proyect.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro1_Proyect.Location = new Point(51, 27);
            Lbl_Filtro1_Proyect.Name = "Lbl_Filtro1_Proyect";
            Lbl_Filtro1_Proyect.Size = new Size(122, 25);
            Lbl_Filtro1_Proyect.TabIndex = 0;
            Lbl_Filtro1_Proyect.Text = "Filtrar Desde:";
            // 
            // V_Proyect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Proyect);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Proyect";
            Text = "V_Proyect";
            Pnl_Proyect.ResumeLayout(false);
            Pnl_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Tabla_Proyect).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Buttons.PerformLayout();
            Pnl_Filtros.ResumeLayout(false);
            Pnl_Filtros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Proyect;
        private Panel Pnl_Filtros;
        private Label Lbl_Filtro2_Proyect;
        private Label Lbl_Filtro1_Proyect;
        private Panel Pnl_Table;
        private DataGridView DGV_Tabla_Proyect;
        private Panel Pnl_Buttons;
        private Button Btn_Hist_Proyect;
        private Panel Pnl_Space3;
        private Button Btn_FPC_Proyect;
        private Panel Pnl_Space2;
        private Button Btn_Upd_Proyect;
        private Panel Pnl_Space1;
        private Button Btn_Act;
        private Button Btn_Add_Proyect;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker FiltroFecha2;
        private Button BFiltrarFecha;
        private DateTimePicker FiltroFecha1;
    }
}