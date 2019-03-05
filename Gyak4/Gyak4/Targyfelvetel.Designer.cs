namespace Gyak4
{
    partial class Targyfelvetel
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
            this.labelStudentName = new System.Windows.Forms.Label();
            this.listBoxSubjectsAvailable = new System.Windows.Forms.ListBox();
            this.labelSubjectAvailable = new System.Windows.Forms.Label();
            this.buttonTakeSubject = new System.Windows.Forms.Button();
            this.listBoxSubjectsTaken = new System.Windows.Forms.ListBox();
            this.labelSubjectsTaken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(13, 13);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(110, 13);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Hallgató neve: Ka Pál";
            // 
            // listBoxSubjectsAvailable
            // 
            this.listBoxSubjectsAvailable.FormattingEnabled = true;
            this.listBoxSubjectsAvailable.Location = new System.Drawing.Point(16, 86);
            this.listBoxSubjectsAvailable.Name = "listBoxSubjectsAvailable";
            this.listBoxSubjectsAvailable.Size = new System.Drawing.Size(225, 134);
            this.listBoxSubjectsAvailable.TabIndex = 1;
            // 
            // labelSubjectAvailable
            // 
            this.labelSubjectAvailable.AutoSize = true;
            this.labelSubjectAvailable.Location = new System.Drawing.Point(13, 70);
            this.labelSubjectAvailable.Name = "labelSubjectAvailable";
            this.labelSubjectAvailable.Size = new System.Drawing.Size(92, 13);
            this.labelSubjectAvailable.TabIndex = 2;
            this.labelSubjectAvailable.Text = "Felvehető tárgyak";
            // 
            // buttonTakeSubject
            // 
            this.buttonTakeSubject.Location = new System.Drawing.Point(274, 141);
            this.buttonTakeSubject.Name = "buttonTakeSubject";
            this.buttonTakeSubject.Size = new System.Drawing.Size(74, 23);
            this.buttonTakeSubject.TabIndex = 3;
            this.buttonTakeSubject.Text = ">>";
            this.buttonTakeSubject.UseVisualStyleBackColor = true;
            // 
            // listBoxSubjectsTaken
            // 
            this.listBoxSubjectsTaken.FormattingEnabled = true;
            this.listBoxSubjectsTaken.Location = new System.Drawing.Point(377, 86);
            this.listBoxSubjectsTaken.Name = "listBoxSubjectsTaken";
            this.listBoxSubjectsTaken.Size = new System.Drawing.Size(225, 134);
            this.listBoxSubjectsTaken.TabIndex = 4;
            // 
            // labelSubjectsTaken
            // 
            this.labelSubjectsTaken.AutoSize = true;
            this.labelSubjectsTaken.Location = new System.Drawing.Point(374, 70);
            this.labelSubjectsTaken.Name = "labelSubjectsTaken";
            this.labelSubjectsTaken.Size = new System.Drawing.Size(74, 13);
            this.labelSubjectsTaken.TabIndex = 5;
            this.labelSubjectsTaken.Text = "Felvett tágyak";
            // 
            // Targyfelvetel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 305);
            this.Controls.Add(this.labelSubjectsTaken);
            this.Controls.Add(this.listBoxSubjectsTaken);
            this.Controls.Add(this.buttonTakeSubject);
            this.Controls.Add(this.labelSubjectAvailable);
            this.Controls.Add(this.listBoxSubjectsAvailable);
            this.Controls.Add(this.labelStudentName);
            this.Name = "Targyfelvetel";
            this.Text = "Targyfelvetel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.ListBox listBoxSubjectsAvailable;
        private System.Windows.Forms.Label labelSubjectAvailable;
        private System.Windows.Forms.Button buttonTakeSubject;
        private System.Windows.Forms.ListBox listBoxSubjectsTaken;
        private System.Windows.Forms.Label labelSubjectsTaken;
    }
}

