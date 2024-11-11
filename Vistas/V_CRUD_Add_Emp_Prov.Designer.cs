namespace Vistas
{
    partial class V_CRUD_Add_Emp_Prov
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
            Pnl_CRUD_Add_Emp_Prov = new Panel();
            Pnl_Buttons = new Panel();
            Btn_Cancelar_Emp_Prov1 = new Button();
            Btn_Aceptar_Emp_Prov1 = new Button();
            Pnl_Add = new Panel();
            Txt_Nom_Emp_Prov = new TextBox();
            Txt_RFC_Emp_Prov = new TextBox();
            Txt_Email_Emp_Prov = new TextBox();
            Txt_Phone_Emp_Prov = new TextBox();
            Txt_ID_Emp_Prov = new TextBox();
            Lbl_Name_Emp_Prov = new Label();
            Lbl_RFC_Emp_Prov = new Label();
            Lbl_Email_Emp_Prov = new Label();
            Lbl_Phone_Emp_Prov = new Label();
            Lbl_ID_Emp_Prov = new Label();
            Pnl_CRUD_Add_Emp_Prov.SuspendLayout();
            Pnl_Buttons.SuspendLayout();
            Pnl_Add.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_CRUD_Add_Emp_Prov
            // 
            Pnl_CRUD_Add_Emp_Prov.Controls.Add(Pnl_Buttons);
            Pnl_CRUD_Add_Emp_Prov.Controls.Add(Pnl_Add);
            Pnl_CRUD_Add_Emp_Prov.Dock = DockStyle.Fill;
            Pnl_CRUD_Add_Emp_Prov.Location = new Point(0, 0);
            Pnl_CRUD_Add_Emp_Prov.Name = "Pnl_CRUD_Add_Emp_Prov";
            Pnl_CRUD_Add_Emp_Prov.Size = new Size(434, 311);
            Pnl_CRUD_Add_Emp_Prov.TabIndex = 2;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Emp_Prov1);
            Pnl_Buttons.Controls.Add(Btn_Aceptar_Emp_Prov1);
            Pnl_Buttons.Dock = DockStyle.Bottom;
            Pnl_Buttons.Location = new Point(0, 251);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new Size(434, 60);
            Pnl_Buttons.TabIndex = 1;
            // 
            // Btn_Cancelar_Emp_Prov1
            // 
            Btn_Cancelar_Emp_Prov1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Emp_Prov1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Emp_Prov1.Location = new Point(274, 15);
            Btn_Cancelar_Emp_Prov1.Name = "Btn_Cancelar_Emp_Prov1";
            Btn_Cancelar_Emp_Prov1.Size = new Size(100, 30);
            Btn_Cancelar_Emp_Prov1.TabIndex = 5;
            Btn_Cancelar_Emp_Prov1.Text = "Cancelar";
            Btn_Cancelar_Emp_Prov1.UseVisualStyleBackColor = true;
            Btn_Cancelar_Emp_Prov1.Click += Btn_Cancelar_Emp_Prov1_Click;
            // 
            // Btn_Aceptar_Emp_Prov1
            // 
            Btn_Aceptar_Emp_Prov1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar_Emp_Prov1.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar_Emp_Prov1.Location = new Point(60, 15);
            Btn_Aceptar_Emp_Prov1.Name = "Btn_Aceptar_Emp_Prov1";
            Btn_Aceptar_Emp_Prov1.Size = new Size(100, 30);
            Btn_Aceptar_Emp_Prov1.TabIndex = 4;
            Btn_Aceptar_Emp_Prov1.Text = "Aceptar";
            Btn_Aceptar_Emp_Prov1.UseVisualStyleBackColor = true;
            Btn_Aceptar_Emp_Prov1.Click += Btn_Aceptar_Emp_Prov1_Click;
            // 
            // Pnl_Add
            // 
            Pnl_Add.Controls.Add(Txt_Nom_Emp_Prov);
            Pnl_Add.Controls.Add(Txt_RFC_Emp_Prov);
            Pnl_Add.Controls.Add(Txt_Email_Emp_Prov);
            Pnl_Add.Controls.Add(Txt_Phone_Emp_Prov);
            Pnl_Add.Controls.Add(Txt_ID_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_Name_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_RFC_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_Email_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_Phone_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_ID_Emp_Prov);
            Pnl_Add.Dock = DockStyle.Top;
            Pnl_Add.Location = new Point(0, 0);
            Pnl_Add.Name = "Pnl_Add";
            Pnl_Add.Size = new Size(434, 250);
            Pnl_Add.TabIndex = 0;
            Pnl_Add.Paint += Pnl_Add_Paint;
            // 
            // Txt_Nom_Emp_Prov
            // 
            Txt_Nom_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_Nom_Emp_Prov.Location = new Point(200, 65);
            Txt_Nom_Emp_Prov.Name = "Txt_Nom_Emp_Prov";
            Txt_Nom_Emp_Prov.Size = new Size(195, 27);
            Txt_Nom_Emp_Prov.TabIndex = 16;
            // 
            // Txt_RFC_Emp_Prov
            // 
            Txt_RFC_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_RFC_Emp_Prov.Location = new Point(200, 110);
            Txt_RFC_Emp_Prov.Name = "Txt_RFC_Emp_Prov";
            Txt_RFC_Emp_Prov.Size = new Size(195, 27);
            Txt_RFC_Emp_Prov.TabIndex = 15;
            // 
            // Txt_Email_Emp_Prov
            // 
            Txt_Email_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_Email_Emp_Prov.Location = new Point(200, 155);
            Txt_Email_Emp_Prov.Name = "Txt_Email_Emp_Prov";
            Txt_Email_Emp_Prov.Size = new Size(195, 27);
            Txt_Email_Emp_Prov.TabIndex = 14;
            // 
            // Txt_Phone_Emp_Prov
            // 
            Txt_Phone_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_Phone_Emp_Prov.Location = new Point(200, 200);
            Txt_Phone_Emp_Prov.Name = "Txt_Phone_Emp_Prov";
            Txt_Phone_Emp_Prov.Size = new Size(195, 27);
            Txt_Phone_Emp_Prov.TabIndex = 13;
            // 
            // Txt_ID_Emp_Prov
            // 
            Txt_ID_Emp_Prov.Enabled = false;
            Txt_ID_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_ID_Emp_Prov.Location = new Point(200, 20);
            Txt_ID_Emp_Prov.Name = "Txt_ID_Emp_Prov";
            Txt_ID_Emp_Prov.ReadOnly = true;
            Txt_ID_Emp_Prov.Size = new Size(195, 27);
            Txt_ID_Emp_Prov.TabIndex = 8;
            // 
            // Lbl_Name_Emp_Prov
            // 
            Lbl_Name_Emp_Prov.AutoSize = true;
            Lbl_Name_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_Name_Emp_Prov.Location = new Point(30, 70);
            Lbl_Name_Emp_Prov.Name = "Lbl_Name_Emp_Prov";
            Lbl_Name_Emp_Prov.Size = new Size(164, 20);
            Lbl_Name_Emp_Prov.TabIndex = 7;
            Lbl_Name_Emp_Prov.Text = "Nombre del Empleado:";
            // 
            // Lbl_RFC_Emp_Prov
            // 
            Lbl_RFC_Emp_Prov.AutoSize = true;
            Lbl_RFC_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_RFC_Emp_Prov.Location = new Point(30, 115);
            Lbl_RFC_Emp_Prov.Name = "Lbl_RFC_Emp_Prov";
            Lbl_RFC_Emp_Prov.Size = new Size(134, 20);
            Lbl_RFC_Emp_Prov.TabIndex = 6;
            Lbl_RFC_Emp_Prov.Text = "RFC del Empleado:";
            // 
            // Lbl_Email_Emp_Prov
            // 
            Lbl_Email_Emp_Prov.AutoSize = true;
            Lbl_Email_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_Email_Emp_Prov.Location = new Point(30, 160);
            Lbl_Email_Emp_Prov.Name = "Lbl_Email_Emp_Prov";
            Lbl_Email_Emp_Prov.Size = new Size(55, 20);
            Lbl_Email_Emp_Prov.TabIndex = 5;
            Lbl_Email_Emp_Prov.Text = "E-Mail:";
            // 
            // Lbl_Phone_Emp_Prov
            // 
            Lbl_Phone_Emp_Prov.AutoSize = true;
            Lbl_Phone_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_Phone_Emp_Prov.Location = new Point(30, 205);
            Lbl_Phone_Emp_Prov.Name = "Lbl_Phone_Emp_Prov";
            Lbl_Phone_Emp_Prov.Size = new Size(151, 20);
            Lbl_Phone_Emp_Prov.TabIndex = 4;
            Lbl_Phone_Emp_Prov.Text = "Numero de Contacto:";
            // 
            // Lbl_ID_Emp_Prov
            // 
            Lbl_ID_Emp_Prov.AutoSize = true;
            Lbl_ID_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_ID_Emp_Prov.Location = new Point(30, 25);
            Lbl_ID_Emp_Prov.Name = "Lbl_ID_Emp_Prov";
            Lbl_ID_Emp_Prov.Size = new Size(124, 20);
            Lbl_ID_Emp_Prov.TabIndex = 0;
            Lbl_ID_Emp_Prov.Text = "ID del Empleado:";
            // 
            // V_CRUD_Add_Emp_Prov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(Pnl_CRUD_Add_Emp_Prov);
            MaximizeBox = false;
            Name = "V_CRUD_Add_Emp_Prov";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Empleado de Proveedor";
            Pnl_CRUD_Add_Emp_Prov.ResumeLayout(false);
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Add.ResumeLayout(false);
            Pnl_Add.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_CRUD_Add_Emp_Prov;
        private Panel Pnl_Buttons;
        private Panel Pnl_Add;
        private TextBox Txt_Nom_Emp_Prov;
        private TextBox Txt_RFC_Emp_Prov;
        private TextBox Txt_Email_Emp_Prov;
        private TextBox Txt_Phone_Emp_Prov;
        private TextBox Txt_ID_Emp_Prov;
        private Label Lbl_Name_Emp_Prov;
        private Label Lbl_RFC_Emp_Prov;
        private Label Lbl_Email_Emp_Prov;
        private Label Lbl_Phone_Emp_Prov;
        private Label Lbl_ID_Emp_Prov;
        private Button Btn_Cancelar_Emp_Prov1;
        private Button Btn_Aceptar_Emp_Prov1;
    }
}