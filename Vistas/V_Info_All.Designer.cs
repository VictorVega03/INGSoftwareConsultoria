namespace Vistas
{
    partial class V_Info_All
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
            Pnl_Info_All = new Panel();
            Txt_Info_All = new TextBox();
            Txt_Name_All = new TextBox();
            Lbl_Info_Name = new Label();
            Pnl_Info_All.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_Info_All
            // 
            Pnl_Info_All.Controls.Add(Txt_Info_All);
            Pnl_Info_All.Controls.Add(Txt_Name_All);
            Pnl_Info_All.Controls.Add(Lbl_Info_Name);
            Pnl_Info_All.Dock = DockStyle.Fill;
            Pnl_Info_All.Location = new Point(0, 0);
            Pnl_Info_All.Name = "Pnl_Info_All";
            Pnl_Info_All.Size = new Size(434, 501);
            Pnl_Info_All.TabIndex = 0;
            // 
            // Txt_Info_All
            // 
            Txt_Info_All.Location = new Point(30, 75);
            Txt_Info_All.Multiline = true;
            Txt_Info_All.Name = "Txt_Info_All";
            Txt_Info_All.ReadOnly = true;
            Txt_Info_All.Size = new Size(375, 400);
            Txt_Info_All.TabIndex = 2;
            // 
            // Txt_Name_All
            // 
            Txt_Name_All.Font = new Font("Segoe UI", 11F);
            Txt_Name_All.Location = new Point(155, 20);
            Txt_Name_All.Name = "Txt_Name_All";
            Txt_Name_All.ReadOnly = true;
            Txt_Name_All.Size = new Size(250, 27);
            Txt_Name_All.TabIndex = 1;
            Txt_Name_All.TextAlign = HorizontalAlignment.Center;
            // 
            // Lbl_Info_Name
            // 
            Lbl_Info_Name.AutoSize = true;
            Lbl_Info_Name.Font = new Font("Segoe UI", 11F);
            Lbl_Info_Name.Location = new Point(30, 25);
            Lbl_Info_Name.Name = "Lbl_Info_Name";
            Lbl_Info_Name.Size = new Size(113, 20);
            Lbl_Info_Name.TabIndex = 0;
            Lbl_Info_Name.Text = "Información de:";
            // 
            // V_Info_All
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 501);
            Controls.Add(Pnl_Info_All);
            MaximizeBox = false;
            Name = "V_Info_All";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Info_All";
            Pnl_Info_All.ResumeLayout(false);
            Pnl_Info_All.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Info_All;
        private TextBox Txt_Name_All;
        private Label Lbl_Info_Name;
        private TextBox Txt_Info_All;
    }
}