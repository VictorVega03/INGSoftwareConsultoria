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
            Pnl_NavBar_Principal = new Panel();
            Pnl_Content = new Panel();
            Pnl_NavBar = new Panel();
            Pnl_Right = new Panel();
            Pnl_NameUser = new Panel();
            Lbl_NameUser = new Label();
            Pnl_IconUser = new Panel();
            PicB_IconUser = new PictureBox();
            Pnl_Left = new Panel();
            Pnl_MnS = new Panel();
            MnS_NavBar = new MenuStrip();
            TSMI_Inicio = new ToolStripMenuItem();
            TSMI_Ventanas = new ToolStripMenuItem();
            TSMI_Proyect = new ToolStripMenuItem();
            TSMI_Hist_Proyect = new ToolStripMenuItem();
            TSMI_Activity = new ToolStripMenuItem();
            TSMI_Hist_Activity = new ToolStripMenuItem();
            TSMI_Prov = new ToolStripMenuItem();
            TSMI_Emp_Prov = new ToolStripMenuItem();
            TSMI_Emp = new ToolStripMenuItem();
            TSMI_Client = new ToolStripMenuItem();
            Pnl_Logo = new Panel();
            PicB_Logo = new PictureBox();
            Pnl_NavBar_Principal.SuspendLayout();
            Pnl_NavBar.SuspendLayout();
            Pnl_Right.SuspendLayout();
            Pnl_NameUser.SuspendLayout();
            Pnl_IconUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicB_IconUser).BeginInit();
            Pnl_Left.SuspendLayout();
            Pnl_MnS.SuspendLayout();
            MnS_NavBar.SuspendLayout();
            Pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicB_Logo).BeginInit();
            SuspendLayout();
            // 
            // Pnl_NavBar_Principal
            // 
            Pnl_NavBar_Principal.Controls.Add(Pnl_Content);
            Pnl_NavBar_Principal.Controls.Add(Pnl_NavBar);
            Pnl_NavBar_Principal.Dock = DockStyle.Fill;
            Pnl_NavBar_Principal.Location = new Point(0, 0);
            Pnl_NavBar_Principal.Name = "Pnl_NavBar_Principal";
            Pnl_NavBar_Principal.Size = new Size(800, 450);
            Pnl_NavBar_Principal.TabIndex = 0;
            // 
            // Pnl_Content
            // 
            Pnl_Content.Dock = DockStyle.Fill;
            Pnl_Content.Location = new Point(0, 60);
            Pnl_Content.Name = "Pnl_Content";
            Pnl_Content.Padding = new Padding(0, 0, 0, 45);
            Pnl_Content.Size = new Size(800, 390);
            Pnl_Content.TabIndex = 1;
            // 
            // Pnl_NavBar
            // 
            Pnl_NavBar.Controls.Add(Pnl_Right);
            Pnl_NavBar.Controls.Add(Pnl_Left);
            Pnl_NavBar.Dock = DockStyle.Top;
            Pnl_NavBar.Location = new Point(0, 0);
            Pnl_NavBar.Name = "Pnl_NavBar";
            Pnl_NavBar.Padding = new Padding(45, 0, 45, 0);
            Pnl_NavBar.Size = new Size(800, 60);
            Pnl_NavBar.TabIndex = 0;
            // 
            // Pnl_Right
            // 
            Pnl_Right.Controls.Add(Pnl_NameUser);
            Pnl_Right.Controls.Add(Pnl_IconUser);
            Pnl_Right.Dock = DockStyle.Right;
            Pnl_Right.Location = new Point(455, 0);
            Pnl_Right.Name = "Pnl_Right";
            Pnl_Right.Size = new Size(300, 60);
            Pnl_Right.TabIndex = 2;
            // 
            // Pnl_NameUser
            // 
            Pnl_NameUser.Controls.Add(Lbl_NameUser);
            Pnl_NameUser.Dock = DockStyle.Left;
            Pnl_NameUser.Location = new Point(0, 0);
            Pnl_NameUser.Name = "Pnl_NameUser";
            Pnl_NameUser.Size = new Size(240, 60);
            Pnl_NameUser.TabIndex = 1;
            // 
            // Lbl_NameUser
            // 
            Lbl_NameUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lbl_NameUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_NameUser.Location = new Point(9, 19);
            Lbl_NameUser.Margin = new Padding(0);
            Lbl_NameUser.Name = "Lbl_NameUser";
            Lbl_NameUser.RightToLeft = RightToLeft.No;
            Lbl_NameUser.Size = new Size(219, 20);
            Lbl_NameUser.TabIndex = 0;
            Lbl_NameUser.Text = "Mireles Jimenez Josthin Damian";
            Lbl_NameUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pnl_IconUser
            // 
            Pnl_IconUser.Controls.Add(PicB_IconUser);
            Pnl_IconUser.Dock = DockStyle.Right;
            Pnl_IconUser.Location = new Point(240, 0);
            Pnl_IconUser.Name = "Pnl_IconUser";
            Pnl_IconUser.Size = new Size(60, 60);
            Pnl_IconUser.TabIndex = 0;
            // 
            // PicB_IconUser
            // 
            PicB_IconUser.Dock = DockStyle.Fill;
            PicB_IconUser.Location = new Point(0, 0);
            PicB_IconUser.Name = "PicB_IconUser";
            PicB_IconUser.Size = new Size(60, 60);
            PicB_IconUser.TabIndex = 0;
            PicB_IconUser.TabStop = false;
            // 
            // Pnl_Left
            // 
            Pnl_Left.Controls.Add(Pnl_MnS);
            Pnl_Left.Controls.Add(Pnl_Logo);
            Pnl_Left.Dock = DockStyle.Left;
            Pnl_Left.Location = new Point(45, 0);
            Pnl_Left.Name = "Pnl_Left";
            Pnl_Left.Size = new Size(423, 60);
            Pnl_Left.TabIndex = 0;
            // 
            // Pnl_MnS
            // 
            Pnl_MnS.Controls.Add(MnS_NavBar);
            Pnl_MnS.Dock = DockStyle.Fill;
            Pnl_MnS.Location = new Point(175, 0);
            Pnl_MnS.Name = "Pnl_MnS";
            Pnl_MnS.Size = new Size(248, 60);
            Pnl_MnS.TabIndex = 1;
            // 
            // MnS_NavBar
            // 
            MnS_NavBar.Dock = DockStyle.Fill;
            MnS_NavBar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MnS_NavBar.Items.AddRange(new ToolStripItem[] { TSMI_Inicio, TSMI_Ventanas });
            MnS_NavBar.Location = new Point(0, 0);
            MnS_NavBar.Name = "MnS_NavBar";
            MnS_NavBar.RenderMode = ToolStripRenderMode.System;
            MnS_NavBar.Size = new Size(248, 60);
            MnS_NavBar.TabIndex = 0;
            // 
            // TSMI_Inicio
            // 
            TSMI_Inicio.Name = "TSMI_Inicio";
            TSMI_Inicio.Size = new Size(57, 56);
            TSMI_Inicio.Text = "Inicio";
            TSMI_Inicio.Click += TSMI_Inicio_Click;
            // 
            // TSMI_Ventanas
            // 
            TSMI_Ventanas.DropDownItems.AddRange(new ToolStripItem[] { TSMI_Proyect, TSMI_Activity, TSMI_Prov, TSMI_Emp, TSMI_Client });
            TSMI_Ventanas.Name = "TSMI_Ventanas";
            TSMI_Ventanas.Size = new Size(80, 56);
            TSMI_Ventanas.Text = "Ventanas";
            // 
            // TSMI_Proyect
            // 
            TSMI_Proyect.DropDownItems.AddRange(new ToolStripItem[] { TSMI_Hist_Proyect });
            TSMI_Proyect.Name = "TSMI_Proyect";
            TSMI_Proyect.Size = new Size(160, 24);
            TSMI_Proyect.Text = "Proyectos";
            TSMI_Proyect.Click += TSMI_Proyect_Click;
            // 
            // TSMI_Hist_Proyect
            // 
            TSMI_Hist_Proyect.Name = "TSMI_Hist_Proyect";
            TSMI_Hist_Proyect.Size = new Size(223, 24);
            TSMI_Hist_Proyect.Text = "Historial de Proyectos";
            TSMI_Hist_Proyect.Click += TSMI_Hist_Proyect_Click;
            // 
            // TSMI_Activity
            // 
            TSMI_Activity.DropDownItems.AddRange(new ToolStripItem[] { TSMI_Hist_Activity });
            TSMI_Activity.Name = "TSMI_Activity";
            TSMI_Activity.Size = new Size(160, 24);
            TSMI_Activity.Text = "Actividades";
            TSMI_Activity.Click += TSMI_Activity_Click;
            // 
            // TSMI_Hist_Activity
            // 
            TSMI_Hist_Activity.Name = "TSMI_Hist_Activity";
            TSMI_Hist_Activity.Size = new Size(236, 24);
            TSMI_Hist_Activity.Text = "Historial de Actividades";
            TSMI_Hist_Activity.Click += TSMI_Hist_Activity_Click;
            // 
            // TSMI_Prov
            // 
            TSMI_Prov.DropDownItems.AddRange(new ToolStripItem[] { TSMI_Emp_Prov });
            TSMI_Prov.Name = "TSMI_Prov";
            TSMI_Prov.Size = new Size(160, 24);
            TSMI_Prov.Text = "Proveedores";
            TSMI_Prov.Click += TSMI_Prov_Click;
            // 
            // TSMI_Emp_Prov
            // 
            TSMI_Emp_Prov.Name = "TSMI_Emp_Prov";
            TSMI_Emp_Prov.Size = new Size(282, 24);
            TSMI_Emp_Prov.Text = "Empleados de los Proveedores";
            TSMI_Emp_Prov.Click += TSMI_Emp_Prov_Click;
            // 
            // TSMI_Emp
            // 
            TSMI_Emp.Name = "TSMI_Emp";
            TSMI_Emp.Size = new Size(160, 24);
            TSMI_Emp.Text = "Empleados";
            TSMI_Emp.Click += TSMI_Emp_Click;
            // 
            // TSMI_Client
            // 
            TSMI_Client.Name = "TSMI_Client";
            TSMI_Client.Size = new Size(160, 24);
            TSMI_Client.Text = "Clientes";
            TSMI_Client.Click += TSMI_Client_Click;
            // 
            // Pnl_Logo
            // 
            Pnl_Logo.Controls.Add(PicB_Logo);
            Pnl_Logo.Dock = DockStyle.Left;
            Pnl_Logo.Location = new Point(0, 0);
            Pnl_Logo.Name = "Pnl_Logo";
            Pnl_Logo.Size = new Size(175, 60);
            Pnl_Logo.TabIndex = 0;
            // 
            // PicB_Logo
            // 
            PicB_Logo.Dock = DockStyle.Fill;
            PicB_Logo.Location = new Point(0, 0);
            PicB_Logo.Name = "PicB_Logo";
            PicB_Logo.Size = new Size(175, 60);
            PicB_Logo.TabIndex = 0;
            PicB_Logo.TabStop = false;
            // 
            // V_NavBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pnl_NavBar_Principal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_NavBar";
            Text = "V_NavBar";
            WindowState = FormWindowState.Maximized;
            Load += V_NavBar_Load;
            Pnl_NavBar_Principal.ResumeLayout(false);
            Pnl_NavBar.ResumeLayout(false);
            Pnl_Right.ResumeLayout(false);
            Pnl_NameUser.ResumeLayout(false);
            Pnl_IconUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicB_IconUser).EndInit();
            Pnl_Left.ResumeLayout(false);
            Pnl_MnS.ResumeLayout(false);
            Pnl_MnS.PerformLayout();
            MnS_NavBar.ResumeLayout(false);
            MnS_NavBar.PerformLayout();
            Pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicB_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_NavBar_Principal;
        private Panel Pnl_NavBar;
        private Panel Pnl_Right;
        private Panel Pnl_Left;
        private Panel Pnl_Content;
        private Panel Pnl_IconUser;
        private Panel Pnl_NameUser;
        private PictureBox PicB_IconUser;
        private Label Lbl_NameUser;
        private Panel Pnl_MnS;
        private Panel Pnl_Logo;
        private PictureBox PicB_Logo;
        private MenuStrip MnS_NavBar;
        private ToolStripMenuItem TSMI_Inicio;
        private ToolStripMenuItem TSMI_Ventanas;
        private ToolStripMenuItem TSMI_Proyect;
        private ToolStripMenuItem TSMI_Hist_Proyect;
        private ToolStripMenuItem TSMI_Activity;
        private ToolStripMenuItem TSMI_Hist_Activity;
        private ToolStripMenuItem TSMI_Client;
        private ToolStripMenuItem TSMI_Emp;
        private ToolStripMenuItem TSMI_Prov;
        private ToolStripMenuItem TSMI_Emp_Prov;
    }
}