namespace Shipping_and_Handling
{
    partial class frmShippingAndHandling
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
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShippingCosts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnCalculateGrandTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(339, 44);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(172, 22);
            this.txtOrderTotal.TabIndex = 1;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Type (P=Preferred, N=non-Preferred)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(339, 86);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(42, 22);
            this.txtCustomerType.TabIndex = 2;
            this.txtCustomerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shipping Costs (free for Preferred customers)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtShippingCosts
            // 
            this.txtShippingCosts.Location = new System.Drawing.Point(339, 131);
            this.txtShippingCosts.Name = "txtShippingCosts";
            this.txtShippingCosts.ReadOnly = true;
            this.txtShippingCosts.Size = new System.Drawing.Size(172, 22);
            this.txtShippingCosts.TabIndex = 1;
            this.txtShippingCosts.TabStop = false;
            this.txtShippingCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sales Tax (7%)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(339, 174);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(172, 22);
            this.txtSalesTax.TabIndex = 1;
            this.txtSalesTax.TabStop = false;
            this.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grand Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(339, 215);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(172, 22);
            this.txtGrandTotal.TabIndex = 1;
            this.txtGrandTotal.TabStop = false;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculateGrandTotal
            // 
            this.btnCalculateGrandTotal.Location = new System.Drawing.Point(135, 275);
            this.btnCalculateGrandTotal.Name = "btnCalculateGrandTotal";
            this.btnCalculateGrandTotal.Size = new System.Drawing.Size(101, 46);
            this.btnCalculateGrandTotal.TabIndex = 3;
            this.btnCalculateGrandTotal.Text = "&Calculate Grand Total";
            this.btnCalculateGrandTotal.UseVisualStyleBackColor = true;
            this.btnCalculateGrandTotal.Click += new System.EventHandler(this.btnCalculateGrandTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(299, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmShippingAndHandling
            // 
            this.AcceptButton = this.btnCalculateGrandTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(539, 381);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateGrandTotal);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShippingCosts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.label1);
            this.Name = "frmShippingAndHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipping and Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShippingCosts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Button btnCalculateGrandTotal;
        private System.Windows.Forms.Button btnExit;
    }
}

