namespace Vistas
{
    partial class V_CRUD_Add_Act
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
            Pnl_CRUD_Add_Act = new Panel();
            Pnl_Add = new Panel();
            label0 = new Label();
            label2 = new Label();
            BoxEmpleado = new ComboBox();
            label3 = new Label();
            txtProyecto = new TextBox();
            BoxEmpProv = new ComboBox();
            txtDescripAct = new TextBox();
            Lbl_Notas = new Label();
            txtNombreAct = new TextBox();
            label4 = new Label();
            Pnl_Buttons = new Panel();
            Btn_Cancelar_Act1 = new Button();
            Btn_Asignar_Act1 = new Button();
            Btn_Cancelar_Prov1 = new Button();
            Btn_Aceptar_Prov1 = new Button();
            Btn_Cancelar_Emp1 = new Button();
            Btn_Aceptar_Emp1 = new Button();
            Btn_Cancelar = new Button();
            Btn_Aceptar = new Button();
            Pnl_CRUD_Add_Act.SuspendLayout();
            Pnl_Add.SuspendLayout();
            Pnl_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_CRUD_Add_Act
            // 
            Pnl_CRUD_Add_Act.Controls.Add(Pnl_Add);
            Pnl_CRUD_Add_Act.Controls.Add(Pnl_Buttons);
            Pnl_CRUD_Add_Act.Dock = DockStyle.Fill;
            Pnl_CRUD_Add_Act.Location = new Point(0, 0);
            Pnl_CRUD_Add_Act.Margin = new Padding(4, 5, 4, 5);
            Pnl_CRUD_Add_Act.Name = "Pnl_CRUD_Add_Act";
            Pnl_CRUD_Add_Act.Size = new Size(1269, 516);
            Pnl_CRUD_Add_Act.TabIndex = 3;
            // 
            // Pnl_Add
            // 
            Pnl_Add.AutoSize = true;
            Pnl_Add.BackColor = Color.White;
            Pnl_Add.Controls.Add(label0);
            Pnl_Add.Controls.Add(label2);
            Pnl_Add.Controls.Add(BoxEmpleado);
            Pnl_Add.Controls.Add(label3);
            Pnl_Add.Controls.Add(txtProyecto);
            Pnl_Add.Controls.Add(BoxEmpProv);
            Pnl_Add.Controls.Add(txtDescripAct);
            Pnl_Add.Controls.Add(Lbl_Notas);
            Pnl_Add.Controls.Add(txtNombreAct);
            Pnl_Add.Controls.Add(label4);
            Pnl_Add.Dock = DockStyle.Fill;
            Pnl_Add.Location = new Point(0, 0);
            Pnl_Add.Margin = new Padding(4, 5, 4, 5);
            Pnl_Add.Name = "Pnl_Add";
            Pnl_Add.Size = new Size(1269, 416);
            Pnl_Add.TabIndex = 3;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Segoe UI", 11F);
            label0.Location = new Point(15, 84);
            label0.Margin = new Padding(4, 0, 4, 0);
            label0.Name = "label0";
            label0.Size = new Size(167, 30);
            label0.TabIndex = 30;
            label0.Text = "ID del Proyecto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(16, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 30);
            label2.TabIndex = 29;
            label2.Text = "Nombre de Actividad:";
            // 
            // BoxEmpleado
            // 
            BoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxEmpleado.Font = new Font("Segoe UI", 9F);
            BoxEmpleado.FormattingEnabled = true;
            BoxEmpleado.Location = new Point(296, 206);
            BoxEmpleado.Margin = new Padding(4, 5, 4, 5);
            BoxEmpleado.Name = "BoxEmpleado";
            BoxEmpleado.Size = new Size(320, 33);
            BoxEmpleado.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(10, 206);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 30);
            label3.TabIndex = 26;
            label3.Text = "Asignar Empleado:";
            // 
            // txtProyecto
            // 
            txtProyecto.Enabled = false;
            txtProyecto.Font = new Font("Segoe UI", 11F);
            txtProyecto.Location = new Point(296, 78);
            txtProyecto.Margin = new Padding(4, 5, 4, 5);
            txtProyecto.Name = "txtProyecto";
            txtProyecto.ReadOnly = true;
            txtProyecto.Size = new Size(320, 37);
            txtProyecto.TabIndex = 0;
            // 
            // BoxEmpProv
            // 
            BoxEmpProv.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxEmpProv.FormattingEnabled = true;
            BoxEmpProv.Location = new Point(296, 269);
            BoxEmpProv.Margin = new Padding(4);
            BoxEmpProv.Name = "BoxEmpProv";
            BoxEmpProv.Size = new Size(320, 33);
            BoxEmpProv.TabIndex = 4;
            // 
            // txtDescripAct
            // 
            txtDescripAct.BackColor = SystemColors.InactiveBorder;
            txtDescripAct.Font = new Font("Segoe UI", 11F);
            txtDescripAct.Location = new Point(644, 60);
            txtDescripAct.Margin = new Padding(4, 5, 4, 5);
            txtDescripAct.Multiline = true;
            txtDescripAct.Name = "txtDescripAct";
            txtDescripAct.Size = new Size(609, 350);
            txtDescripAct.TabIndex = 21;
            // 
            // Lbl_Notas
            // 
            Lbl_Notas.AutoSize = true;
            Lbl_Notas.Font = new Font("Segoe UI", 11F);
            Lbl_Notas.Location = new Point(644, 11);
            Lbl_Notas.Margin = new Padding(4, 0, 4, 0);
            Lbl_Notas.Name = "Lbl_Notas";
            Lbl_Notas.Size = new Size(278, 30);
            Lbl_Notas.TabIndex = 19;
            Lbl_Notas.Text = "Descripción de la Actividad:";
            // 
            // txtNombreAct
            // 
            txtNombreAct.Font = new Font("Segoe UI", 11F);
            txtNombreAct.Location = new Point(296, 141);
            txtNombreAct.Margin = new Padding(4, 5, 4, 5);
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(320, 37);
            txtNombreAct.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(10, 272);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(254, 30);
            label4.TabIndex = 6;
            label4.Text = "Empleado de Proveedor:";
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Act1);
            Pnl_Buttons.Controls.Add(Btn_Asignar_Act1);
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Prov1);
            Pnl_Buttons.Controls.Add(Btn_Aceptar_Prov1);
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Emp1);
            Pnl_Buttons.Controls.Add(Btn_Aceptar_Emp1);
            Pnl_Buttons.Controls.Add(Btn_Cancelar);
            Pnl_Buttons.Controls.Add(Btn_Aceptar);
            Pnl_Buttons.Dock = DockStyle.Bottom;
            Pnl_Buttons.Location = new Point(0, 416);
            Pnl_Buttons.Margin = new Padding(4, 5, 4, 5);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new Size(1269, 100);
            Pnl_Buttons.TabIndex = 1;
            // 
            // Btn_Cancelar_Act1
            // 
            Btn_Cancelar_Act1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Act1.BackColor = Color.DarkRed;
            Btn_Cancelar_Act1.Cursor = Cursors.Hand;
            Btn_Cancelar_Act1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Act1.ForeColor = Color.White;
            Btn_Cancelar_Act1.Location = new Point(679, 25);
            Btn_Cancelar_Act1.Margin = new Padding(4, 5, 4, 5);
            Btn_Cancelar_Act1.Name = "Btn_Cancelar_Act1";
            Btn_Cancelar_Act1.Size = new Size(348, 50);
            Btn_Cancelar_Act1.TabIndex = 9;
            Btn_Cancelar_Act1.Text = "Cancelar";
            Btn_Cancelar_Act1.UseVisualStyleBackColor = false;
            Btn_Cancelar_Act1.Click += Btn_Cancelar_Act1_Click;
            // 
            // Btn_Asignar_Act1
            // 
            Btn_Asignar_Act1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Asignar_Act1.BackColor = Color.Green;
            Btn_Asignar_Act1.Cursor = Cursors.Hand;
            Btn_Asignar_Act1.Font = new Font("Segoe UI", 11F);
            Btn_Asignar_Act1.ForeColor = Color.White;
            Btn_Asignar_Act1.Location = new Point(201, 25);
            Btn_Asignar_Act1.Margin = new Padding(4, 5, 4, 5);
            Btn_Asignar_Act1.Name = "Btn_Asignar_Act1";
            Btn_Asignar_Act1.Size = new Size(348, 50);
            Btn_Asignar_Act1.TabIndex = 8;
            Btn_Asignar_Act1.Text = "Asignar";
            Btn_Asignar_Act1.UseVisualStyleBackColor = false;
            Btn_Asignar_Act1.Click += Btn_Asignar_Act1_Click;
            // 
            // Btn_Cancelar_Prov1
            // 
            Btn_Cancelar_Prov1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Prov1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Prov1.Location = new Point(416, 25);
            Btn_Cancelar_Prov1.Margin = new Padding(4, 5, 4, 5);
            Btn_Cancelar_Prov1.Name = "Btn_Cancelar_Prov1";
            Btn_Cancelar_Prov1.Size = new Size(1126, 0);
            Btn_Cancelar_Prov1.TabIndex = 7;
            Btn_Cancelar_Prov1.Text = "Cancelar";
            Btn_Cancelar_Prov1.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar_Prov1
            // 
            Btn_Aceptar_Prov1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar_Prov1.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar_Prov1.Location = new Point(110, 25);
            Btn_Aceptar_Prov1.Margin = new Padding(4, 5, 4, 5);
            Btn_Aceptar_Prov1.Name = "Btn_Aceptar_Prov1";
            Btn_Aceptar_Prov1.Size = new Size(1126, 0);
            Btn_Aceptar_Prov1.TabIndex = 6;
            Btn_Aceptar_Prov1.Text = "Aceptar";
            Btn_Aceptar_Prov1.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar_Emp1
            // 
            Btn_Cancelar_Emp1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Emp1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Emp1.Location = new Point(391, 25);
            Btn_Cancelar_Emp1.Margin = new Padding(4, 5, 4, 5);
            Btn_Cancelar_Emp1.Name = "Btn_Cancelar_Emp1";
            Btn_Cancelar_Emp1.Size = new Size(1510, 0);
            Btn_Cancelar_Emp1.TabIndex = 3;
            Btn_Cancelar_Emp1.Text = "Cancelar";
            Btn_Cancelar_Emp1.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar_Emp1
            // 
            Btn_Aceptar_Emp1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar_Emp1.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar_Emp1.Location = new Point(86, 25);
            Btn_Aceptar_Emp1.Margin = new Padding(4, 5, 4, 5);
            Btn_Aceptar_Emp1.Name = "Btn_Aceptar_Emp1";
            Btn_Aceptar_Emp1.Size = new Size(1510, 0);
            Btn_Aceptar_Emp1.TabIndex = 2;
            Btn_Aceptar_Emp1.Text = "Aceptar";
            Btn_Aceptar_Emp1.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar.Location = new Point(391, 25);
            Btn_Cancelar.Margin = new Padding(4, 5, 4, 5);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(1845, 0);
            Btn_Cancelar.TabIndex = 1;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar
            // 
            Btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar.Location = new Point(86, 25);
            Btn_Aceptar.Margin = new Padding(4, 5, 4, 5);
            Btn_Aceptar.Name = "Btn_Aceptar";
            Btn_Aceptar.Size = new Size(1845, 0);
            Btn_Aceptar.TabIndex = 0;
            Btn_Aceptar.Text = "Aceptar";
            Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // V_CRUD_Add_Act
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 516);
            Controls.Add(Pnl_CRUD_Add_Act);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "V_CRUD_Add_Act";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Actividad";
            Pnl_CRUD_Add_Act.ResumeLayout(false);
            Pnl_CRUD_Add_Act.PerformLayout();
            Pnl_Add.ResumeLayout(false);
            Pnl_Add.PerformLayout();
            Pnl_Buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_CRUD_Add_Act;
        private Panel Pnl_Buttons;
        private Button Btn_Cancelar_Prov1;
        private Button Btn_Aceptar_Prov1;
        private Button Btn_Cancelar_Emp1;
        private Button Btn_Aceptar_Emp1;
        private Button Btn_Cancelar;
        private Button Btn_Aceptar;
        private Button Btn_Cancelar_Act1;
        private Button Btn_Asignar_Act1;
        private Panel Pnl_Add;
        private ComboBox BoxEmpleado;
        private Label label3;
        private ComboBox BoxEmpProv;
        private TextBox txtDescripAct;
        private Label Lbl_Notas;
        private TextBox txtNombreAct;
        private Label label4;
        private Label label2;
        private TextBox txtProyecto;
        private Label label0;
    }
}