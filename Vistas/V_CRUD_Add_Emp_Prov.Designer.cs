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
            BoxProveedor = new ComboBox();
            label1 = new Label();
            Txt_Nom_Emp_Prov = new TextBox();
            Txt_RFC_Emp_Prov = new TextBox();
            Txt_Email_Emp_Prov = new TextBox();
            Txt_Phone_Emp_Prov = new TextBox();
            Lbl_Name_Emp_Prov = new Label();
            Lbl_RFC_Emp_Prov = new Label();
            Lbl_Email_Emp_Prov = new Label();
            Lbl_Phone_Emp_Prov = new Label();
            txtLoginPassword = new TextBox();
            label2 = new Label();
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
            Pnl_CRUD_Add_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Pnl_CRUD_Add_Emp_Prov.Name = "Pnl_CRUD_Add_Emp_Prov";
            Pnl_CRUD_Add_Emp_Prov.Size = new Size(505, 431);
            Pnl_CRUD_Add_Emp_Prov.TabIndex = 2;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Emp_Prov1);
            Pnl_Buttons.Controls.Add(Btn_Aceptar_Emp_Prov1);
            Pnl_Buttons.Dock = DockStyle.Bottom;
            Pnl_Buttons.Location = new Point(0, 344);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new Size(505, 87);
            Pnl_Buttons.TabIndex = 1;
            // 
            // Btn_Cancelar_Emp_Prov1
            // 
            Btn_Cancelar_Emp_Prov1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Emp_Prov1.BackColor = Color.DarkRed;
            Btn_Cancelar_Emp_Prov1.Cursor = Cursors.Hand;
            Btn_Cancelar_Emp_Prov1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Emp_Prov1.ForeColor = Color.White;
            Btn_Cancelar_Emp_Prov1.Location = new Point(313, 20);
            Btn_Cancelar_Emp_Prov1.Margin = new Padding(3, 4, 3, 4);
            Btn_Cancelar_Emp_Prov1.Name = "Btn_Cancelar_Emp_Prov1";
            Btn_Cancelar_Emp_Prov1.Size = new Size(123, 47);
            Btn_Cancelar_Emp_Prov1.TabIndex = 6;
            Btn_Cancelar_Emp_Prov1.Text = "Cancelar";
            Btn_Cancelar_Emp_Prov1.UseVisualStyleBackColor = false;
            Btn_Cancelar_Emp_Prov1.Click += Btn_Cancelar_Emp_Prov1_Click;
            // 
            // Btn_Aceptar_Emp_Prov1
            // 
            Btn_Aceptar_Emp_Prov1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar_Emp_Prov1.BackColor = Color.Green;
            Btn_Aceptar_Emp_Prov1.Cursor = Cursors.Hand;
            Btn_Aceptar_Emp_Prov1.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar_Emp_Prov1.ForeColor = Color.White;
            Btn_Aceptar_Emp_Prov1.Location = new Point(69, 20);
            Btn_Aceptar_Emp_Prov1.Margin = new Padding(3, 4, 3, 4);
            Btn_Aceptar_Emp_Prov1.Name = "Btn_Aceptar_Emp_Prov1";
            Btn_Aceptar_Emp_Prov1.Size = new Size(123, 47);
            Btn_Aceptar_Emp_Prov1.TabIndex = 5;
            Btn_Aceptar_Emp_Prov1.Text = "Aceptar";
            Btn_Aceptar_Emp_Prov1.UseVisualStyleBackColor = false;
            Btn_Aceptar_Emp_Prov1.Click += Btn_Aceptar_Emp_Prov1_Click;
            // 
            // Pnl_Add
            // 
            Pnl_Add.BackColor = Color.White;
            Pnl_Add.Controls.Add(txtLoginPassword);
            Pnl_Add.Controls.Add(label2);
            Pnl_Add.Controls.Add(BoxProveedor);
            Pnl_Add.Controls.Add(label1);
            Pnl_Add.Controls.Add(Txt_Nom_Emp_Prov);
            Pnl_Add.Controls.Add(Txt_RFC_Emp_Prov);
            Pnl_Add.Controls.Add(Txt_Email_Emp_Prov);
            Pnl_Add.Controls.Add(Txt_Phone_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_Name_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_RFC_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_Email_Emp_Prov);
            Pnl_Add.Controls.Add(Lbl_Phone_Emp_Prov);
            Pnl_Add.Dock = DockStyle.Top;
            Pnl_Add.Location = new Point(0, 0);
            Pnl_Add.Margin = new Padding(3, 4, 3, 4);
            Pnl_Add.Name = "Pnl_Add";
            Pnl_Add.Size = new Size(505, 356);
            Pnl_Add.TabIndex = 0;
            // 
            // BoxProveedor
            // 
            BoxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxProveedor.Font = new Font("Segoe UI", 11F);
            BoxProveedor.FormattingEnabled = true;
            BoxProveedor.Location = new Point(271, 82);
            BoxProveedor.Name = "BoxProveedor";
            BoxProveedor.Size = new Size(222, 33);
            BoxProveedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 1;
            label1.Text = "Proveedor:";
            // 
            // Txt_Nom_Emp_Prov
            // 
            Txt_Nom_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_Nom_Emp_Prov.Location = new Point(271, 31);
            Txt_Nom_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Txt_Nom_Emp_Prov.Name = "Txt_Nom_Emp_Prov";
            Txt_Nom_Emp_Prov.Size = new Size(222, 32);
            Txt_Nom_Emp_Prov.TabIndex = 0;
            // 
            // Txt_RFC_Emp_Prov
            // 
            Txt_RFC_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_RFC_Emp_Prov.Location = new Point(271, 136);
            Txt_RFC_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Txt_RFC_Emp_Prov.Name = "Txt_RFC_Emp_Prov";
            Txt_RFC_Emp_Prov.Size = new Size(222, 32);
            Txt_RFC_Emp_Prov.TabIndex = 2;
            // 
            // Txt_Email_Emp_Prov
            // 
            Txt_Email_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_Email_Emp_Prov.Location = new Point(271, 196);
            Txt_Email_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Txt_Email_Emp_Prov.Name = "Txt_Email_Emp_Prov";
            Txt_Email_Emp_Prov.Size = new Size(222, 32);
            Txt_Email_Emp_Prov.TabIndex = 3;
            // 
            // Txt_Phone_Emp_Prov
            // 
            Txt_Phone_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Txt_Phone_Emp_Prov.Location = new Point(271, 250);
            Txt_Phone_Emp_Prov.Margin = new Padding(3, 4, 3, 4);
            Txt_Phone_Emp_Prov.Name = "Txt_Phone_Emp_Prov";
            Txt_Phone_Emp_Prov.Size = new Size(222, 32);
            Txt_Phone_Emp_Prov.TabIndex = 4;
            // 
            // Lbl_Name_Emp_Prov
            // 
            Lbl_Name_Emp_Prov.AutoSize = true;
            Lbl_Name_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_Name_Emp_Prov.Location = new Point(12, 34);
            Lbl_Name_Emp_Prov.Name = "Lbl_Name_Emp_Prov";
            Lbl_Name_Emp_Prov.Size = new Size(205, 25);
            Lbl_Name_Emp_Prov.TabIndex = 0;
            Lbl_Name_Emp_Prov.Text = "Nombre del Empleado:";
            // 
            // Lbl_RFC_Emp_Prov
            // 
            Lbl_RFC_Emp_Prov.AutoSize = true;
            Lbl_RFC_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_RFC_Emp_Prov.Location = new Point(12, 139);
            Lbl_RFC_Emp_Prov.Name = "Lbl_RFC_Emp_Prov";
            Lbl_RFC_Emp_Prov.Size = new Size(168, 25);
            Lbl_RFC_Emp_Prov.TabIndex = 2;
            Lbl_RFC_Emp_Prov.Text = "RFC del Empleado:";
            // 
            // Lbl_Email_Emp_Prov
            // 
            Lbl_Email_Emp_Prov.AutoSize = true;
            Lbl_Email_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_Email_Emp_Prov.Location = new Point(12, 199);
            Lbl_Email_Emp_Prov.Name = "Lbl_Email_Emp_Prov";
            Lbl_Email_Emp_Prov.Size = new Size(71, 25);
            Lbl_Email_Emp_Prov.TabIndex = 3;
            Lbl_Email_Emp_Prov.Text = "E-Mail:";
            // 
            // Lbl_Phone_Emp_Prov
            // 
            Lbl_Phone_Emp_Prov.AutoSize = true;
            Lbl_Phone_Emp_Prov.Font = new Font("Segoe UI", 11F);
            Lbl_Phone_Emp_Prov.Location = new Point(12, 254);
            Lbl_Phone_Emp_Prov.Name = "Lbl_Phone_Emp_Prov";
            Lbl_Phone_Emp_Prov.Size = new Size(192, 25);
            Lbl_Phone_Emp_Prov.TabIndex = 4;
            Lbl_Phone_Emp_Prov.Text = "Numero de Contacto:";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Segoe UI", 11F);
            txtLoginPassword.Location = new Point(271, 304);
            txtLoginPassword.Margin = new Padding(3, 4, 3, 4);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(222, 32);
            txtLoginPassword.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(6, 311);
            label2.Name = "label2";
            label2.Size = new Size(264, 25);
            label2.TabIndex = 23;
            label2.Text = "Contraseña para inicio sesion:";
            // 
            // V_CRUD_Add_Emp_Prov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 431);
            Controls.Add(Pnl_CRUD_Add_Emp_Prov);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label Lbl_Name_Emp_Prov;
        private Label Lbl_RFC_Emp_Prov;
        private Label Lbl_Email_Emp_Prov;
        private Label Lbl_Phone_Emp_Prov;
        private Button Btn_Cancelar_Emp_Prov1;
        private Button Btn_Aceptar_Emp_Prov1;
        private Label label1;
        private ComboBox BoxProveedor;
        private TextBox txtLoginPassword;
        private Label label2;
    }
}