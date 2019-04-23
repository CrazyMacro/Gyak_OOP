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
            this.beszállításhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megrendelesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beérkezesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atvetelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visszaruMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAruk = new System.Windows.Forms.ListBox();
            this.raktárkészletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiszállításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.számlázásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kifizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiállításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujAruMenuItem,
            this.beszállításhToolStripMenuItem,
            this.raktárkészletToolStripMenuItem,
            this.kiszállításToolStripMenuItem,
            this.számlázásToolStripMenuItem});
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
            // beszállításhToolStripMenuItem
            // 
            this.beszállításhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megrendelesMenuItem,
            this.beérkezesMenuItem,
            this.atvetelMenuItem,
            this.visszaruMenuItem});
            this.beszállításhToolStripMenuItem.Name = "beszállításhToolStripMenuItem";
            this.beszállításhToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.beszállításhToolStripMenuItem.Text = "Beszállításh";
            // 
            // megrendelesMenuItem
            // 
            this.megrendelesMenuItem.Name = "megrendelesMenuItem";
            this.megrendelesMenuItem.Size = new System.Drawing.Size(152, 22);
            this.megrendelesMenuItem.Text = "Megrendelés";
            // 
            // beérkezesMenuItem
            // 
            this.beérkezesMenuItem.Name = "beérkezesMenuItem";
            this.beérkezesMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beérkezesMenuItem.Text = "Beérkezés";
            this.beérkezesMenuItem.Click += new System.EventHandler(this.beérkezesMenuItem_Click);
            // 
            // atvetelMenuItem
            // 
            this.atvetelMenuItem.Name = "atvetelMenuItem";
            this.atvetelMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atvetelMenuItem.Text = "Átvétel";
            // 
            // visszaruMenuItem
            // 
            this.visszaruMenuItem.Name = "visszaruMenuItem";
            this.visszaruMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visszaruMenuItem.Text = "Visszáru";
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
            // raktárkészletToolStripMenuItem
            // 
            this.raktárkészletToolStripMenuItem.Name = "raktárkészletToolStripMenuItem";
            this.raktárkészletToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.raktárkészletToolStripMenuItem.Text = "Raktárkészlet";
            // 
            // kiszállításToolStripMenuItem
            // 
            this.kiszállításToolStripMenuItem.Name = "kiszállításToolStripMenuItem";
            this.kiszállításToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.kiszállításToolStripMenuItem.Text = "Kiszállítás";
            // 
            // számlázásToolStripMenuItem
            // 
            this.számlázásToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kifizetésToolStripMenuItem,
            this.kiállításToolStripMenuItem});
            this.számlázásToolStripMenuItem.Name = "számlázásToolStripMenuItem";
            this.számlázásToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.számlázásToolStripMenuItem.Text = "Számlázás";
            // 
            // kifizetésToolStripMenuItem
            // 
            this.kifizetésToolStripMenuItem.Name = "kifizetésToolStripMenuItem";
            this.kifizetésToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kifizetésToolStripMenuItem.Text = "Kifizetés";
            // 
            // kiállításToolStripMenuItem
            // 
            this.kiállításToolStripMenuItem.Name = "kiállításToolStripMenuItem";
            this.kiállításToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kiállításToolStripMenuItem.Text = "Kiállítás";
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
        private System.Windows.Forms.ToolStripMenuItem beszállításhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megrendelesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beérkezesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atvetelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visszaruMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raktárkészletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiszállításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem számlázásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kifizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiállításToolStripMenuItem;
    }
}

