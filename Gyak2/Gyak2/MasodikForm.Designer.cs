namespace Gyak2
{
    partial class MasodikForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.labelTextBoxName = new System.Windows.Forms.Label();
            this.labelListBoxNames = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelItemExists = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(459, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 105);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(596, 64);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(279, 329);
            this.listBoxNames.TabIndex = 2;
            // 
            // labelTextBoxName
            // 
            this.labelTextBoxName.AutoSize = true;
            this.labelTextBoxName.Location = new System.Drawing.Point(12, 21);
            this.labelTextBoxName.Name = "labelTextBoxName";
            this.labelTextBoxName.Size = new System.Drawing.Size(103, 13);
            this.labelTextBoxName.TabIndex = 3;
            this.labelTextBoxName.Text = "Write the name here";
            // 
            // labelListBoxNames
            // 
            this.labelListBoxNames.AutoSize = true;
            this.labelListBoxNames.Location = new System.Drawing.Point(593, 37);
            this.labelListBoxNames.Name = "labelListBoxNames";
            this.labelListBoxNames.Size = new System.Drawing.Size(72, 13);
            this.labelListBoxNames.TabIndex = 4;
            this.labelListBoxNames.Text = "Names so far:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(596, 424);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelItemExists
            // 
            this.labelItemExists.AutoSize = true;
            this.labelItemExists.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelItemExists.ForeColor = System.Drawing.Color.Crimson;
            this.labelItemExists.Location = new System.Drawing.Point(12, 64);
            this.labelItemExists.Name = "labelItemExists";
            this.labelItemExists.Size = new System.Drawing.Size(136, 13);
            this.labelItemExists.TabIndex = 6;
            this.labelItemExists.Text = "This name is already added";
            this.labelItemExists.Visible = false;
            // 
            // MasodikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 511);
            this.Controls.Add(this.labelItemExists);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelListBoxNames);
            this.Controls.Add(this.labelTextBoxName);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Name = "MasodikForm";
            this.Text = "Hullo Wurld_2";
            this.Load += new System.EventHandler(this.MasodikForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Label labelTextBoxName;
        private System.Windows.Forms.Label labelListBoxNames;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelItemExists;
    }
}

