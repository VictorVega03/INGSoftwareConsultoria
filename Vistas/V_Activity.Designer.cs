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
            DGV_Table_Act = new DataGridView();
            Pnl_Buttons = new Panel();
            Btn_FPC_Act = new Button();
            Pnl_Space2 = new Panel();
            Btn_Upd_Act = new Button();
            Pnl_Space1 = new Panel();
            Btn_Hist_Act = new Button();
            Btn_Add_Act = new Button();
            Pnl_Filtro = new Panel();
            CmB_Filtro_Act = new ComboBox();
            Lbl_Filtro_Act = new Label();
            Pnl_Act.SuspendLayout();
            Pnl_Table_Act.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Act).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtro.SuspendLayout();
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
            Pnl_Table_Act.Controls.Add(DGV_Table_Act);
            Pnl_Table_Act.Dock = DockStyle.Fill;
            Pnl_Table_Act.Location = new Point(0, 80);
            Pnl_Table_Act.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Act.Name = "Pnl_Table_Act";
            Pnl_Table_Act.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Act.Size = new Size(657, 520);
            Pnl_Table_Act.TabIndex = 7;
            // 
            // DGV_Table_Act
            // 
            DGV_Table_Act.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Table_Act.Dock = DockStyle.Fill;
            DGV_Table_Act.Location = new Point(51, 33);
            DGV_Table_Act.Margin = new Padding(3, 4, 3, 4);
            DGV_Table_Act.Name = "DGV_Table_Act";
            DGV_Table_Act.RowHeadersWidth = 51;
            DGV_Table_Act.Size = new Size(572, 427);
            DGV_Table_Act.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(Btn_FPC_Act);
            Pnl_Buttons.Controls.Add(Pnl_Space2);
            Pnl_Buttons.Controls.Add(Btn_Upd_Act);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(Btn_Hist_Act);
            Pnl_Buttons.Controls.Add(Btn_Add_Act);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 6;
            // 
            // Btn_FPC_Act
            // 
            Btn_FPC_Act.Dock = DockStyle.Top;
            Btn_FPC_Act.Font = new Font("Segoe UI", 10F);
            Btn_FPC_Act.Location = new Point(0, 207);
            Btn_FPC_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_FPC_Act.Name = "Btn_FPC_Act";
            Btn_FPC_Act.Size = new Size(234, 60);
            Btn_FPC_Act.TabIndex = 9;
            Btn_FPC_Act.Text = "Finalizar/Pausar/Cancelar";
            Btn_FPC_Act.UseVisualStyleBackColor = true;
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
            // Btn_Upd_Act
            // 
            Btn_Upd_Act.Dock = DockStyle.Top;
            Btn_Upd_Act.Font = new Font("Segoe UI", 11F);
            Btn_Upd_Act.Location = new Point(0, 120);
            Btn_Upd_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_Upd_Act.Name = "Btn_Upd_Act";
            Btn_Upd_Act.Size = new Size(234, 60);
            Btn_Upd_Act.TabIndex = 7;
            Btn_Upd_Act.Text = "Modificar Actividad";
            Btn_Upd_Act.UseVisualStyleBackColor = true;
            Btn_Upd_Act.Click += Btn_Upd_Act_Click;
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
            Btn_Hist_Act.Dock = DockStyle.Bottom;
            Btn_Hist_Act.Font = new Font("Segoe UI", 11F);
            Btn_Hist_Act.Location = new Point(0, 400);
            Btn_Hist_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_Hist_Act.Name = "Btn_Hist_Act";
            Btn_Hist_Act.Size = new Size(234, 60);
            Btn_Hist_Act.TabIndex = 3;
            Btn_Hist_Act.Text = "Historial de Actividades";
            Btn_Hist_Act.UseVisualStyleBackColor = true;
            Btn_Hist_Act.Click += Btn_Hist_Act_Click;
            // 
            // Btn_Add_Act
            // 
            Btn_Add_Act.Dock = DockStyle.Top;
            Btn_Add_Act.Font = new Font("Segoe UI", 11F);
            Btn_Add_Act.Location = new Point(0, 33);
            Btn_Add_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_Add_Act.Name = "Btn_Add_Act";
            Btn_Add_Act.Size = new Size(234, 60);
            Btn_Add_Act.TabIndex = 0;
            Btn_Add_Act.Text = "Añadir Nueva Actividad";
            Btn_Add_Act.UseVisualStyleBackColor = true;
            Btn_Add_Act.Click += Btn_Add_Act_Click;
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.Controls.Add(CmB_Filtro_Act);
            Pnl_Filtro.Controls.Add(Lbl_Filtro_Act);
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(914, 80);
            Pnl_Filtro.TabIndex = 3;
            // 
            // CmB_Filtro_Act
            // 
            CmB_Filtro_Act.Font = new Font("Segoe UI", 11F);
            CmB_Filtro_Act.FormattingEnabled = true;
            CmB_Filtro_Act.Location = new Point(154, 20);
            CmB_Filtro_Act.Margin = new Padding(3, 4, 3, 4);
            CmB_Filtro_Act.Name = "CmB_Filtro_Act";
            CmB_Filtro_Act.Size = new Size(199, 33);
            CmB_Filtro_Act.TabIndex = 3;
            // 
            // Lbl_Filtro_Act
            // 
            Lbl_Filtro_Act.AutoSize = true;
            Lbl_Filtro_Act.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro_Act.Location = new Point(51, 27);
            Lbl_Filtro_Act.Name = "Lbl_Filtro_Act";
            Lbl_Filtro_Act.Size = new Size(99, 25);
            Lbl_Filtro_Act.TabIndex = 2;
            Lbl_Filtro_Act.Text = "Filtrar por:";
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
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Act).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Filtro.ResumeLayout(false);
            Pnl_Filtro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Act;
        private Panel Pnl_Filtro;
        private ComboBox CmB_Filtro_Act;
        private Label Lbl_Filtro_Act;
        private Panel Pnl_Table_Act;
        private DataGridView DGV_Table_Act;
        private Panel Pnl_Buttons;
        private Button Btn_Hist_Act;
        private Button Btn_Add_Act;
        private Button Btn_Upd_Act;
        private Panel Pnl_Space1;
        private Button Btn_FPC_Act;
        private Panel Pnl_Space2;
    }
}