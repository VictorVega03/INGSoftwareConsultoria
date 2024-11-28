namespace Vistas
{
    partial class V_Hist_Act
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
            Pnl_Hist_Act = new Panel();
            Pnl_Table_Hist_Proyect = new Panel();
            TablaHistAct = new DataGridView();
            Pnl_Buttons = new Panel();
            Bnota = new Button();
            Pnl_Space1 = new Panel();
            BverActividad = new Button();
            Pnl_Filtros = new Panel();
            Pnl_Hist_Act.SuspendLayout();
            Pnl_Table_Hist_Proyect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaHistAct).BeginInit();
            Pnl_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Hist_Act
            // 
            Pnl_Hist_Act.Controls.Add(Pnl_Table_Hist_Proyect);
            Pnl_Hist_Act.Controls.Add(Pnl_Buttons);
            Pnl_Hist_Act.Controls.Add(Pnl_Filtros);
            Pnl_Hist_Act.Dock = DockStyle.Fill;
            Pnl_Hist_Act.Location = new Point(0, 0);
            Pnl_Hist_Act.Margin = new Padding(4, 5, 4, 5);
            Pnl_Hist_Act.Name = "Pnl_Hist_Act";
            Pnl_Hist_Act.Size = new Size(1142, 750);
            Pnl_Hist_Act.TabIndex = 1;
            // 
            // Pnl_Table_Hist_Proyect
            // 
            Pnl_Table_Hist_Proyect.AutoSize = true;
            Pnl_Table_Hist_Proyect.BackColor = Color.White;
            Pnl_Table_Hist_Proyect.Controls.Add(TablaHistAct);
            Pnl_Table_Hist_Proyect.Dock = DockStyle.Fill;
            Pnl_Table_Hist_Proyect.Location = new Point(0, 100);
            Pnl_Table_Hist_Proyect.Margin = new Padding(4, 5, 4, 5);
            Pnl_Table_Hist_Proyect.Name = "Pnl_Table_Hist_Proyect";
            Pnl_Table_Hist_Proyect.Padding = new Padding(64, 41, 42, 75);
            Pnl_Table_Hist_Proyect.Size = new Size(821, 650);
            Pnl_Table_Hist_Proyect.TabIndex = 4;
            // 
            // TablaHistAct
            // 
            TablaHistAct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaHistAct.Dock = DockStyle.Fill;
            TablaHistAct.Location = new Point(64, 41);
            TablaHistAct.Margin = new Padding(4, 5, 4, 5);
            TablaHistAct.Name = "TablaHistAct";
            TablaHistAct.RowHeadersWidth = 51;
            TablaHistAct.Size = new Size(715, 534);
            TablaHistAct.TabIndex = 0;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Bnota);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(BverActividad);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(821, 100);
            Pnl_Buttons.Margin = new Padding(4, 5, 4, 5);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 50, 29, 75);
            Pnl_Buttons.Size = new Size(321, 650);
            Pnl_Buttons.TabIndex = 3;
            // 
            // Bnota
            // 
            Bnota.BackColor = Color.DarkRed;
            Bnota.Cursor = Cursors.Hand;
            Bnota.Dock = DockStyle.Top;
            Bnota.Font = new Font("Segoe UI", 11F);
            Bnota.ForeColor = Color.White;
            Bnota.Location = new Point(0, 159);
            Bnota.Margin = new Padding(4, 5, 4, 5);
            Bnota.Name = "Bnota";
            Bnota.Size = new Size(292, 75);
            Bnota.TabIndex = 7;
            Bnota.Text = "Ver Notas de Actividad";
            Bnota.UseVisualStyleBackColor = false;
            // 
            // Pnl_Space1
            // 
            Pnl_Space1.Dock = DockStyle.Top;
            Pnl_Space1.Location = new Point(0, 125);
            Pnl_Space1.Margin = new Padding(4, 5, 4, 5);
            Pnl_Space1.Name = "Pnl_Space1";
            Pnl_Space1.Size = new Size(292, 34);
            Pnl_Space1.TabIndex = 6;
            // 
            // BverActividad
            // 
            BverActividad.BackColor = Color.Green;
            BverActividad.Cursor = Cursors.Hand;
            BverActividad.Dock = DockStyle.Top;
            BverActividad.Font = new Font("Segoe UI", 11F);
            BverActividad.ForeColor = Color.White;
            BverActividad.Location = new Point(0, 50);
            BverActividad.Margin = new Padding(4, 5, 4, 5);
            BverActividad.Name = "BverActividad";
            BverActividad.Size = new Size(292, 75);
            BverActividad.TabIndex = 0;
            BverActividad.Text = "Detalles de Actividad";
            BverActividad.UseVisualStyleBackColor = false;
            BverActividad.Click += BverActividad_Click;
            // 
            // Pnl_Filtros
            // 
            Pnl_Filtros.BackColor = Color.White;
            Pnl_Filtros.Dock = DockStyle.Top;
            Pnl_Filtros.Location = new Point(0, 0);
            Pnl_Filtros.Margin = new Padding(4, 5, 4, 5);
            Pnl_Filtros.Name = "Pnl_Filtros";
            Pnl_Filtros.Size = new Size(1142, 100);
            Pnl_Filtros.TabIndex = 0;
            // 
            // V_Hist_Act
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(Pnl_Hist_Act);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "V_Hist_Act";
            Text = "V_Hist_Act";
            Pnl_Hist_Act.ResumeLayout(false);
            Pnl_Hist_Act.PerformLayout();
            Pnl_Table_Hist_Proyect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaHistAct).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Hist_Act;
        private Panel Pnl_Filtros;
        private Panel Pnl_Buttons;
        private Button Bnota;
        private Panel Pnl_Space1;
        private Button BverActividad;
        private Panel Pnl_Table_Hist_Proyect;
        private DataGridView TablaHistAct;
    }
}