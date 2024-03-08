namespace Product_Maintenance
{
    partial class frmNewProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblAuthorOrVersion = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbSoftware = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthorOrVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // lblAuthorOrVersion
            // 
            this.lblAuthorOrVersion.AutoSize = true;
            this.lblAuthorOrVersion.Location = new System.Drawing.Point(39, 146);
            this.lblAuthorOrVersion.Name = "lblAuthorOrVersion";
            this.lblAuthorOrVersion.Size = new System.Drawing.Size(48, 16);
            this.lblAuthorOrVersion.TabIndex = 0;
            this.lblAuthorOrVersion.Tag = "";
            this.lblAuthorOrVersion.Text = "Author:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(123, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(111, 22);
            this.txtCode.TabIndex = 1;
            this.txtCode.Tag = "Code";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(123, 93);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(228, 22);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Tag = "Description";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(123, 195);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 22);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Location = new System.Drawing.Point(123, 12);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(60, 20);
            this.rbBook.TabIndex = 7;
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // rbSoftware
            // 
            this.rbSoftware.AutoSize = true;
            this.rbSoftware.Location = new System.Drawing.Point(248, 12);
            this.rbSoftware.Name = "rbSoftware";
            this.rbSoftware.Size = new System.Drawing.Size(80, 20);
            this.rbSoftware.TabIndex = 8;
            this.rbSoftware.Text = "Software";
            this.rbSoftware.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // txtAuthorOrVersion
            // 
            this.txtAuthorOrVersion.Location = new System.Drawing.Point(123, 143);
            this.txtAuthorOrVersion.Name = "txtAuthorOrVersion";
            this.txtAuthorOrVersion.Size = new System.Drawing.Size(228, 22);
            this.txtAuthorOrVersion.TabIndex = 3;
            this.txtAuthorOrVersion.Tag = "";
            // 
            // frmNewProduct
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(449, 296);
            this.ControlBox = false;
            this.Controls.Add(this.rbSoftware);
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthorOrVersion);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAuthorOrVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAuthorOrVersion;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbSoftware;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthorOrVersion;
    }
}