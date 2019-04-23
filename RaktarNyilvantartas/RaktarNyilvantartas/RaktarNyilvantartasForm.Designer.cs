namespace RaktarNyilvantartas
{
    partial class RaktarNyilvantartasForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ujAruMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAruk = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujAruMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ujAruMenuItem
            // 
            this.ujAruMenuItem.Name = "ujAruMenuItem";
            this.ujAruMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ujAruMenuItem.Text = "Új Áru";
            this.ujAruMenuItem.Click += new System.EventHandler(this.ujAruMenuItem_Click);
            // 
            // lbAruk
            // 
            this.lbAruk.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAruk.FormattingEnabled = true;
            this.lbAruk.Location = new System.Drawing.Point(0, 24);
            this.lbAruk.Name = "lbAruk";
            this.lbAruk.Size = new System.Drawing.Size(250, 281);
            this.lbAruk.TabIndex = 1;
            // 
            // RaktarNyilvantartasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 305);
            this.Controls.Add(this.lbAruk);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RaktarNyilvantartasForm";
            this.Text = "Ratár nyilvántartás";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaktarNyilvantartasForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ujAruMenuItem;
        private System.Windows.Forms.ListBox lbAruk;
    }
}

