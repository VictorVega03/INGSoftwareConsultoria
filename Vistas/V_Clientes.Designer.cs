namespace Vistas
{
    partial class V_Clientes
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
            Pnl_Client = new Panel();
            Pnl_Table_Client = new Panel();
            DGV_Table_Client = new DataGridView();
            Pnl_Buttons = new Panel();
            Btn_Eliminar_Client = new Button();
            Pnl_Space2 = new Panel();
            Btn_Upd_Client = new Button();
            Pnl_Space1 = new Panel();
            Btn_Add_Client = new Button();
            Pnl_Filtro = new Panel();
            CmB_Filtro_Client = new ComboBox();
            Lbl_Filtro_Client = new Label();
            Pnl_Client.SuspendLayout();
            Pnl_Table_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Client).BeginInit();
            Pnl_Buttons.SuspendLayout();
            Pnl_Filtro.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Client
            // 
            Pnl_Client.AutoSize = true;
            Pnl_Client.Controls.Add(Pnl_Table_Client);
            Pnl_Client.Controls.Add(Pnl_Buttons);
            Pnl_Client.Controls.Add(Pnl_Filtro);
            Pnl_Client.Dock = DockStyle.Fill;
            Pnl_Client.Location = new Point(0, 0);
            Pnl_Client.Margin = new Padding(3, 4, 3, 4);
            Pnl_Client.Name = "Pnl_Client";
            Pnl_Client.Size = new Size(914, 600);
            Pnl_Client.TabIndex = 1;
            // 
            // Pnl_Table_Client
            // 
            Pnl_Table_Client.AutoSize = true;
            Pnl_Table_Client.Controls.Add(DGV_Table_Client);
            Pnl_Table_Client.Dock = DockStyle.Fill;
            Pnl_Table_Client.Location = new Point(0, 80);
            Pnl_Table_Client.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Client.Name = "Pnl_Table_Client";
            Pnl_Table_Client.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Client.Size = new Size(657, 520);
            Pnl_Table_Client.TabIndex = 7;
            // 
            // DGV_Table_Client
            // 
            DGV_Table_Client.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Table_Client.Dock = DockStyle.Fill;
            DGV_Table_Client.Location = new Point(51, 33);
            DGV_Table_Client.Margin = new Padding(3, 4, 3, 4);
            DGV_Table_Client.Name = "DGV_Table_Client";
            DGV_Table_Client.RowHeadersWidth = 51;
            DGV_Table_Client.Size = new Size(572, 427);
            DGV_Table_Client.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(Btn_Eliminar_Client);
            Pnl_Buttons.Controls.Add(Pnl_Space2);
            Pnl_Buttons.Controls.Add(Btn_Upd_Client);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(Btn_Add_Client);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 6;
            // 
            // Btn_Eliminar_Client
            // 
            Btn_Eliminar_Client.Dock = DockStyle.Top;
            Btn_Eliminar_Client.Font = new Font("Segoe UI", 11F);
            Btn_Eliminar_Client.Location = new Point(0, 207);
            Btn_Eliminar_Client.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Client.Name = "Btn_Eliminar_Client";
            Btn_Eliminar_Client.Size = new Size(234, 60);
            Btn_Eliminar_Client.TabIndex = 9;
            Btn_Eliminar_Client.Text = "Eliminar Cliente";
            Btn_Eliminar_Client.UseVisualStyleBackColor = true;
            Btn_Eliminar_Client.Click += Btn_Eliminar_Client_Click;
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
            // Btn_Upd_Client
            // 
            Btn_Upd_Client.Dock = DockStyle.Top;
            Btn_Upd_Client.Font = new Font("Segoe UI", 11F);
            Btn_Upd_Client.Location = new Point(0, 120);
            Btn_Upd_Client.Margin = new Padding(3, 4, 3, 4);
            Btn_Upd_Client.Name = "Btn_Upd_Client";
            Btn_Upd_Client.Size = new Size(234, 60);
            Btn_Upd_Client.TabIndex = 7;
            Btn_Upd_Client.Text = "Modificar Cliente";
            Btn_Upd_Client.UseVisualStyleBackColor = true;
            Btn_Upd_Client.Click += Btn_Upd_Client_Click;
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
            // Btn_Add_Client
            // 
            Btn_Add_Client.Dock = DockStyle.Top;
            Btn_Add_Client.Font = new Font("Segoe UI", 11F);
            Btn_Add_Client.Location = new Point(0, 33);
            Btn_Add_Client.Margin = new Padding(3, 4, 3, 4);
            Btn_Add_Client.Name = "Btn_Add_Client";
            Btn_Add_Client.Size = new Size(234, 60);
            Btn_Add_Client.TabIndex = 0;
            Btn_Add_Client.Text = "Añadir Nuevo Cliente";
            Btn_Add_Client.UseVisualStyleBackColor = true;
            Btn_Add_Client.Click += Btn_Add_Client_Click;
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.Controls.Add(CmB_Filtro_Client);
            Pnl_Filtro.Controls.Add(Lbl_Filtro_Client);
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(914, 80);
            Pnl_Filtro.TabIndex = 3;
            // 
            // CmB_Filtro_Client
            // 
            CmB_Filtro_Client.Font = new Font("Segoe UI", 11F);
            CmB_Filtro_Client.FormattingEnabled = true;
            CmB_Filtro_Client.Location = new Point(154, 20);
            CmB_Filtro_Client.Margin = new Padding(3, 4, 3, 4);
            CmB_Filtro_Client.Name = "CmB_Filtro_Client";
            CmB_Filtro_Client.Size = new Size(199, 33);
            CmB_Filtro_Client.TabIndex = 3;
            // 
            // Lbl_Filtro_Client
            // 
            Lbl_Filtro_Client.AutoSize = true;
            Lbl_Filtro_Client.Font = new Font("Segoe UI", 11F);
            Lbl_Filtro_Client.Location = new Point(51, 27);
            Lbl_Filtro_Client.Name = "Lbl_Filtro_Client";
            Lbl_Filtro_Client.Size = new Size(99, 25);
            Lbl_Filtro_Client.TabIndex = 2;
            Lbl_Filtro_Client.Text = "Filtrar por:";
            // 
            // V_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Pnl_Client);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Clientes";
            Text = "V_Clientes";
            Pnl_Client.ResumeLayout(false);
            Pnl_Client.PerformLayout();
            Pnl_Table_Client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Client).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Filtro.ResumeLayout(false);
            Pnl_Filtro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Client;
        private Panel Pnl_Filtro;
        private ComboBox CmB_Filtro_Client;
        private Label Lbl_Filtro_Client;
        private Panel Pnl_Table_Client;
        private DataGridView DGV_Table_Client;
        private Panel Pnl_Buttons;
        private Button Btn_Add_Client;
        private Button Btn_Upd_Client;
        private Panel Pnl_Space1;
        private Button Btn_Eliminar_Client;
        private Panel Pnl_Space2;
    }
}