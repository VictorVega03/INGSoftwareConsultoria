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
            Pnl_Table_Prov = new Panel();
            DGV_Table_Client = new DataGridView();
            Pnl_Buttons = new Panel();
            BclientesRemoved = new Button();
            Btn_EliminarClient = new Button();
            panel1 = new Panel();
            Btn_Upd_Cliente = new Button();
            Pnl_Space1 = new Panel();
            Btn_Add_Client = new Button();
            Pnl_Filtro = new Panel();
            Pnl_Client.SuspendLayout();
            Pnl_Table_Prov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Client).BeginInit();
            Pnl_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Client
            // 
            Pnl_Client.AutoSize = true;
            Pnl_Client.Controls.Add(Pnl_Table_Prov);
            Pnl_Client.Controls.Add(Pnl_Buttons);
            Pnl_Client.Controls.Add(Pnl_Filtro);
            Pnl_Client.Dock = DockStyle.Fill;
            Pnl_Client.Location = new Point(0, 0);
            Pnl_Client.Margin = new Padding(3, 4, 3, 4);
            Pnl_Client.Name = "Pnl_Client";
            Pnl_Client.Size = new Size(914, 600);
            Pnl_Client.TabIndex = 1;
            // 
            // Pnl_Table_Prov
            // 
            Pnl_Table_Prov.AutoSize = true;
            Pnl_Table_Prov.BackColor = Color.White;
            Pnl_Table_Prov.Controls.Add(DGV_Table_Client);
            Pnl_Table_Prov.Dock = DockStyle.Fill;
            Pnl_Table_Prov.Location = new Point(0, 80);
            Pnl_Table_Prov.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Prov.Name = "Pnl_Table_Prov";
            Pnl_Table_Prov.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Prov.Size = new Size(657, 520);
            Pnl_Table_Prov.TabIndex = 9;
            // 
            // DGV_Table_Client
            // 
            DGV_Table_Client.AllowUserToAddRows = false;
            DGV_Table_Client.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Table_Client.Dock = DockStyle.Fill;
            DGV_Table_Client.Location = new Point(51, 33);
            DGV_Table_Client.Margin = new Padding(3, 4, 3, 4);
            DGV_Table_Client.Name = "DGV_Table_Client";
            DGV_Table_Client.RowHeadersVisible = false;
            DGV_Table_Client.RowHeadersWidth = 51;
            DGV_Table_Client.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Table_Client.Size = new Size(572, 427);
            DGV_Table_Client.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(BclientesRemoved);
            Pnl_Buttons.Controls.Add(Btn_EliminarClient);
            Pnl_Buttons.Controls.Add(panel1);
            Pnl_Buttons.Controls.Add(Btn_Upd_Cliente);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(Btn_Add_Client);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(657, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 520);
            Pnl_Buttons.TabIndex = 8;
            // 
            // BclientesRemoved
            // 
            BclientesRemoved.BackColor = Color.DarkRed;
            BclientesRemoved.Cursor = Cursors.Hand;
            BclientesRemoved.Font = new Font("Segoe UI", 11F);
            BclientesRemoved.ForeColor = Color.White;
            BclientesRemoved.Location = new Point(0, 400);
            BclientesRemoved.Name = "BclientesRemoved";
            BclientesRemoved.Size = new Size(234, 60);
            BclientesRemoved.TabIndex = 10;
            BclientesRemoved.Text = "Clientes Eliminados";
            BclientesRemoved.UseVisualStyleBackColor = false;
            BclientesRemoved.Click += BclientesRemoved_Click;
            // 
            // Btn_EliminarClient
            // 
            Btn_EliminarClient.BackColor = Color.Green;
            Btn_EliminarClient.Cursor = Cursors.Hand;
            Btn_EliminarClient.Dock = DockStyle.Top;
            Btn_EliminarClient.Font = new Font("Segoe UI", 11F);
            Btn_EliminarClient.ForeColor = Color.White;
            Btn_EliminarClient.Location = new Point(0, 207);
            Btn_EliminarClient.Margin = new Padding(3, 4, 3, 4);
            Btn_EliminarClient.Name = "Btn_EliminarClient";
            Btn_EliminarClient.Size = new Size(234, 60);
            Btn_EliminarClient.TabIndex = 9;
            Btn_EliminarClient.Text = "Eliminar Cliente";
            Btn_EliminarClient.UseVisualStyleBackColor = false;
            Btn_EliminarClient.Click += Btn_Eliminar_Client_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 180);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 27);
            panel1.TabIndex = 8;
            // 
            // Btn_Upd_Cliente
            // 
            Btn_Upd_Cliente.BackColor = Color.Green;
            Btn_Upd_Cliente.Cursor = Cursors.Hand;
            Btn_Upd_Cliente.Dock = DockStyle.Top;
            Btn_Upd_Cliente.Font = new Font("Segoe UI", 11F);
            Btn_Upd_Cliente.ForeColor = Color.White;
            Btn_Upd_Cliente.Location = new Point(0, 120);
            Btn_Upd_Cliente.Margin = new Padding(3, 4, 3, 4);
            Btn_Upd_Cliente.Name = "Btn_Upd_Cliente";
            Btn_Upd_Cliente.Size = new Size(234, 60);
            Btn_Upd_Cliente.TabIndex = 7;
            Btn_Upd_Cliente.Text = "Modificar Cliente";
            Btn_Upd_Cliente.UseVisualStyleBackColor = false;
            Btn_Upd_Cliente.Click += Btn_Upd_Client_Click;
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
            Btn_Add_Client.BackColor = Color.Green;
            Btn_Add_Client.Cursor = Cursors.Hand;
            Btn_Add_Client.Dock = DockStyle.Top;
            Btn_Add_Client.Font = new Font("Segoe UI", 11F);
            Btn_Add_Client.ForeColor = Color.White;
            Btn_Add_Client.Location = new Point(0, 33);
            Btn_Add_Client.Margin = new Padding(3, 4, 3, 4);
            Btn_Add_Client.Name = "Btn_Add_Client";
            Btn_Add_Client.Size = new Size(234, 60);
            Btn_Add_Client.TabIndex = 0;
            Btn_Add_Client.Text = "Añadir Cliente";
            Btn_Add_Client.UseVisualStyleBackColor = false;
            Btn_Add_Client.Click += Btn_Add_Client_Click;
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
            Pnl_Table_Prov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Table_Client).EndInit();
            Pnl_Buttons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Client;
        private Panel Pnl_Filtro;
        private Panel Pnl_Buttons;
        private Button BProvRemoved;
        private Button Btn_EliminarClient;
        private Panel panel1;
        private Button Btn_Upd_Cliente;
        private Panel Pnl_Space1;
        private Button Btn_Emp_Prov;
        private Button Btn_Add_Client;
        private Panel Pnl_Table_Prov;
        private DataGridView DGV_Table_Client;
        private Button BclientesRemoved;
    }
}