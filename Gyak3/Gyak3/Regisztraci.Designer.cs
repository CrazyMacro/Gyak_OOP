namespace Gyak3
{
    partial class Regisztraci
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.Felhasználónév = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.textBoxPwdRepeat = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.labelPwdRepeat = new System.Windows.Forms.Label();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.errorPwdMismatch = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPwdMismatch)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(33, 32);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(283, 20);
            this.textBoxUserName.TabIndex = 0;
            // 
            // Felhasználónév
            // 
            this.Felhasználónév.AutoSize = true;
            this.Felhasználónév.Location = new System.Drawing.Point(33, 13);
            this.Felhasználónév.Name = "Felhasználónév";
            this.Felhasználónév.Size = new System.Drawing.Size(81, 13);
            this.Felhasználónév.TabIndex = 1;
            this.Felhasználónév.Text = "Felhasználónév";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(33, 85);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(209, 20);
            this.textBoxPwd.TabIndex = 2;
            // 
            // textBoxPwdRepeat
            // 
            this.textBoxPwdRepeat.Location = new System.Drawing.Point(33, 139);
            this.textBoxPwdRepeat.Name = "textBoxPwdRepeat";
            this.textBoxPwdRepeat.Size = new System.Drawing.Size(209, 20);
            this.textBoxPwdRepeat.TabIndex = 3;
            this.textBoxPwdRepeat.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPwdRepeat_Validating);
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(30, 69);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(36, 13);
            this.labelPwd.TabIndex = 4;
            this.labelPwd.Text = "Jelszó";
            // 
            // labelPwdRepeat
            // 
            this.labelPwdRepeat.AutoSize = true;
            this.labelPwdRepeat.Location = new System.Drawing.Point(30, 123);
            this.labelPwdRepeat.Name = "labelPwdRepeat";
            this.labelPwdRepeat.Size = new System.Drawing.Size(95, 13);
            this.labelPwdRepeat.TabIndex = 5;
            this.labelPwdRepeat.Text = "Jelszó mégegyszer";
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Location = new System.Drawing.Point(33, 194);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(206, 20);
            this.dateTimeBirthDate.TabIndex = 6;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(33, 256);
            this.numHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 20);
            this.numHeight.TabIndex = 7;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(33, 175);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(81, 13);
            this.labelBirthDate.TabIndex = 8;
            this.labelBirthDate.Text = "Születési dátum";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(33, 237);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(56, 13);
            this.labelHeight.TabIndex = 9;
            this.labelHeight.Text = "Magasság";
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(33, 308);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(43, 17);
            this.checkBoxMale.TabIndex = 10;
            this.checkBoxMale.Text = "férfi";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(33, 289);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(35, 13);
            this.labelSex.TabIndex = 12;
            this.labelSex.Text = "Neme";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(440, 32);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(244, 50);
            this.buttonRegister.TabIndex = 13;
            this.buttonRegister.Text = "Regisztrálok";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // errorPwdMismatch
            // 
            this.errorPwdMismatch.ContainerControl = this;
            this.errorPwdMismatch.DataMember = "asd";
            // 
            // Regisztraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 593);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.labelPwdRepeat);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.textBoxPwdRepeat);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.Felhasználónév);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "Regisztraci";
            this.Text = "Regisztrácijó";
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPwdMismatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label Felhasználónév;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.TextBox textBoxPwdRepeat;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Label labelPwdRepeat;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.ErrorProvider errorPwdMismatch;
    }
}

