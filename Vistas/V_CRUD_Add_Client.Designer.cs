﻿namespace Vistas
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
            Txt_Nom_Cliente = new TextBox();
            Txt_RFC_Cliente = new TextBox();
            Txt_Email_Cliente = new TextBox();
            Txt_Phone_Cliente = new TextBox();
            Txt_ID_Client = new TextBox();
            Lbl_Name_Cliente = new Label();
            Lbl_RFC_Cliente = new Label();
            Lbl_Email_Cliente = new Label();
            Lbl_Phone_Cliente = new Label();
            Lbl_ID_Client = new Label();
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
            Pnl_CRUD_Add_Client.Name = "Pnl_CRUD_Add_Client";
            Pnl_CRUD_Add_Client.Size = new Size(434, 311);
            Pnl_CRUD_Add_Client.TabIndex = 0;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Cliente1);
            Pnl_Buttons.Controls.Add(Btn_Aceptar_Cliente1);
            Pnl_Buttons.Dock = DockStyle.Bottom;
            Pnl_Buttons.Location = new Point(0, 251);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new Size(434, 60);
            Pnl_Buttons.TabIndex = 1;
            // 
            // Btn_Cancelar_Cliente1
            // 
            Btn_Cancelar_Cliente1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Cliente1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Cliente1.Location = new Point(274, 15);
            Btn_Cancelar_Cliente1.Name = "Btn_Cancelar_Cliente1";
            Btn_Cancelar_Cliente1.Size = new Size(100, 30);
            Btn_Cancelar_Cliente1.TabIndex = 1;
            Btn_Cancelar_Cliente1.Text = "Cancelar";
            Btn_Cancelar_Cliente1.UseVisualStyleBackColor = true;
            Btn_Cancelar_Cliente1.Click += Btn_Cancelar_Cliente1_Click;
            // 
            // Btn_Aceptar_Cliente1
            // 
            Btn_Aceptar_Cliente1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar_Cliente1.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar_Cliente1.Location = new Point(60, 15);
            Btn_Aceptar_Cliente1.Name = "Btn_Aceptar_Cliente1";
            Btn_Aceptar_Cliente1.Size = new Size(100, 30);
            Btn_Aceptar_Cliente1.TabIndex = 0;
            Btn_Aceptar_Cliente1.Text = "Aceptar";
            Btn_Aceptar_Cliente1.UseVisualStyleBackColor = true;
            Btn_Aceptar_Cliente1.Click += Btn_Aceptar_Cliente1_Click;
            // 
            // Pnl_Add
            // 
            Pnl_Add.Controls.Add(Txt_Nom_Cliente);
            Pnl_Add.Controls.Add(Txt_RFC_Cliente);
            Pnl_Add.Controls.Add(Txt_Email_Cliente);
            Pnl_Add.Controls.Add(Txt_Phone_Cliente);
            Pnl_Add.Controls.Add(Txt_ID_Client);
            Pnl_Add.Controls.Add(Lbl_Name_Cliente);
            Pnl_Add.Controls.Add(Lbl_RFC_Cliente);
            Pnl_Add.Controls.Add(Lbl_Email_Cliente);
            Pnl_Add.Controls.Add(Lbl_Phone_Cliente);
            Pnl_Add.Controls.Add(Lbl_ID_Client);
            Pnl_Add.Dock = DockStyle.Top;
            Pnl_Add.Location = new Point(0, 0);
            Pnl_Add.Name = "Pnl_Add";
            Pnl_Add.Size = new Size(434, 250);
            Pnl_Add.TabIndex = 0;
            Pnl_Add.Paint += Pnl_Add_Paint_2;
            // 
            // Txt_Nom_Cliente
            // 
            Txt_Nom_Cliente.Font = new Font("Segoe UI", 11F);
            Txt_Nom_Cliente.Location = new Point(200, 65);
            Txt_Nom_Cliente.Name = "Txt_Nom_Cliente";
            Txt_Nom_Cliente.Size = new Size(195, 27);
            Txt_Nom_Cliente.TabIndex = 16;
            // 
            // Txt_RFC_Cliente
            // 
            Txt_RFC_Cliente.Font = new Font("Segoe UI", 11F);
            Txt_RFC_Cliente.Location = new Point(200, 110);
            Txt_RFC_Cliente.Name = "Txt_RFC_Cliente";
            Txt_RFC_Cliente.Size = new Size(195, 27);
            Txt_RFC_Cliente.TabIndex = 15;
            // 
            // Txt_Email_Cliente
            // 
            Txt_Email_Cliente.Font = new Font("Segoe UI", 11F);
            Txt_Email_Cliente.Location = new Point(200, 155);
            Txt_Email_Cliente.Name = "Txt_Email_Cliente";
            Txt_Email_Cliente.Size = new Size(195, 27);
            Txt_Email_Cliente.TabIndex = 14;
            // 
            // Txt_Phone_Cliente
            // 
            Txt_Phone_Cliente.Font = new Font("Segoe UI", 11F);
            Txt_Phone_Cliente.Location = new Point(200, 200);
            Txt_Phone_Cliente.Name = "Txt_Phone_Cliente";
            Txt_Phone_Cliente.Size = new Size(195, 27);
            Txt_Phone_Cliente.TabIndex = 13;
            // 
            // Txt_ID_Client
            // 
            Txt_ID_Client.Enabled = false;
            Txt_ID_Client.Font = new Font("Segoe UI", 11F);
            Txt_ID_Client.Location = new Point(200, 20);
            Txt_ID_Client.Name = "Txt_ID_Client";
            Txt_ID_Client.ReadOnly = true;
            Txt_ID_Client.Size = new Size(195, 27);
            Txt_ID_Client.TabIndex = 8;
            // 
            // Lbl_Name_Cliente
            // 
            Lbl_Name_Cliente.AutoSize = true;
            Lbl_Name_Cliente.Font = new Font("Segoe UI", 11F);
            Lbl_Name_Cliente.Location = new Point(30, 70);
            Lbl_Name_Cliente.Name = "Lbl_Name_Cliente";
            Lbl_Name_Cliente.Size = new Size(142, 20);
            Lbl_Name_Cliente.TabIndex = 7;
            Lbl_Name_Cliente.Text = "Nombre del Cliente:";
            // 
            // Lbl_RFC_Cliente
            // 
            Lbl_RFC_Cliente.AutoSize = true;
            Lbl_RFC_Cliente.Font = new Font("Segoe UI", 11F);
            Lbl_RFC_Cliente.Location = new Point(30, 115);
            Lbl_RFC_Cliente.Name = "Lbl_RFC_Cliente";
            Lbl_RFC_Cliente.Size = new Size(112, 20);
            Lbl_RFC_Cliente.TabIndex = 6;
            Lbl_RFC_Cliente.Text = "RFC del Cliente:";
            // 
            // Lbl_Email_Cliente
            // 
            Lbl_Email_Cliente.AutoSize = true;
            Lbl_Email_Cliente.Font = new Font("Segoe UI", 11F);
            Lbl_Email_Cliente.Location = new Point(30, 160);
            Lbl_Email_Cliente.Name = "Lbl_Email_Cliente";
            Lbl_Email_Cliente.Size = new Size(55, 20);
            Lbl_Email_Cliente.TabIndex = 5;
            Lbl_Email_Cliente.Text = "E-Mail:";
            // 
            // Lbl_Phone_Cliente
            // 
            Lbl_Phone_Cliente.AutoSize = true;
            Lbl_Phone_Cliente.Font = new Font("Segoe UI", 11F);
            Lbl_Phone_Cliente.Location = new Point(30, 205);
            Lbl_Phone_Cliente.Name = "Lbl_Phone_Cliente";
            Lbl_Phone_Cliente.Size = new Size(151, 20);
            Lbl_Phone_Cliente.TabIndex = 4;
            Lbl_Phone_Cliente.Text = "Numero de Contacto:";
            // 
            // Lbl_ID_Client
            // 
            Lbl_ID_Client.AutoSize = true;
            Lbl_ID_Client.Font = new Font("Segoe UI", 11F);
            Lbl_ID_Client.Location = new Point(30, 25);
            Lbl_ID_Client.Name = "Lbl_ID_Client";
            Lbl_ID_Client.Size = new Size(102, 20);
            Lbl_ID_Client.TabIndex = 0;
            Lbl_ID_Client.Text = "ID del Cliente:";
            // 
            // V_CRUD_Add_Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(Pnl_CRUD_Add_Client);
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
        private Label Lbl_ID_Client;
        private TextBox textBox2;
        private TextBox Txt_ID_Client;
        private TextBox Txt_Nom_Cliente;
        private TextBox Txt_RFC_Cliente;
        private TextBox Txt_Email_Cliente;
        private TextBox Txt_Phone_Cliente;
    }
}