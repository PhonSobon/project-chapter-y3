namespace Telephone_Numbers
{
    partial class frmTelephoneNumbers
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
            this.txtAlphaNumericNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumericOnly = new System.Windows.Forms.TextBox();
            this.btnConvertToNumericOnly = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alphanumeric Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAlphaNumericNumber
            // 
            this.txtAlphaNumericNumber.Location = new System.Drawing.Point(192, 51);
            this.txtAlphaNumericNumber.Name = "txtAlphaNumericNumber";
            this.txtAlphaNumericNumber.Size = new System.Drawing.Size(188, 22);
            this.txtAlphaNumericNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numeric Only";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumericOnly
            // 
            this.txtNumericOnly.Location = new System.Drawing.Point(192, 101);
            this.txtNumericOnly.Name = "txtNumericOnly";
            this.txtNumericOnly.ReadOnly = true;
            this.txtNumericOnly.Size = new System.Drawing.Size(188, 22);
            this.txtNumericOnly.TabIndex = 1;
            this.txtNumericOnly.TabStop = false;
            // 
            // btnConvertToNumericOnly
            // 
            this.btnConvertToNumericOnly.Location = new System.Drawing.Point(60, 183);
            this.btnConvertToNumericOnly.Name = "btnConvertToNumericOnly";
            this.btnConvertToNumericOnly.Size = new System.Drawing.Size(122, 64);
            this.btnConvertToNumericOnly.TabIndex = 2;
            this.btnConvertToNumericOnly.Text = "&Convert to Numeric Only";
            this.btnConvertToNumericOnly.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(233, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 64);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmTelephoneNumbers
            // 
            this.AcceptButton = this.btnConvertToNumericOnly;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(409, 287);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvertToNumericOnly);
            this.Controls.Add(this.txtNumericOnly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlphaNumericNumber);
            this.Controls.Add(this.label1);
            this.Name = "frmTelephoneNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlphaNumericNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumericOnly;
        private System.Windows.Forms.Button btnConvertToNumericOnly;
        private System.Windows.Forms.Button btnExit;
    }
}

