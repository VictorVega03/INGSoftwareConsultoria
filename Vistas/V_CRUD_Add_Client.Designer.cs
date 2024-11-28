namespace Vistas
{
    partial class V_CRUD_Add_Client
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
            Pnl_CRUD_Add_Client = new Panel();
            Pnl_Buttons = new Panel();
            Btn_Cancelar_Cliente1 = new Button();
            Btn_Aceptar_Cliente1 = new Button();
            Pnl_Add = new Panel();
            txtDireccion = new TextBox();
            label1 = new Label();
            Txt_Nom_Cliente = new TextBox();
            Txt_RFC_Cliente = new TextBox();
            Txt_Email_Cliente = new TextBox();
            Txt_Phone_Cliente = new TextBox();
            Lbl_Name_Cliente = new Label();
            Lbl_RFC_Cliente = new Label();
            Lbl_Email_Cliente = new Label();
            Lbl_Phone_Cliente = new Label();
            Pnl_CRUD_Add_Client.SuspendLayout();
            Pnl_Buttons.SuspendLayout();
            Pnl_Add.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_CRUD_Add_Client
            // 
            Pnl_CRUD_Add_Client.Controls.Add(Pnl_Buttons);
            Pnl_CRUD_Add_Client.Controls.Add(Pnl_Add);
            Pnl_CRUD_Add_Client.Dock = DockStyle.Fill;
            Pnl_CRUD_Add_Client.Location = new Point(0, 0);
            Pnl_CRUD_Add_Client.Margin = new Padding(4, 5, 4, 5);
            Pnl_CRUD_Add_Client.Name = "Pnl_CRUD_Add_Client";
            Pnl_CRUD_Add_Client.Size = new Size(620, 472);
            Pnl_CRUD_Add_Client.TabIndex = 0;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Cliente1);
            Pnl_Buttons.Controls.Add(Btn_Aceptar_Cliente1);
            Pnl_Buttons.Dock = DockStyle.Bottom;
            Pnl_Buttons.Location = new Point(0, 372);
            Pnl_Buttons.Margin = new Padding(4, 5, 4, 5);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new Size(620, 100);
            Pnl_Buttons.TabIndex = 8;
            // 
            // Btn_Cancelar_Cliente1
            // 
            Btn_Cancelar_Cliente1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Cliente1.BackColor = Color.DarkRed;
            Btn_Cancelar_Cliente1.Cursor = Cursors.Hand;
            Btn_Cancelar_Cliente1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Cliente1.ForeColor = Color.White;
            Btn_Cancelar_Cliente1.Location = new Point(391, 25);
            Btn_Cancelar_Cliente1.Margin = new Padding(4, 5, 4, 5);
            Btn_Cancelar_Cliente1.Name = "Btn_Cancelar_Cliente1";
            Btn_Cancelar_Cliente1.Size = new Size(142, 50);
            Btn_Cancelar_Cliente1.TabIndex = 5;
            Btn_Cancelar_Cliente1.Text = "Cancelar";
            Btn_Cancelar_Cliente1.UseVisualStyleBackColor = false;
            Btn_Cancelar_Cliente1.Click += Btn_Cancelar_Cliente1_Click;
            // 
            // Btn_Aceptar_Cliente1
            // 
            Btn_Aceptar_Cliente1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar_Cliente1.BackColor = Color.Green;
            Btn_Aceptar_Cliente1.Cursor = Cursors.Hand;
            Btn_Aceptar_Cliente1.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar_Cliente1.ForeColor = Color.White;
            Btn_Aceptar_Cliente1.Location = new Point(86, 25);
            Btn_Aceptar_Cliente1.Margin = new Padding(4, 5, 4, 5);
            Btn_Aceptar_Cliente1.Name = "Btn_Aceptar_Cliente1";
            Btn_Aceptar_Cliente1.Size = new Size(142, 50);
            Btn_Aceptar_Cliente1.TabIndex = 4;
            Btn_Aceptar_Cliente1.Text = "Aceptar";
            Btn_Aceptar_Cliente1.UseVisualStyleBackColor = false;
            Btn_Aceptar_Cliente1.Click += Btn_Aceptar_Cliente1_Click;
            // 
            // Pnl_Add
            // 
            Pnl_Add.BackColor = Color.White;
            Pnl_Add.Controls.Add(txtDireccion);
            Pnl_Add.Controls.Add(label1);
            Pnl_Add.Controls.Add(Txt_Nom_Cliente);
            Pnl_Add.Controls.Add(Txt_RFC_Cliente);
            Pnl_Add.Controls.Add(Txt_Email_Cliente);
            Pnl_Add.Controls.Add(Txt_Phone_Cliente);
            Pnl_Add.Controls.Add(Lbl_Name_Cliente);
            Pnl_Add.Controls.Add(Lbl_RFC_Cliente);
            Pnl_Add.Controls.Add(Lbl_Email_Cliente);
            Pnl_Add.Controls.Add(Lbl_Phone_Cliente);
            Pnl_Add.Dock = DockStyle.Top;
            Pnl_Add.Location = new Point(0, 0);
            Pnl_Add.Margin = new Padding(4, 5, 4, 5);
            Pnl_Add.Name = "Pnl_Add";
            Pnl_Add.Size = new Size(620, 372);
            Pnl_Add.TabIndex = 0;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11F);
            txtDireccion.Location = new Point(282, 328);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(276, 37);
            txtDireccion.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(39, 331);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 8;
            label1.Text = "Dirección:";
            // 
            // Txt_Nom_Cliente
            // 
            Txt_Nom_Cliente.Font = new Font("Segoe UI", 11F);
            Txt_Nom_Cliente.Location = new Point(282, 30);
            Txt_Nom_Cliente.Margin = new Padding(4, 5, 4, 5);
            Txt_Nom_Cliente.Name = "Txt_Nom_Cliente";
            Txt_Nom_Cliente.Size = new Size(276, 37);
            Txt_Nom_Cliente.TabIndex = 0;
            // 
            // Txt_RFC_Cliente
            // 
            Txt_RFC_Cliente.Font = new Font("Segoe UI", 11F);
            Txt_RFC_Cliente.Location = new Point(282, 105);
            Txt_RFC_Cliente.Margin = new Padding(4, 5, 4, 5);
            Txt_RFC_Cliente.Name = "Txt_RFC_Cliente";
            Txt_RFC_Cliente.Size = new Size(276, 37);
            Txt_RFC_Cliente.TabIndex = 1;
            // 
            // Txt_Email_Cliente
            // 
            Txt_Email_Cliente.Font = new Font("Segoe UI", 11F);
            Txt_Email_Cliente.Location = new Point(282, 180);
            Txt_Email_Cliente.Margin = new Padding(4, 5, 4, 5);
            Txt_Email_Cliente.Name = "Txt_Email_Cliente";
            Txt_Email_Cliente.Size = new Size(276, 37);
            Txt_Email_Cliente.TabIndex = 2;
            // 
            // Txt_Phone_Cliente
            // 
            Txt_Phone_Cliente.Font = new Font("Segoe UI", 11F);
            Txt_Phone_Cliente.Location = new Point(282, 255);
            Txt_Phone_Cliente.Margin = new Padding(4, 5, 4, 5);
            Txt_Phone_Cliente.Name = "Txt_Phone_Cliente";
            Txt_Phone_Cliente.Size = new Size(276, 37);
            Txt_Phone_Cliente.TabIndex = 3;
            // 
            // Lbl_Name_Cliente
            // 
            Lbl_Name_Cliente.AutoSize = true;
            Lbl_Name_Cliente.Font = new Font("Segoe UI", 11F);
            Lbl_Name_Cliente.Location = new Point(39, 38);
            Lbl_Name_Cliente.Margin = new Padding(4, 0, 4, 0);
            Lbl_Name_Cliente.Name = "Lbl_Name_Cliente";
            Lbl_Name_Cliente.Size = new Size(208, 30);
            Lbl_Name_Cliente.TabIndex = 1;
            Lbl_Name_Cliente.Text = "Nombre del Cliente:";
            // 
            // Lbl_RFC_Cliente
            // 
            Lbl_RFC_Cliente.AutoSize = true;
            Lbl_RFC_Cliente.Font = new Font("Segoe UI", 11F);
            Lbl_RFC_Cliente.Location = new Point(39, 112);
            Lbl_RFC_Cliente.Margin = new Padding(4, 0, 4, 0);
            Lbl_RFC_Cliente.Name = "Lbl_RFC_Cliente";
            Lbl_RFC_Cliente.Size = new Size(165, 30);
            Lbl_RFC_Cliente.TabIndex = 6;
            Lbl_RFC_Cliente.Text = "RFC del Cliente:";
            // 
            // Lbl_Email_Cliente
            // 
            Lbl_Email_Cliente.AutoSize = true;
            Lbl_Email_Cliente.Font = new Font("Segoe UI", 11F);
            Lbl_Email_Cliente.Location = new Point(39, 188);
            Lbl_Email_Cliente.Margin = new Padding(4, 0, 4, 0);
            Lbl_Email_Cliente.Name = "Lbl_Email_Cliente";
            Lbl_Email_Cliente.Size = new Size(79, 30);
            Lbl_Email_Cliente.TabIndex = 5;
            Lbl_Email_Cliente.Text = "E-Mail:";
            // 
            // Lbl_Phone_Cliente
            // 
            Lbl_Phone_Cliente.AutoSize = true;
            Lbl_Phone_Cliente.Font = new Font("Segoe UI", 11F);
            Lbl_Phone_Cliente.Location = new Point(39, 262);
            Lbl_Phone_Cliente.Margin = new Padding(4, 0, 4, 0);
            Lbl_Phone_Cliente.Name = "Lbl_Phone_Cliente";
            Lbl_Phone_Cliente.Size = new Size(222, 30);
            Lbl_Phone_Cliente.TabIndex = 4;
            Lbl_Phone_Cliente.Text = "Numero de Contacto:";
            // 
            // V_CRUD_Add_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 472);
            Controls.Add(Pnl_CRUD_Add_Client);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "V_CRUD_Add_Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cliente";
            Pnl_CRUD_Add_Client.ResumeLayout(false);
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Add.ResumeLayout(false);
            Pnl_Add.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_CRUD_Add_Client;
        private Panel Pnl_Buttons;
        private Panel Pnl_Add;
        private Button Btn_Cancelar_Cliente1;
        private Button Btn_Aceptar_Cliente1;
        private Label Lbl_Name_Cliente;
        private Label Lbl_RFC_Cliente;
        private Label Lbl_Email_Cliente;
        private Label Lbl_Phone_Cliente;
        private TextBox textBox2;
        private TextBox Txt_Nom_Cliente;
        private TextBox Txt_RFC_Cliente;
        private TextBox Txt_Email_Cliente;
        private TextBox Txt_Phone_Cliente;
        private TextBox txtDireccion;
        private Label label1;
    }
}