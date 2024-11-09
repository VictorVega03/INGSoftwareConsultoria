namespace Vistas
{
    partial class V_Info_Proyect
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
            Pnl_Info_Proyect = new Panel();
            Txt_Info_Proyect = new TextBox();
            Txt_Name_Proyect = new TextBox();
            Lbl_Info_Proyect = new Label();
            Pnl_Info1 = new Panel();
            Pnl_Info2 = new Panel();
            Pnl_Button_ViewImg = new Panel();
            Btn_View_Img = new Button();
            Lbl_Info_Activity = new Label();
            Txt_Info_Activity = new TextBox();
            Pnl_Info_Proyect.SuspendLayout();
            Pnl_Info2.SuspendLayout();
            Pnl_Button_ViewImg.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Info_Proyect
            // 
            Pnl_Info_Proyect.Controls.Add(Lbl_Info_Proyect);
            Pnl_Info_Proyect.Controls.Add(Txt_Name_Proyect);
            Pnl_Info_Proyect.Controls.Add(Txt_Info_Proyect);
            Pnl_Info_Proyect.Controls.Add(Pnl_Info1);
            Pnl_Info_Proyect.Controls.Add(Pnl_Info2);
            Pnl_Info_Proyect.Dock = DockStyle.Fill;
            Pnl_Info_Proyect.Location = new Point(0, 0);
            Pnl_Info_Proyect.Name = "Pnl_Info_Proyect";
            Pnl_Info_Proyect.Size = new Size(719, 501);
            Pnl_Info_Proyect.TabIndex = 1;
            // 
            // Txt_Info_Proyect
            // 
            Txt_Info_Proyect.Location = new Point(30, 75);
            Txt_Info_Proyect.Multiline = true;
            Txt_Info_Proyect.Name = "Txt_Info_Proyect";
            Txt_Info_Proyect.ReadOnly = true;
            Txt_Info_Proyect.Size = new Size(375, 400);
            Txt_Info_Proyect.TabIndex = 2;
            // 
            // Txt_Name_Proyect
            // 
            Txt_Name_Proyect.Font = new Font("Segoe UI", 11F);
            Txt_Name_Proyect.Location = new Point(155, 20);
            Txt_Name_Proyect.Name = "Txt_Name_Proyect";
            Txt_Name_Proyect.ReadOnly = true;
            Txt_Name_Proyect.Size = new Size(250, 27);
            Txt_Name_Proyect.TabIndex = 1;
            Txt_Name_Proyect.TextAlign = HorizontalAlignment.Center;
            // 
            // Lbl_Info_Proyect
            // 
            Lbl_Info_Proyect.AutoSize = true;
            Lbl_Info_Proyect.Font = new Font("Segoe UI", 11F);
            Lbl_Info_Proyect.Location = new Point(30, 25);
            Lbl_Info_Proyect.Name = "Lbl_Info_Proyect";
            Lbl_Info_Proyect.Size = new Size(117, 20);
            Lbl_Info_Proyect.TabIndex = 0;
            Lbl_Info_Proyect.Text = "Información del:";
            // 
            // Pnl_Info1
            // 
            Pnl_Info1.AutoSize = true;
            Pnl_Info1.Dock = DockStyle.Fill;
            Pnl_Info1.Location = new Point(0, 0);
            Pnl_Info1.Name = "Pnl_Info1";
            Pnl_Info1.Size = new Size(419, 501);
            Pnl_Info1.TabIndex = 3;
            // 
            // Pnl_Info2
            // 
            Pnl_Info2.Controls.Add(Txt_Info_Activity);
            Pnl_Info2.Controls.Add(Lbl_Info_Activity);
            Pnl_Info2.Controls.Add(Pnl_Button_ViewImg);
            Pnl_Info2.Dock = DockStyle.Right;
            Pnl_Info2.Location = new Point(419, 0);
            Pnl_Info2.Name = "Pnl_Info2";
            Pnl_Info2.Size = new Size(300, 501);
            Pnl_Info2.TabIndex = 4;
            // 
            // Pnl_Button_ViewImg
            // 
            Pnl_Button_ViewImg.Controls.Add(Btn_View_Img);
            Pnl_Button_ViewImg.Dock = DockStyle.Bottom;
            Pnl_Button_ViewImg.Location = new Point(0, 441);
            Pnl_Button_ViewImg.Name = "Pnl_Button_ViewImg";
            Pnl_Button_ViewImg.Size = new Size(300, 60);
            Pnl_Button_ViewImg.TabIndex = 0;
            // 
            // Btn_View_Img
            // 
            Btn_View_Img.Font = new Font("Segoe UI", 11F);
            Btn_View_Img.Location = new Point(90, 15);
            Btn_View_Img.Name = "Btn_View_Img";
            Btn_View_Img.Size = new Size(125, 30);
            Btn_View_Img.TabIndex = 0;
            Btn_View_Img.Text = "Ver Imagenes";
            Btn_View_Img.UseVisualStyleBackColor = true;
            // 
            // Lbl_Info_Activity
            // 
            Lbl_Info_Activity.AutoSize = true;
            Lbl_Info_Activity.Font = new Font("Segoe UI", 11F);
            Lbl_Info_Activity.Location = new Point(30, 25);
            Lbl_Info_Activity.Name = "Lbl_Info_Activity";
            Lbl_Info_Activity.Size = new Size(89, 20);
            Lbl_Info_Activity.TabIndex = 1;
            Lbl_Info_Activity.Text = "Actividades:";
            // 
            // Txt_Info_Activity
            // 
            Txt_Info_Activity.Font = new Font("Segoe UI", 11F);
            Txt_Info_Activity.Location = new Point(30, 75);
            Txt_Info_Activity.Multiline = true;
            Txt_Info_Activity.Name = "Txt_Info_Activity";
            Txt_Info_Activity.ReadOnly = true;
            Txt_Info_Activity.Size = new Size(240, 350);
            Txt_Info_Activity.TabIndex = 2;
            // 
            // V_Info_Proyect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 501);
            Controls.Add(Pnl_Info_Proyect);
            MaximizeBox = false;
            Name = "V_Info_Proyect";
            Text = "V_Info_Proyect";
            Pnl_Info_Proyect.ResumeLayout(false);
            Pnl_Info_Proyect.PerformLayout();
            Pnl_Info2.ResumeLayout(false);
            Pnl_Info2.PerformLayout();
            Pnl_Button_ViewImg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Info_Proyect;
        private Panel Pnl_Info2;
        private Panel Pnl_Info1;
        private TextBox Txt_Info_Proyect;
        private TextBox Txt_Name_Proyect;
        private Label Lbl_Info_Proyect;
        private Panel Pnl_Button_ViewImg;
        private Button Btn_View_Img;
        private TextBox Txt_Info_Activity;
        private Label Lbl_Info_Activity;
    }
}