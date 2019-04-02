namespace Gyak4_sudoku
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.sudokuBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxasd = new System.Windows.Forms.TextBox[9,9];
            ((System.ComponentModel.ISupportInitialize)(this.sudokuBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxasd
            // 
            for(int i=0; i<9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    this.textBoxasd[i, j] = new System.Windows.Forms.TextBox();
                    this.textBoxasd[i,j].Location = new System.Drawing.Point(200+i * 30, 200+j * 30);
                    this.textBoxasd[i,j].Name = "textBox" + i + j;
                    this.textBoxasd[i,j].Size = new System.Drawing.Size(28, 28);
                    this.textBoxasd[i,j].TabIndex = i*10 + j;
                }
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 593);
            for(int i = 0; i<9; i++)
            {
                for(int j = 0; j<9; j++)
                {
                    this.Controls.Add(this.textBoxasd[i,j]);
                }
            }
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sudokuBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sudokuBoardBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox[,] textBoxasd;
    }
}

