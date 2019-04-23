namespace RaktarNyilvantartas
{
    partial class BeerkezesForm
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
            this.listBoxAruLista = new System.Windows.Forms.ListBox();
            this.numericUpDownDb = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxBeerk = new System.Windows.Forms.ListBox();
            this.buttonBeerk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Áruk";
            // 
            // listBoxAruLista
            // 
            this.listBoxAruLista.FormattingEnabled = true;
            this.listBoxAruLista.Location = new System.Drawing.Point(28, 57);
            this.listBoxAruLista.Name = "listBoxAruLista";
            this.listBoxAruLista.Size = new System.Drawing.Size(192, 225);
            this.listBoxAruLista.TabIndex = 1;
            // 
            // numericUpDownDb
            // 
            this.numericUpDownDb.Location = new System.Drawing.Point(242, 57);
            this.numericUpDownDb.Name = "numericUpDownDb";
            this.numericUpDownDb.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownDb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Darab";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Beérkezett Áruk";
            // 
            // listBoxBeerk
            // 
            this.listBoxBeerk.FormattingEnabled = true;
            this.listBoxBeerk.Location = new System.Drawing.Point(377, 57);
            this.listBoxBeerk.Name = "listBoxBeerk";
            this.listBoxBeerk.Size = new System.Drawing.Size(130, 225);
            this.listBoxBeerk.TabIndex = 5;
            // 
            // buttonBeerk
            // 
            this.buttonBeerk.Location = new System.Drawing.Point(242, 101);
            this.buttonBeerk.Name = "buttonBeerk";
            this.buttonBeerk.Size = new System.Drawing.Size(79, 28);
            this.buttonBeerk.TabIndex = 6;
            this.buttonBeerk.Text = "Beérkezett";
            this.buttonBeerk.UseVisualStyleBackColor = true;
            this.buttonBeerk.Click += new System.EventHandler(this.buttonBeerk_Click);
            // 
            // BeerkezesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 391);
            this.Controls.Add(this.buttonBeerk);
            this.Controls.Add(this.listBoxBeerk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownDb);
            this.Controls.Add(this.listBoxAruLista);
            this.Controls.Add(this.label1);
            this.Name = "BeerkezesForm";
            this.Text = "BeerkezesForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAruLista;
        private System.Windows.Forms.NumericUpDown numericUpDownDb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxBeerk;
        private System.Windows.Forms.Button buttonBeerk;
    }
}