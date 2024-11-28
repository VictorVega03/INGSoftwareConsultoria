namespace Vistas
{
    partial class V_ClientesRemoved
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
            Pnl_Filtro = new Panel();
            Pnl_Buttons = new Panel();
            BActivarClient = new Button();
            Pnl_Table_Emp = new Panel();
            TablaClientesRemoved = new DataGridView();
            Pnl_Buttons.SuspendLayout();
            Pnl_Table_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaClientesRemoved).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.BackColor = Color.White;
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(4, 5, 4, 5);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(1120, 100);
            Pnl_Filtro.TabIndex = 5;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(BActivarClient);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(799, 100);
            Pnl_Buttons.Margin = new Padding(4, 5, 4, 5);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 41, 29, 75);
            Pnl_Buttons.Size = new Size(321, 591);
            Pnl_Buttons.TabIndex = 8;
            // 
            // BActivarClient
            // 
            BActivarClient.BackColor = Color.Green;
            BActivarClient.Cursor = Cursors.Hand;
            BActivarClient.Dock = DockStyle.Top;
            BActivarClient.Font = new Font("Segoe UI", 11F);
            BActivarClient.ForeColor = Color.White;
            BActivarClient.Location = new Point(0, 41);
            BActivarClient.Margin = new Padding(4, 5, 4, 5);
            BActivarClient.Name = "BActivarClient";
            BActivarClient.Size = new Size(292, 75);
            BActivarClient.TabIndex = 0;
            BActivarClient.Text = "Reactivar Cliente";
            BActivarClient.UseVisualStyleBackColor = false;
            BActivarClient.Click += BActivarClient_Click;
            // 
            // Pnl_Table_Emp
            // 
            Pnl_Table_Emp.AutoSize = true;
            Pnl_Table_Emp.BackColor = Color.White;
            Pnl_Table_Emp.Controls.Add(TablaClientesRemoved);
            Pnl_Table_Emp.Dock = DockStyle.Fill;
            Pnl_Table_Emp.Location = new Point(0, 100);
            Pnl_Table_Emp.Margin = new Padding(4, 5, 4, 5);
            Pnl_Table_Emp.Name = "Pnl_Table_Emp";
            Pnl_Table_Emp.Padding = new Padding(64, 41, 42, 75);
            Pnl_Table_Emp.Size = new Size(799, 591);
            Pnl_Table_Emp.TabIndex = 9;
            // 
            // TablaClientesRemoved
            // 
            TablaClientesRemoved.AllowUserToAddRows = false;
            TablaClientesRemoved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaClientesRemoved.Dock = DockStyle.Fill;
            TablaClientesRemoved.Location = new Point(64, 41);
            TablaClientesRemoved.Margin = new Padding(4, 5, 4, 5);
            TablaClientesRemoved.Name = "TablaClientesRemoved";
            TablaClientesRemoved.RowHeadersVisible = false;
            TablaClientesRemoved.RowHeadersWidth = 51;
            TablaClientesRemoved.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaClientesRemoved.Size = new Size(693, 475);
            TablaClientesRemoved.TabIndex = 4;
            // 
            // V_ClientesRemoved
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 691);
            Controls.Add(Pnl_Table_Emp);
            Controls.Add(Pnl_Buttons);
            Controls.Add(Pnl_Filtro);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "V_ClientesRemoved";
            Text = "V_ClientesRemoved";
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Table_Emp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaClientesRemoved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Filtro;
        private Panel Pnl_Buttons;
        private Button BActivarClient;
        private Panel Pnl_Table_Emp;
        private DataGridView TablaClientesRemoved;
    }
}