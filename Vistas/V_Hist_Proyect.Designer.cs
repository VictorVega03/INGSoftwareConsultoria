namespace Vistas
{
    partial class V_Hist_Proyect
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
            Pnl_Hist_Proyect = new Panel();
            Pnl_Table_Hist_Proyect = new Panel();
            TablaHistProyect = new DataGridView();
            Pnl_Buttons = new Panel();
            Bnota = new Button();
            Pnl_Space1 = new Panel();
            BverProyecto = new Button();
            Pnl_Filtros = new Panel();
            FiltroFecha1 = new DateTimePicker();
            BFiltrarFecha = new Button();
            FiltroFecha2 = new DateTimePicker();
            Lbl_Filtro2_Proyect = new Label();
            Lbl_Filtro1_Proyect = new Label();
            Pnl_Hist_Proyect.SuspendLayout();
            Pnl_Table_Hist_Proyect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaHistProyect).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtros.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Hist_Proyect
            // 
            Pnl_Hist_Proyect.Controls.Add(Pnl_Table_Hist_Proyect);
            Pnl_Hist_Proyect.Controls.Add(Pnl_Buttons);
            Pnl_Hist_Proyect.Controls.Add(Pnl_Filtros);
            Pnl_Hist_Proyect.Dock = DockStyle.Fill;
            Pnl_Hist_Proyect.Location = new Point(0, 0);
            Pnl_Hist_Proyect.Margin = new Padding(3, 4, 3, 4);
            Pnl_Hist_Proyect.Name = "Pnl_Hist_Proyect";
            Pnl_Hist_Proyect.Size = new Size(914, 600);
            Pnl_Hist_Proyect.TabIndex = 0;
            // 
            // Pnl_Table_Hist_Proyect
            // 
            Pnl_Table_Hist_Proyect.AutoSize = true;
            Pnl_Table_Hist_Proyect.BackColor = Color.White;
            Pnl_Table_Hist_Proyect.Controls.Add(TablaHistProyect);
            Pnl_Table_Hist_Proyect.Dock = DockStyle.Fill;
            Pnl_Table_Hist_Proyect.Location = new Point(0, 80);
            Pnl_Table_Hist_Proyect.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Hist_Proyect.Name = "Pnl_Table_Hist_Proyect";
            Pnl_Table_Hist_Proyect.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Hist_Proyect.Size = new Size(657, 520);
            Pnl_Table_Hist_Proyect.TabIndex = 1;
            // 
            // TablaHistProyect
            // 
            TablaHistProyect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaHistProyect.Dock = DockStyle.Fill;
            TablaHistProyect.Location = new Point(51, 33);
            TablaHistProyect.Margin = new Padding(3, 4, 3, 4);
            TablaHistProyect.Name = "TablaHistProyect";
            TablaHistProyect.RowHeadersWidth = 51;
            TablaHistProyect.Size = new Size(572, 427);
            TablaHistProyect.TabIndex = 0;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Bnota);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(BverProyecto);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 40, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 2;
            // 
            // Bnota
            // 
            Bnota.BackColor = Color.DarkRed;
            Bnota.Cursor = Cursors.Hand;
            Bnota.Dock = DockStyle.Top;
            Bnota.Font = new Font("Segoe UI", 11F);
            Bnota.ForeColor = Color.White;
            Bnota.Location = new Point(0, 127);
            Bnota.Margin = new Padding(3, 4, 3, 4);
            Bnota.Name = "Bnota";
            Bnota.Size = new Size(234, 60);
            Bnota.TabIndex = 7;
            Bnota.Text = "Ver Nota";
            Bnota.UseVisualStyleBackColor = false;
            Bnota.Click += Bnota_Click;
            // 
            // Pnl_Space1
            // 
            Pnl_Space1.Dock = DockStyle.Top;
            Pnl_Space1.Location = new Point(0, 100);
            Pnl_Space1.Margin = new Padding(3, 4, 3, 4);
            Pnl_Space1.Name = "Pnl_Space1";
            Pnl_Space1.Size = new Size(234, 27);
            Pnl_Space1.TabIndex = 6;
            // 
            // BverProyecto
            // 
            BverProyecto.BackColor = Color.Green;
            BverProyecto.Cursor = Cursors.Hand;
            BverProyecto.Dock = DockStyle.Top;
            BverProyecto.Font = new Font("Segoe UI", 11F);
            BverProyecto.ForeColor = Color.White;
            BverProyecto.Location = new Point(0, 40);
            BverProyecto.Margin = new Padding(3, 4, 3, 4);
            BverProyecto.Name = "BverProyecto";
            BverProyecto.Size = new Size(234, 60);
            BverProyecto.TabIndex = 0;
            BverProyecto.Text = "Detalles del Proyecto";
            BverProyecto.UseVisualStyleBackColor = false;
            BverProyecto.Click += BverProyecto_Click;
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
            Pnl_Filtros.Size = new Size(914, 80);
            Pnl_Filtros.TabIndex = 0;
            // 
            // FiltroFecha1
            // 
            FiltroFecha1.Location = new Point(172, 26);
            FiltroFecha1.Name = "FiltroFecha1";
            FiltroFecha1.Size = new Size(250, 27);
            FiltroFecha1.TabIndex = 10;
            // 
            // BFiltrarFecha
            // 
            BFiltrarFecha.BackColor = Color.FromArgb(25, 29, 42);
            BFiltrarFecha.Font = new Font("Segoe UI", 11F);
            BFiltrarFecha.ForeColor = SystemColors.Control;
            BFiltrarFecha.Location = new Point(768, 18);
            BFiltrarFecha.Name = "BFiltrarFecha";
            BFiltrarFecha.Size = new Size(97, 39);
            BFiltrarFecha.TabIndex = 9;
            BFiltrarFecha.Text = "Filtrar";
            BFiltrarFecha.UseVisualStyleBackColor = false;
            BFiltrarFecha.Click += BFiltrarFecha_Click;
            // 
            // FiltroFecha2
            // 
            FiltroFecha2.Location = new Point(497, 25);
            FiltroFecha2.Name = "FiltroFecha2";
            FiltroFecha2.Size = new Size(250, 27);
            FiltroFecha2.TabIndex = 8;
            // 
            // Lbl_Filtro2_Proyect
            // 
            Lbl_Filtro2_Proyect.AutoSize = true;
            Lbl_Filtro2_Proyect.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro2_Proyect.Location = new Point(428, 25);
            Lbl_Filtro2_Proyect.Name = "Lbl_Filtro2_Proyect";
            Lbl_Filtro2_Proyect.Size = new Size(63, 25);
            Lbl_Filtro2_Proyect.TabIndex = 7;
            Lbl_Filtro2_Proyect.Text = "Hasta:";
            // 
            // Lbl_Filtro1_Proyect
            // 
            Lbl_Filtro1_Proyect.AutoSize = true;
            Lbl_Filtro1_Proyect.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro1_Proyect.Location = new Point(50, 28);
            Lbl_Filtro1_Proyect.Name = "Lbl_Filtro1_Proyect";
            Lbl_Filtro1_Proyect.Size = new Size(122, 25);
            Lbl_Filtro1_Proyect.TabIndex = 6;
            Lbl_Filtro1_Proyect.Text = "Filtrar Desde:";
            // 
            // V_Hist_Proyect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Hist_Proyect);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Hist_Proyect";
            Text = "V_Hist_Proyect";
            Pnl_Hist_Proyect.ResumeLayout(false);
            Pnl_Hist_Proyect.PerformLayout();
            Pnl_Table_Hist_Proyect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaHistProyect).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Filtros.ResumeLayout(false);
            Pnl_Filtros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Hist_Proyect;
        private Panel Pnl_Table_Hist_Proyect;
        private Panel Pnl_Filtros;
        private DataGridView TablaHistProyect;
        private Panel Pnl_Buttons;
        private Button BverProyecto;
        private Button Bnota;
        private Panel Pnl_Space1;
        private DateTimePicker FiltroFecha1;
        private Button BFiltrarFecha;
        private DateTimePicker FiltroFecha2;
        private Label Lbl_Filtro2_Proyect;
        private Label Lbl_Filtro1_Proyect;
    }
}