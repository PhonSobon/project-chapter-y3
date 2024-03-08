namespace Student_Population
{
    partial class frmStudentPopulation
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
            this.txtNumberOfStudentsToday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnnualGrowthRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfProjectStudents = new System.Windows.Forms.TextBox();
            this.btnProjectStudentPopulation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of students today";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfStudentsToday
            // 
            this.txtNumberOfStudentsToday.Location = new System.Drawing.Point(225, 45);
            this.txtNumberOfStudentsToday.Name = "txtNumberOfStudentsToday";
            this.txtNumberOfStudentsToday.Size = new System.Drawing.Size(164, 22);
            this.txtNumberOfStudentsToday.TabIndex = 1;
            this.txtNumberOfStudentsToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Annual growth rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnnualGrowthRate
            // 
            this.txtAnnualGrowthRate.Location = new System.Drawing.Point(225, 87);
            this.txtAnnualGrowthRate.Name = "txtAnnualGrowthRate";
            this.txtAnnualGrowthRate.Size = new System.Drawing.Size(164, 22);
            this.txtAnnualGrowthRate.TabIndex = 2;
            this.txtAnnualGrowthRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of years";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(225, 130);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(164, 22);
            this.txtNumberOfYears.TabIndex = 3;
            this.txtNumberOfYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Project number of students";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfProjectStudents
            // 
            this.txtNumberOfProjectStudents.Location = new System.Drawing.Point(225, 178);
            this.txtNumberOfProjectStudents.Name = "txtNumberOfProjectStudents";
            this.txtNumberOfProjectStudents.ReadOnly = true;
            this.txtNumberOfProjectStudents.Size = new System.Drawing.Size(164, 22);
            this.txtNumberOfProjectStudents.TabIndex = 1;
            this.txtNumberOfProjectStudents.TabStop = false;
            this.txtNumberOfProjectStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProjectStudentPopulation
            // 
            this.btnProjectStudentPopulation.Location = new System.Drawing.Point(55, 261);
            this.btnProjectStudentPopulation.Name = "btnProjectStudentPopulation";
            this.btnProjectStudentPopulation.Size = new System.Drawing.Size(128, 66);
            this.btnProjectStudentPopulation.TabIndex = 4;
            this.btnProjectStudentPopulation.Text = "&Project Student Population";
            this.btnProjectStudentPopulation.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(237, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 66);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmStudentPopulation
            // 
            this.AcceptButton = this.btnProjectStudentPopulation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(429, 391);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProjectStudentPopulation);
            this.Controls.Add(this.txtNumberOfProjectStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnnualGrowthRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfStudentsToday);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentPopulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfStudentsToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnnualGrowthRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfProjectStudents;
        private System.Windows.Forms.Button btnProjectStudentPopulation;
        private System.Windows.Forms.Button btnExit;
    }
}

