namespace Vistas
{
    partial class V_Notes
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
            Pnl_Filtro = new Panel();
            Pnl_Buttons = new Panel();
            BverNote = new Button();
            Pnl_Space2 = new Panel();
            BmodifNote = new Button();
            Pnl_Space1 = new Panel();
            BagregarNote = new Button();
            Pnl_Table_Act = new Panel();
            tablaNotes = new DataGridView();
            Pnl_Buttons.SuspendLayout();
            Pnl_Table_Act.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaNotes).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Filtro
            // 
            Pnl_Filtro.BackColor = Color.White;
            Pnl_Filtro.Dock = DockStyle.Top;
            Pnl_Filtro.Location = new Point(0, 0);
            Pnl_Filtro.Margin = new Padding(3, 4, 3, 4);
            Pnl_Filtro.Name = "Pnl_Filtro";
            Pnl_Filtro.Size = new Size(896, 80);
            Pnl_Filtro.TabIndex = 4;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.BackColor = Color.White;
            Pnl_Buttons.Controls.Add(BverNote);
            Pnl_Buttons.Controls.Add(Pnl_Space2);
            Pnl_Buttons.Controls.Add(BmodifNote);
            Pnl_Buttons.Controls.Add(Pnl_Space1);
            Pnl_Buttons.Controls.Add(BagregarNote);
            Pnl_Buttons.Dock = DockStyle.Right;
            Pnl_Buttons.Location = new Point(639, 80);
            Pnl_Buttons.Margin = new Padding(3, 4, 3, 4);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Padding = new Padding(0, 33, 23, 60);
            Pnl_Buttons.Size = new Size(257, 473);
            Pnl_Buttons.TabIndex = 7;
            // 
            // BverNote
            // 
            BverNote.BackColor = Color.Green;
            BverNote.Cursor = Cursors.Hand;
            BverNote.Dock = DockStyle.Top;
            BverNote.Font = new Font("Segoe UI", 11F);
            BverNote.ForeColor = Color.White;
            BverNote.Location = new Point(0, 207);
            BverNote.Margin = new Padding(3, 4, 3, 4);
            BverNote.Name = "BverNote";
            BverNote.Size = new Size(234, 60);
            BverNote.TabIndex = 9;
            BverNote.Text = "Ver Nota";
            BverNote.UseVisualStyleBackColor = false;
            BverNote.Click += BverNote_Click;
            // 
            // Pnl_Space2
            // 
            Pnl_Space2.Dock = DockStyle.Top;
            Pnl_Space2.Location = new Point(0, 180);
            Pnl_Space2.Margin = new Padding(3, 4, 3, 4);
            Pnl_Space2.Name = "Pnl_Space2";
            Pnl_Space2.Size = new Size(234, 27);
            Pnl_Space2.TabIndex = 8;
            // 
            // BmodifNote
            // 
            BmodifNote.BackColor = Color.Green;
            BmodifNote.Cursor = Cursors.Hand;
            BmodifNote.Dock = DockStyle.Top;
            BmodifNote.Font = new Font("Segoe UI", 11F);
            BmodifNote.ForeColor = Color.White;
            BmodifNote.Location = new Point(0, 120);
            BmodifNote.Margin = new Padding(3, 4, 3, 4);
            BmodifNote.Name = "BmodifNote";
            BmodifNote.Size = new Size(234, 60);
            BmodifNote.TabIndex = 7;
            BmodifNote.Text = "Modificar Nota";
            BmodifNote.UseVisualStyleBackColor = false;
            BmodifNote.Click += BmodifNote_Click;
            // 
            // Pnl_Space1
            // 
            Pnl_Space1.Dock = DockStyle.Top;
            Pnl_Space1.Location = new Point(0, 93);
            Pnl_Space1.Margin = new Padding(3, 4, 3, 4);
            Pnl_Space1.Name = "Pnl_Space1";
            Pnl_Space1.Size = new Size(234, 27);
            Pnl_Space1.TabIndex = 6;
            // 
            // BagregarNote
            // 
            BagregarNote.BackColor = Color.Green;
            BagregarNote.Cursor = Cursors.Hand;
            BagregarNote.Dock = DockStyle.Top;
            BagregarNote.Font = new Font("Segoe UI", 11F);
            BagregarNote.ForeColor = Color.White;
            BagregarNote.Location = new Point(0, 33);
            BagregarNote.Margin = new Padding(3, 4, 3, 4);
            BagregarNote.Name = "BagregarNote";
            BagregarNote.Size = new Size(234, 60);
            BagregarNote.TabIndex = 0;
            BagregarNote.Text = "Añadir Nueva Nota";
            BagregarNote.UseVisualStyleBackColor = false;
            BagregarNote.Click += BagregarNote_Click;
            // 
            // Pnl_Table_Act
            // 
            Pnl_Table_Act.AutoSize = true;
            Pnl_Table_Act.BackColor = Color.White;
            Pnl_Table_Act.Controls.Add(tablaNotes);
            Pnl_Table_Act.Dock = DockStyle.Fill;
            Pnl_Table_Act.Location = new Point(0, 80);
            Pnl_Table_Act.Margin = new Padding(3, 4, 3, 4);
            Pnl_Table_Act.Name = "Pnl_Table_Act";
            Pnl_Table_Act.Padding = new Padding(51, 33, 34, 60);
            Pnl_Table_Act.Size = new Size(639, 473);
            Pnl_Table_Act.TabIndex = 8;
            // 
            // tablaNotes
            // 
            tablaNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaNotes.Dock = DockStyle.Fill;
            tablaNotes.Location = new Point(51, 33);
            tablaNotes.Margin = new Padding(3, 4, 3, 4);
            tablaNotes.Name = "tablaNotes";
            tablaNotes.RowHeadersWidth = 51;
            tablaNotes.Size = new Size(554, 380);
            tablaNotes.TabIndex = 4;
            // 
            // V_Notes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 553);
            Controls.Add(Pnl_Table_Act);
            Controls.Add(Pnl_Buttons);
            Controls.Add(Pnl_Filtro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Notes";
            Text = "V_Notes";
            Pnl_Buttons.ResumeLayout(false);
            Pnl_Table_Act.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pnl_Filtro;
        private Panel Pnl_Buttons;
        private Button Bnotas;
        private Button Btn_FPC_Act;
        private Panel Pnl_Space2;
        private Button BmodifNote;
        private Panel Pnl_Space1;
        private Button Btn_Hist_Act;
        private Button BagregarNote;
        private Panel Pnl_Table_Act;
        private DataGridView tablaNotes;
        private Button BverNote;
    }
}