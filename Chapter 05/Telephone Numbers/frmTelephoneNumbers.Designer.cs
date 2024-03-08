namespace Telephone_Numbers
{
    partial class frmTelephoneNumbers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAphanumericNumber = new TextBox();
            txtNumericOnly = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            label1 = new Label();
            btnConverttoNumericOnly = new Button();
            SuspendLayout();
            // 
            // txtAphanumericNumber
            // 
            txtAphanumericNumber.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAphanumericNumber.Location = new Point(211, 82);
            txtAphanumericNumber.Margin = new Padding(3, 4, 3, 4);
            txtAphanumericNumber.Name = "txtAphanumericNumber";
            txtAphanumericNumber.Size = new Size(191, 22);
            txtAphanumericNumber.TabIndex = 1;
            // 
            // txtNumericOnly
            // 
            txtNumericOnly.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumericOnly.Location = new Point(211, 135);
            txtNumericOnly.Margin = new Padding(3, 4, 3, 4);
            txtNumericOnly.Name = "txtNumericOnly";
            txtNumericOnly.ReadOnly = true;
            txtNumericOnly.Size = new Size(191, 22);
            txtNumericOnly.TabIndex = 3;
            txtNumericOnly.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 141);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 2;
            label2.Text = "Numeric Only";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(248, 232);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 77);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 82);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 5;
            label1.Text = "Aphanumeric Number ";
            // 
            // btnConverttoNumericOnly
            // 
            btnConverttoNumericOnly.Location = new Point(57, 241);
            btnConverttoNumericOnly.Name = "btnConverttoNumericOnly";
            btnConverttoNumericOnly.Size = new Size(132, 68);
            btnConverttoNumericOnly.TabIndex = 6;
            btnConverttoNumericOnly.Text = "&Convert to Numeric Only";
            btnConverttoNumericOnly.UseVisualStyleBackColor = true;
            btnConverttoNumericOnly.Click += btnConverttoNumericOnly_Click;
            // 
            // frmTelephoneNumbers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 349);
            Controls.Add(btnConverttoNumericOnly);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(txtNumericOnly);
            Controls.Add(label2);
            Controls.Add(txtAphanumericNumber);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTelephoneNumbers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telephone Number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAphanumericNumber;
        private TextBox txtNumericOnly;
        private Label label2;
        private Button btnExit;
        private Label label1;
        private Button btnConverttoNumericOnly;
    }
}