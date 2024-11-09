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
            Pnl_Table_Hist_Act = new Panel();
            DGV_Table_Hist_Act = new DataGridView();
            Pnl_Buttons = new Panel();
            Btn_Activar = new Button();
            Pnl_Filtros = new Panel();
            CmB_Filtro1_Hist_Act = new ComboBox();
            Lbl_Filtro_Hist_Act = new Label();
            Pnl_Hist_Act.SuspendLayout();
            Pnl_Table_Hist_Act.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Hist_Act).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtros.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Hist_Act
            // 
            Pnl_Hist_Act.Controls.Add(Pnl_Table_Hist_Act);
            Pnl_Hist_Act.Controls.Add(Pnl_Buttons);
            Pnl_Hist_Act.Controls.Add(Pnl_Filtros);
            Pnl_Hist_Act.Dock = DockStyle.Fill;
            Pnl_Hist_Act.Location = new Point(0, 0);
            Pnl_Hist_Act.Name = "Pnl_Hist_Act";
            Pnl_Hist_Act.Size = new Size(800, 450);
            Pnl_Hist_Act.TabIndex = 1;
            // 
            // Pnl_Table_Hist_Act
            // 
            Pnl_Table_Hist_Act.AutoSize = true;
            Pnl_Table_Hist_Act.Controls.Add(DGV_Table_Hist_Act);
            Pnl_Table_Hist_Act.Dock = DockStyle.Fill;
            Pnl_Table_Hist_Act.Location = new Point(0, 60);
            Pnl_Table_Hist_Act.Name = "Pnl_Table_Hist_Act";
            Pnl_Table_Hist_Act.Padding = new Padding(45, 25, 30, 45);
            Pnl_Table_Hist_Act.Size = new Size(575, 390);
            Pnl_Table_Hist_Act.TabIndex = 1;
            // 
            // DGV_Table_Hist_Act
            // 
            DGV_Table_Hist_Act.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Table_Hist_Act.Dock = DockStyle.Fill;
            DGV_Table_Hist_Act.Location = new Point(45, 25);
            DGV_Table_Hist_Act.Name = "DGV_Table_Hist_Act";
            DGV_Table_Hist_Act.Size = new Size(500, 320);
            DGV_Table_Hist_Act.TabIndex = 0;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(Btn_Activar);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(575, 60);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 30, 20, 45);
            Pnl_Buttons.Size = new Size(225, 390);
            Pnl_Buttons.TabIndex = 2;
            // 
            // Btn_Activar
            // 
            Btn_Activar.Dock = DockStyle.Top;
            Btn_Activar.Font = new Font("Segoe UI", 11F);
            Btn_Activar.Location = new Point(0, 30);
            Btn_Activar.Name = "Btn_Activar";
            Btn_Activar.Size = new Size(205, 45);
            Btn_Activar.TabIndex = 0;
            Btn_Activar.Text = "Reaunudar Actividad";
            Btn_Activar.UseVisualStyleBackColor = true;
            // 
            // Pnl_Filtros
            // 
            Pnl_Filtros.Controls.Add(CmB_Filtro1_Hist_Act);
            Pnl_Filtros.Controls.Add(Lbl_Filtro_Hist_Act);
            Pnl_Filtros.Dock = DockStyle.Top;
            Pnl_Filtros.Location = new Point(0, 0);
            Pnl_Filtros.Name = "Pnl_Filtros";
            Pnl_Filtros.Size = new Size(800, 60);
            Pnl_Filtros.TabIndex = 0;
            // 
            // CmB_Filtro1_Hist_Act
            // 
            CmB_Filtro1_Hist_Act.Font = new Font("Segoe UI", 11F);
            CmB_Filtro1_Hist_Act.FormattingEnabled = true;
            CmB_Filtro1_Hist_Act.Location = new Point(135, 15);
            CmB_Filtro1_Hist_Act.Name = "CmB_Filtro1_Hist_Act";
            CmB_Filtro1_Hist_Act.Size = new Size(175, 28);
            CmB_Filtro1_Hist_Act.TabIndex = 1;
            // 
            // Lbl_Filtro_Hist_Act
            // 
            Lbl_Filtro_Hist_Act.AutoSize = true;
            Lbl_Filtro_Hist_Act.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro_Hist_Act.Location = new Point(45, 20);
            Lbl_Filtro_Hist_Act.Name = "Lbl_Filtro_Hist_Act";
            Lbl_Filtro_Hist_Act.Size = new Size(77, 20);
            Lbl_Filtro_Hist_Act.TabIndex = 0;
            Lbl_Filtro_Hist_Act.Text = "Filtrar por:";
            // 
            // V_Hist_Act
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pnl_Hist_Act);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Hist_Act";
            Text = "V_Hist_Act";
            Pnl_Hist_Act.ResumeLayout(false);
            Pnl_Hist_Act.PerformLayout();
            Pnl_Table_Hist_Act.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Hist_Act).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Filtros.ResumeLayout(false);
            Pnl_Filtros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Hist_Act;
        private Panel Pnl_Table_Hist_Act;
        private DataGridView DGV_Table_Hist_Act;
        private Panel Pnl_Buttons;
        private Button Btn_Activar;
        private Panel Pnl_Filtros;
        private ComboBox CmB_Filtro1_Hist_Act;
        private Label Lbl_Filtro_Hist_Act;
    }
}