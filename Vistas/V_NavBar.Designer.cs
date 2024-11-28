namespace Vistas
{
    partial class V_NavBar
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
            Pnl_NavBar = new Panel();
            Pnl_Center = new Panel();
            TxtBuscador = new TextBox();
            Pnl_Right = new Panel();
            panel1 = new Panel();
            BcerrarSesion = new Button();
            Pnl_NameUser = new Panel();
            Lbl_NameUser = new Label();
            Pnl_Left = new Panel();
            Pnl_MnS = new Panel();
            MnS_NavBar = new MenuStrip();
            TSMI_Inicio = new ToolStripMenuItem();
            TSMI_Ventanas = new ToolStripMenuItem();
            TSMI_Proyect = new ToolStripMenuItem();
            historialDeProyectosToolStripMenuItem = new ToolStripMenuItem();
            TSMI_Prov = new ToolStripMenuItem();
            empleadosProvToolStripMenuItem = new ToolStripMenuItem();
            TSMI_Emp = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            Pnl_Logo = new Panel();
            PicB_Logo = new PictureBox();
            Pnl_Content = new Panel();
            Pnl_NavBar.SuspendLayout();
            Pnl_Center.SuspendLayout();
            Pnl_Right.SuspendLayout();
            panel1.SuspendLayout();
            Pnl_NameUser.SuspendLayout();
            Pnl_Left.SuspendLayout();
            Pnl_MnS.SuspendLayout();
            MnS_NavBar.SuspendLayout();
            Pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicB_Logo).BeginInit();
            SuspendLayout();
            // 
            // Pnl_NavBar
            // 
            Pnl_NavBar.BackColor = Color.FromArgb(27, 29, 42);
            Pnl_NavBar.Controls.Add(Pnl_Center);
            Pnl_NavBar.Controls.Add(Pnl_Right);
            Pnl_NavBar.Controls.Add(Pnl_Left);
            Pnl_NavBar.Dock = DockStyle.Top;
            Pnl_NavBar.Location = new Point(0, 0);
            Pnl_NavBar.Margin = new Padding(3, 4, 3, 4);
            Pnl_NavBar.Name = "Pnl_NavBar";
            Pnl_NavBar.Padding = new Padding(51, 0, 51, 0);
            Pnl_NavBar.Size = new Size(1500, 80);
            Pnl_NavBar.TabIndex = 1;
            // 
            // Pnl_Center
            // 
            Pnl_Center.Controls.Add(TxtBuscador);
            Pnl_Center.Dock = DockStyle.Fill;
            Pnl_Center.Location = new Point(534, 0);
            Pnl_Center.Margin = new Padding(3, 4, 3, 4);
            Pnl_Center.Name = "Pnl_Center";
            Pnl_Center.Padding = new Padding(29, 20, 29, 0);
            Pnl_Center.Size = new Size(490, 80);
            Pnl_Center.TabIndex = 3;
            // 
            // TxtBuscador
            // 
            TxtBuscador.Dock = DockStyle.Fill;
            TxtBuscador.Font = new Font("Segoe UI", 11F);
            TxtBuscador.Location = new Point(29, 20);
            TxtBuscador.Margin = new Padding(3, 4, 3, 4);
            TxtBuscador.Name = "TxtBuscador";
            TxtBuscador.Size = new Size(432, 32);
            TxtBuscador.TabIndex = 0;
            TxtBuscador.Text = "Buscar";
            TxtBuscador.TextChanged += TxtBuscador_TextChanged;
            // 
            // Pnl_Right
            // 
            Pnl_Right.Controls.Add(panel1);
            Pnl_Right.Controls.Add(Pnl_NameUser);
            Pnl_Right.Dock = DockStyle.Right;
            Pnl_Right.Location = new Point(1024, 0);
            Pnl_Right.Margin = new Padding(3, 4, 3, 4);
            Pnl_Right.Name = "Pnl_Right";
            Pnl_Right.Size = new Size(425, 80);
            Pnl_Right.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(BcerrarSesion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(314, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 15, 0, 15);
            panel1.Size = new Size(111, 80);
            panel1.TabIndex = 3;
            // 
            // BcerrarSesion
            // 
            BcerrarSesion.BackColor = SystemColors.ActiveCaption;
            BcerrarSesion.Dock = DockStyle.Fill;
            BcerrarSesion.Location = new Point(0, 15);
            BcerrarSesion.Name = "BcerrarSesion";
            BcerrarSesion.Size = new Size(111, 50);
            BcerrarSesion.TabIndex = 5;
            BcerrarSesion.Text = "Cerrar Sesion";
            BcerrarSesion.UseVisualStyleBackColor = false;
            BcerrarSesion.Click += BCerrarSesion_Click;
            // 
            // Pnl_NameUser
            // 
            Pnl_NameUser.Controls.Add(Lbl_NameUser);
            Pnl_NameUser.Dock = DockStyle.Left;
            Pnl_NameUser.Location = new Point(0, 0);
            Pnl_NameUser.Margin = new Padding(3, 4, 3, 4);
            Pnl_NameUser.Name = "Pnl_NameUser";
            Pnl_NameUser.Size = new Size(314, 80);
            Pnl_NameUser.TabIndex = 1;
            // 
            // Lbl_NameUser
            // 
            Lbl_NameUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lbl_NameUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_NameUser.ForeColor = Color.FromArgb(245, 246, 251);
            Lbl_NameUser.Location = new Point(6, 21);
            Lbl_NameUser.Margin = new Padding(0);
            Lbl_NameUser.Name = "Lbl_NameUser";
            Lbl_NameUser.RightToLeft = RightToLeft.No;
            Lbl_NameUser.Size = new Size(296, 32);
            Lbl_NameUser.TabIndex = 0;
            Lbl_NameUser.Text = "Mireles Jimenez Josthin Damian";
            Lbl_NameUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pnl_Left
            // 
            Pnl_Left.BackColor = Color.FromArgb(25, 29, 42);
            Pnl_Left.Controls.Add(Pnl_MnS);
            Pnl_Left.Controls.Add(Pnl_Logo);
            Pnl_Left.Dock = DockStyle.Left;
            Pnl_Left.Location = new Point(51, 0);
            Pnl_Left.Margin = new Padding(3, 4, 3, 4);
            Pnl_Left.Name = "Pnl_Left";
            Pnl_Left.Size = new Size(483, 80);
            Pnl_Left.TabIndex = 0;
            // 
            // Pnl_MnS
            // 
            Pnl_MnS.Controls.Add(MnS_NavBar);
            Pnl_MnS.Dock = DockStyle.Fill;
            Pnl_MnS.Location = new Point(200, 0);
            Pnl_MnS.Margin = new Padding(3, 4, 3, 4);
            Pnl_MnS.Name = "Pnl_MnS";
            Pnl_MnS.Size = new Size(283, 80);
            Pnl_MnS.TabIndex = 1;
            // 
            // MnS_NavBar
            // 
            MnS_NavBar.AutoSize = false;
            MnS_NavBar.BackColor = Color.FromArgb(25, 29, 42);
            MnS_NavBar.Dock = DockStyle.Fill;
            MnS_NavBar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MnS_NavBar.GripMargin = new Padding(2);
            MnS_NavBar.ImageScalingSize = new Size(20, 20);
            MnS_NavBar.Items.AddRange(new ToolStripItem[] { TSMI_Inicio, TSMI_Ventanas });
            MnS_NavBar.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            MnS_NavBar.Location = new Point(0, 0);
            MnS_NavBar.Name = "MnS_NavBar";
            MnS_NavBar.Padding = new Padding(6, 0, 0, 0);
            MnS_NavBar.RenderMode = ToolStripRenderMode.Professional;
            MnS_NavBar.Size = new Size(283, 80);
            MnS_NavBar.TabIndex = 0;
            // 
            // TSMI_Inicio
            // 
            TSMI_Inicio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TSMI_Inicio.ForeColor = Color.White;
            TSMI_Inicio.Name = "TSMI_Inicio";
            TSMI_Inicio.Size = new Size(73, 80);
            TSMI_Inicio.Text = "Inicio";
            TSMI_Inicio.Click += TSMI_Inicio_Click;
            // 
            // TSMI_Ventanas
            // 
            TSMI_Ventanas.BackColor = Color.FromArgb(27, 29, 42);
            TSMI_Ventanas.BackgroundImageLayout = ImageLayout.None;
            TSMI_Ventanas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSMI_Ventanas.DropDownItems.AddRange(new ToolStripItem[] { TSMI_Proyect, TSMI_Prov, empleadosProvToolStripMenuItem, TSMI_Emp, clientesToolStripMenuItem });
            TSMI_Ventanas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TSMI_Ventanas.ForeColor = Color.White;
            TSMI_Ventanas.ImageTransparentColor = SystemColors.ActiveCaption;
            TSMI_Ventanas.Name = "TSMI_Ventanas";
            TSMI_Ventanas.Size = new Size(104, 80);
            TSMI_Ventanas.Text = "Ventanas";
            TSMI_Ventanas.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // TSMI_Proyect
            // 
            TSMI_Proyect.DropDownItems.AddRange(new ToolStripItem[] { historialDeProyectosToolStripMenuItem });
            TSMI_Proyect.Name = "TSMI_Proyect";
            TSMI_Proyect.Size = new Size(235, 30);
            TSMI_Proyect.Text = "Proyectos";
            TSMI_Proyect.Click += TSMI_Proyect_Click;
            // 
            // historialDeProyectosToolStripMenuItem
            // 
            historialDeProyectosToolStripMenuItem.Name = "historialDeProyectosToolStripMenuItem";
            historialDeProyectosToolStripMenuItem.Size = new Size(285, 30);
            historialDeProyectosToolStripMenuItem.Text = "Historial de Proyectos";
            historialDeProyectosToolStripMenuItem.Click += TSMI_Hist_Proyect_Click;
            // 
            // TSMI_Prov
            // 
            TSMI_Prov.Name = "TSMI_Prov";
            TSMI_Prov.Size = new Size(235, 30);
            TSMI_Prov.Text = "Proveedores";
            TSMI_Prov.Click += TSMI_Prov_Click;
            // 
            // empleadosProvToolStripMenuItem
            // 
            empleadosProvToolStripMenuItem.Name = "empleadosProvToolStripMenuItem";
            empleadosProvToolStripMenuItem.Size = new Size(235, 30);
            empleadosProvToolStripMenuItem.Text = "Empleados Prov";
            empleadosProvToolStripMenuItem.Click += TSMI_Emp_Prov_Click;
            // 
            // TSMI_Emp
            // 
            TSMI_Emp.Name = "TSMI_Emp";
            TSMI_Emp.Size = new Size(235, 30);
            TSMI_Emp.Text = "Empleados";
            TSMI_Emp.Click += TSMI_Emp_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(235, 30);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += TSMI_Client_Click;
            // 
            // Pnl_Logo
            // 
            Pnl_Logo.Controls.Add(PicB_Logo);
            Pnl_Logo.Dock = DockStyle.Left;
            Pnl_Logo.Location = new Point(0, 0);
            Pnl_Logo.Margin = new Padding(3, 4, 3, 4);
            Pnl_Logo.Name = "Pnl_Logo";
            Pnl_Logo.Size = new Size(200, 80);
            Pnl_Logo.TabIndex = 0;
            // 
            // PicB_Logo
            // 
            PicB_Logo.Dock = DockStyle.Fill;
            PicB_Logo.Location = new Point(0, 0);
            PicB_Logo.Margin = new Padding(3, 4, 3, 4);
            PicB_Logo.Name = "PicB_Logo";
            PicB_Logo.Size = new Size(200, 80);
            PicB_Logo.TabIndex = 0;
            PicB_Logo.TabStop = false;
            // 
            // Pnl_Content
            // 
            Pnl_Content.BackColor = Color.FromArgb(27, 29, 42);
            Pnl_Content.Dock = DockStyle.Fill;
            Pnl_Content.Location = new Point(0, 80);
            Pnl_Content.Margin = new Padding(3, 4, 3, 4);
            Pnl_Content.Name = "Pnl_Content";
            Pnl_Content.Padding = new Padding(0, 0, 0, 60);
            Pnl_Content.Size = new Size(1500, 520);
            Pnl_Content.TabIndex = 2;
            // 
            // V_NavBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 600);
            Controls.Add(Pnl_Content);
            Controls.Add(Pnl_NavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_NavBar";
            Text = "V_NavBar";
            Load += V_NavBar_Load;
            Pnl_NavBar.ResumeLayout(false);
            Pnl_Center.ResumeLayout(false);
            Pnl_Center.PerformLayout();
            Pnl_Right.ResumeLayout(false);
            panel1.ResumeLayout(false);
            Pnl_NameUser.ResumeLayout(false);
            Pnl_Left.ResumeLayout(false);
            Pnl_MnS.ResumeLayout(false);
            MnS_NavBar.ResumeLayout(false);
            MnS_NavBar.PerformLayout();
            Pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicB_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_NavBar;
        private Panel Pnl_Center;
        private TextBox TxtBuscador;
        private Panel Pnl_Right;
        private Panel Pnl_NameUser;
        private Label Lbl_NameUser;
        private Panel Pnl_Left;
        private Panel Pnl_MnS;
        private MenuStrip MnS_NavBar;
        private ToolStripMenuItem TSMI_Inicio;
        private ToolStripMenuItem TSMI_Ventanas;
        private Panel Pnl_Logo;
        private PictureBox PicB_Logo;
        private Panel Pnl_Content;
        private ToolStripMenuItem TSMI_Proyect;
        private ToolStripMenuItem TSMI_Prov;
        private ToolStripMenuItem TSMI_Emp;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem historialDeProyectosToolStripMenuItem;
        private Button BcerrarSesion;
        private Panel panel1;
        private ToolStripMenuItem empleadosProvToolStripMenuItem;
    }
}