namespace RaktarNyilvantartas
{
    partial class UjAruForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAzon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nuAr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFelvesz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuAr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(16, 30);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(100, 20);
            this.tbNev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Azonosító:";
            // 
            // tbAzon
            // 
            this.tbAzon.Location = new System.Drawing.Point(19, 87);
            this.tbAzon.Name = "tbAzon";
            this.tbAzon.Size = new System.Drawing.Size(100, 20);
            this.tbAzon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ár:";
            // 
            // nuAr
            // 
            this.nuAr.Location = new System.Drawing.Point(19, 151);
            this.nuAr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuAr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nuAr.Name = "nuAr";
            this.nuAr.Size = new System.Drawing.Size(100, 20);
            this.nuAr.TabIndex = 5;
            this.nuAr.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ft";
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(174, 147);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(75, 23);
            this.btnFelvesz.TabIndex = 7;
            this.btnFelvesz.Text = "Felvesz";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            this.btnFelvesz.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // UjAruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.btnFelvesz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nuAr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAzon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Name = "UjAruForm";
            this.Text = "Új áru felvétele";
            ((System.ComponentModel.ISupportInitialize)(this.nuAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAzon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuAr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFelvesz;
    }
}