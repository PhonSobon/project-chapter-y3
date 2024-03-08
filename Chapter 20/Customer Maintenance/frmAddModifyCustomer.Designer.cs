namespace Customer_Maintenance
{
    partial class frmAddModifyCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMABooksDataSet1 = new Customer_Maintenance.MMABooksDataSet();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mMABooksDataSet = new Customer_Maintenance.MMABooksDataSet();
            this.statesTableAdapter = new Customer_Maintenance.MMABooksDataSetTableAdapters.StatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(416, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(122, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(416, 22);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Tag = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(122, 118);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(416, 22);
            this.txtCity.TabIndex = 3;
            this.txtCity.Tag = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Zip Code:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(411, 161);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(127, 22);
            this.txtZipCode.TabIndex = 5;
            this.txtZipCode.Tag = "Zip Code";
            // 
            // cboStates
            // 
            this.cboStates.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.statesBindingSource, "StateName", true));
            this.cboStates.DataSource = this.statesBindingSource;
            this.cboStates.DisplayMember = "StateName";
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(122, 159);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(148, 24);
            this.cboStates.TabIndex = 4;
            this.cboStates.Tag = "State";
            this.cboStates.ValueMember = "StateCode";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.mMABooksDataSet1;
            // 
            // mMABooksDataSet1
            // 
            this.mMABooksDataSet1.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(37, 227);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 33);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(463, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddModifyCustomer
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(566, 292);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddModifyCustomer";
            this.Text = "Modify Customer";
            this.Load += new System.EventHandler(this.frmAddModifyCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private MMABooksDataSet mMABooksDataSet;
        private MMABooksDataSet mMABooksDataSet1;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private MMABooksDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
    }
}