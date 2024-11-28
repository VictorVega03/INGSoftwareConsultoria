namespace Vistas
{
    partial class V_CRUD_Upd_Act
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
            Pnl_CRUD_Upd_Act = new Panel();
            Pnl_Add = new Panel();
            txtIDActivity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtProyecto = new TextBox();
            BoxEmpleado = new ComboBox();
            label3 = new Label();
            label0 = new Label();
            BoxEstado = new ComboBox();
            BoxEmpProv = new ComboBox();
            txtDescripAct = new TextBox();
            Lbl_Notas = new Label();
            txtNombreAct = new TextBox();
            label5 = new Label();
            label4 = new Label();
            Pnl_Buttons = new Panel();
            Btn_Cancelar_Act = new Button();
            Btn_Asignar_Act = new Button();
            Btn_Cancelar_Act1 = new Button();
            Btn_Asignar_Act1 = new Button();
            Btn_Cancelar_Prov1 = new Button();
            Btn_Aceptar_Prov1 = new Button();
            Btn_Cancelar_Emp1 = new Button();
            Btn_Aceptar_Emp1 = new Button();
            Btn_Cancelar = new Button();
            Btn_Aceptar = new Button();
            Pnl_CRUD_Upd_Act.SuspendLayout();
            Pnl_Add.SuspendLayout();
            Pnl_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_CRUD_Upd_Act
            // 
            Pnl_CRUD_Upd_Act.Controls.Add(Pnl_Add);
            Pnl_CRUD_Upd_Act.Controls.Add(Pnl_Buttons);
            Pnl_CRUD_Upd_Act.Dock = DockStyle.Fill;
            Pnl_CRUD_Upd_Act.Location = new Point(0, 0);
            Pnl_CRUD_Upd_Act.Margin = new Padding(3, 4, 3, 4);
            Pnl_CRUD_Upd_Act.Name = "Pnl_CRUD_Upd_Act";
            Pnl_CRUD_Upd_Act.Size = new Size(1015, 413);
            Pnl_CRUD_Upd_Act.TabIndex = 4;
            // 
            // Pnl_Add
            // 
            Pnl_Add.AutoSize = true;
            Pnl_Add.BackColor = Color.White;
            Pnl_Add.Controls.Add(txtIDActivity);
            Pnl_Add.Controls.Add(label2);
            Pnl_Add.Controls.Add(label1);
            Pnl_Add.Controls.Add(txtProyecto);
            Pnl_Add.Controls.Add(BoxEmpleado);
            Pnl_Add.Controls.Add(label3);
            Pnl_Add.Controls.Add(label0);
            Pnl_Add.Controls.Add(BoxEstado);
            Pnl_Add.Controls.Add(BoxEmpProv);
            Pnl_Add.Controls.Add(txtDescripAct);
            Pnl_Add.Controls.Add(Lbl_Notas);
            Pnl_Add.Controls.Add(txtNombreAct);
            Pnl_Add.Controls.Add(label5);
            Pnl_Add.Controls.Add(label4);
            Pnl_Add.Dock = DockStyle.Fill;
            Pnl_Add.Location = new Point(0, 0);
            Pnl_Add.Margin = new Padding(3, 4, 3, 4);
            Pnl_Add.Name = "Pnl_Add";
            Pnl_Add.Size = new Size(1015, 333);
            Pnl_Add.TabIndex = 4;
            // 
            // txtIDActivity
            // 
            txtIDActivity.Enabled = false;
            txtIDActivity.Font = new Font("Segoe UI", 11F);
            txtIDActivity.Location = new Point(241, 64);
            txtIDActivity.Margin = new Padding(3, 4, 3, 4);
            txtIDActivity.Name = "txtIDActivity";
            txtIDActivity.ReadOnly = true;
            txtIDActivity.Size = new Size(257, 32);
            txtIDActivity.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 29;
            label2.Text = "Nombre de Actividad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 28;
            label1.Text = "ID de Actividad:";
            // 
            // txtProyecto
            // 
            txtProyecto.Enabled = false;
            txtProyecto.Font = new Font("Segoe UI", 11F);
            txtProyecto.Location = new Point(241, 13);
            txtProyecto.Margin = new Padding(3, 4, 3, 4);
            txtProyecto.Name = "txtProyecto";
            txtProyecto.ReadOnly = true;
            txtProyecto.Size = new Size(257, 32);
            txtProyecto.TabIndex = 27;
            // 
            // BoxEmpleado
            // 
            BoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxEmpleado.Font = new Font("Segoe UI", 9F);
            BoxEmpleado.FormattingEnabled = true;
            BoxEmpleado.Location = new Point(241, 212);
            BoxEmpleado.Margin = new Padding(3, 4, 3, 4);
            BoxEmpleado.Name = "BoxEmpleado";
            BoxEmpleado.Size = new Size(257, 28);
            BoxEmpleado.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 212);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 26;
            label3.Text = "Asignar Empleado:";
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Segoe UI", 11F);
            label0.Location = new Point(12, 20);
            label0.Name = "label0";
            label0.Size = new Size(144, 25);
            label0.TabIndex = 24;
            label0.Text = "ID del Proyecto:";
            // 
            // BoxEstado
            // 
            BoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxEstado.FormattingEnabled = true;
            BoxEstado.Location = new Point(241, 163);
            BoxEstado.Name = "BoxEstado";
            BoxEstado.Size = new Size(257, 28);
            BoxEstado.TabIndex = 5;
            // 
            // BoxEmpProv
            // 
            BoxEmpProv.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxEmpProv.FormattingEnabled = true;
            BoxEmpProv.Location = new Point(241, 262);
            BoxEmpProv.Name = "BoxEmpProv";
            BoxEmpProv.Size = new Size(257, 28);
            BoxEmpProv.TabIndex = 4;
            // 
            // txtDescripAct
            // 
            txtDescripAct.BackColor = SystemColors.Control;
            txtDescripAct.Font = new Font("Segoe UI", 11F);
            txtDescripAct.Location = new Point(515, 48);
            txtDescripAct.Margin = new Padding(3, 4, 3, 4);
            txtDescripAct.Multiline = true;
            txtDescripAct.Name = "txtDescripAct";
            txtDescripAct.Size = new Size(488, 281);
            txtDescripAct.TabIndex = 21;
            // 
            // Lbl_Notas
            // 
            Lbl_Notas.AutoSize = true;
            Lbl_Notas.Font = new Font("Segoe UI", 11F);
            Lbl_Notas.Location = new Point(515, 9);
            Lbl_Notas.Name = "Lbl_Notas";
            Lbl_Notas.Size = new Size(244, 25);
            Lbl_Notas.TabIndex = 19;
            Lbl_Notas.Text = "Descripción de la Actividad:";
            // 
            // txtNombreAct
            // 
            txtNombreAct.Font = new Font("Segoe UI", 11F);
            txtNombreAct.Location = new Point(241, 114);
            txtNombreAct.Margin = new Padding(3, 4, 3, 4);
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(257, 32);
            txtNombreAct.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 7;
            label5.Text = "Estado de Actividad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(12, 265);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 6;
            label4.Text = "Empleado de Proveedor:";
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Act);
            Pnl_Buttons.Controls.Add(Btn_Asignar_Act);
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Act1);
            Pnl_Buttons.Controls.Add(Btn_Asignar_Act1);
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Prov1);
            Pnl_Buttons.Controls.Add(Btn_Aceptar_Prov1);
            Pnl_Buttons.Controls.Add(Btn_Cancelar_Emp1);
            Pnl_Buttons.Controls.Add(Btn_Aceptar_Emp1);
            Pnl_Buttons.Controls.Add(Btn_Cancelar);
            Pnl_Buttons.Controls.Add(Btn_Aceptar);
            Pnl_Buttons.Dock = DockStyle.Bottom;
            Pnl_Buttons.Location = new Point(0, 333);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new Size(1015, 80);
            Pnl_Buttons.TabIndex = 1;
            // 
            // Btn_Cancelar_Act
            // 
            Btn_Cancelar_Act.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Act.BackColor = Color.DarkRed;
            Btn_Cancelar_Act.Cursor = Cursors.Hand;
            Btn_Cancelar_Act.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Act.ForeColor = Color.White;
            Btn_Cancelar_Act.Location = new Point(543, 20);
            Btn_Cancelar_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_Cancelar_Act.Name = "Btn_Cancelar_Act";
            Btn_Cancelar_Act.Size = new Size(278, 40);
            Btn_Cancelar_Act.TabIndex = 11;
            Btn_Cancelar_Act.Text = "Cancelar";
            Btn_Cancelar_Act.UseVisualStyleBackColor = false;
            Btn_Cancelar_Act.Click += Btn_Cancelar_Click;
            // 
            // Btn_Asignar_Act
            // 
            Btn_Asignar_Act.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Asignar_Act.BackColor = Color.Green;
            Btn_Asignar_Act.Cursor = Cursors.Hand;
            Btn_Asignar_Act.Font = new Font("Segoe UI", 11F);
            Btn_Asignar_Act.ForeColor = Color.White;
            Btn_Asignar_Act.Location = new Point(161, 20);
            Btn_Asignar_Act.Margin = new Padding(3, 4, 3, 4);
            Btn_Asignar_Act.Name = "Btn_Asignar_Act";
            Btn_Asignar_Act.Size = new Size(278, 40);
            Btn_Asignar_Act.TabIndex = 10;
            Btn_Asignar_Act.Text = "Aceptar";
            Btn_Asignar_Act.UseVisualStyleBackColor = false;
            Btn_Asignar_Act.Click += Btn_Aceptar_Click;
            // 
            // Btn_Cancelar_Act1
            // 
            Btn_Cancelar_Act1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Act1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Act1.Location = new Point(333, 20);
            Btn_Cancelar_Act1.Margin = new Padding(3, 4, 3, 4);
            Btn_Cancelar_Act1.Name = "Btn_Cancelar_Act1";
            Btn_Cancelar_Act1.Size = new Size(901, 0);
            Btn_Cancelar_Act1.TabIndex = 9;
            Btn_Cancelar_Act1.Text = "Cancelar";
            Btn_Cancelar_Act1.UseVisualStyleBackColor = true;
            // 
            // Btn_Asignar_Act1
            // 
            Btn_Asignar_Act1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Asignar_Act1.Font = new Font("Segoe UI", 11F);
            Btn_Asignar_Act1.Location = new Point(88, 20);
            Btn_Asignar_Act1.Margin = new Padding(3, 4, 3, 4);
            Btn_Asignar_Act1.Name = "Btn_Asignar_Act1";
            Btn_Asignar_Act1.Size = new Size(901, 0);
            Btn_Asignar_Act1.TabIndex = 8;
            Btn_Asignar_Act1.Text = "Asignar";
            Btn_Asignar_Act1.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar_Prov1
            // 
            Btn_Cancelar_Prov1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Prov1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Prov1.Location = new Point(333, 20);
            Btn_Cancelar_Prov1.Margin = new Padding(3, 4, 3, 4);
            Btn_Cancelar_Prov1.Name = "Btn_Cancelar_Prov1";
            Btn_Cancelar_Prov1.Size = new Size(1208, 0);
            Btn_Cancelar_Prov1.TabIndex = 7;
            Btn_Cancelar_Prov1.Text = "Cancelar";
            Btn_Cancelar_Prov1.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar_Prov1
            // 
            Btn_Aceptar_Prov1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar_Prov1.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar_Prov1.Location = new Point(88, 20);
            Btn_Aceptar_Prov1.Margin = new Padding(3, 4, 3, 4);
            Btn_Aceptar_Prov1.Name = "Btn_Aceptar_Prov1";
            Btn_Aceptar_Prov1.Size = new Size(1208, 0);
            Btn_Aceptar_Prov1.TabIndex = 6;
            Btn_Aceptar_Prov1.Text = "Aceptar";
            Btn_Aceptar_Prov1.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar_Emp1
            // 
            Btn_Cancelar_Emp1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar_Emp1.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar_Emp1.Location = new Point(313, 20);
            Btn_Cancelar_Emp1.Margin = new Padding(3, 4, 3, 4);
            Btn_Cancelar_Emp1.Name = "Btn_Cancelar_Emp1";
            Btn_Cancelar_Emp1.Size = new Size(1516, 0);
            Btn_Cancelar_Emp1.TabIndex = 3;
            Btn_Cancelar_Emp1.Text = "Cancelar";
            Btn_Cancelar_Emp1.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar_Emp1
            // 
            Btn_Aceptar_Emp1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar_Emp1.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar_Emp1.Location = new Point(69, 20);
            Btn_Aceptar_Emp1.Margin = new Padding(3, 4, 3, 4);
            Btn_Aceptar_Emp1.Name = "Btn_Aceptar_Emp1";
            Btn_Aceptar_Emp1.Size = new Size(1516, 0);
            Btn_Aceptar_Emp1.TabIndex = 2;
            Btn_Aceptar_Emp1.Text = "Aceptar";
            Btn_Aceptar_Emp1.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Cancelar.Font = new Font("Segoe UI", 11F);
            Btn_Cancelar.Location = new Point(313, 20);
            Btn_Cancelar.Margin = new Padding(3, 4, 3, 4);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(1783, 0);
            Btn_Cancelar.TabIndex = 1;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar
            // 
            Btn_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_Aceptar.Font = new Font("Segoe UI", 11F);
            Btn_Aceptar.Location = new Point(69, 20);
            Btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            Btn_Aceptar.Name = "Btn_Aceptar";
            Btn_Aceptar.Size = new Size(1783, 0);
            Btn_Aceptar.TabIndex = 0;
            Btn_Aceptar.Text = "Aceptar";
            Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // V_CRUD_Upd_Act
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 413);
            Controls.Add(Pnl_CRUD_Upd_Act);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "V_CRUD_Upd_Act";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Actividad";
            Pnl_CRUD_Upd_Act.ResumeLayout(false);
            Pnl_CRUD_Upd_Act.PerformLayout();
            Pnl_Add.ResumeLayout(false);
            Pnl_Add.PerformLayout();
            Pnl_Buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_CRUD_Upd_Act;
        private Panel Pnl_Buttons;
        private Button Btn_Cancelar_Act1;
        private Button Btn_Asignar_Act1;
        private Button Btn_Cancelar_Prov1;
        private Button Btn_Aceptar_Prov1;
        private Button Btn_Cancelar_Emp1;
        private Button Btn_Aceptar_Emp1;
        private Button Btn_Cancelar;
        private Button Btn_Aceptar;
        private Button Btn_Cancelar_Act;
        private Button Btn_Asignar_Act;
        private Panel Pnl_Add;
        private Label label2;
        private Label label1;
        private TextBox txtProyecto;
        private ComboBox BoxEmpleado;
        private Label label3;
        private Label label0;
        private ComboBox BoxEstado;
        private ComboBox BoxEmpProv;
        private TextBox txtDescripAct;
        private Label Lbl_Notas;
        private TextBox txtNombreAct;
        private Label label5;
        private Label label4;
        private TextBox txtIDActivity;
    }
}