namespace Customer_Maintenance
{
    partial class frmCustomerMaintenance
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipCodeLabel;
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMABooksDataSet = new Customer_Maintenance.MMABooksDataSet();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.customersTableAdapter = new Customer_Maintenance.MMABooksDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Customer_Maintenance.MMABooksDataSetTableAdapters.TableAdapterManager();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(22, 39);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(83, 16);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 96);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(22, 134);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(61, 16);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(22, 174);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(32, 16);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(22, 211);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(41, 16);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "State:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(305, 211);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(65, 16);
            zipCodeLabel.TabIndex = 11;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.txtCustomerID.Location = new System.Drawing.Point(120, 36);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerID.TabIndex = 2;
            this.txtCustomerID.Tag = "CustomerID";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(120, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(120, 131);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(356, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(120, 171);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(356, 22);
            this.txtCity.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.txtState.Enabled = false;
            this.txtState.Location = new System.Drawing.Point(120, 208);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(67, 22);
            this.txtState.TabIndex = 10;
            // 
            // txtZipCode
            // 
            this.txtZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
            this.txtZipCode.Enabled = false;
            this.txtZipCode.Location = new System.Drawing.Point(376, 208);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtZipCode.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(129, 268);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 34);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(228, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(401, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(228, 30);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(126, 34);
            this.btnGetCustomer.TabIndex = 13;
            this.btnGetCustomer.Text = "Get Customer";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Customer_Maintenance.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCustomerMaintenance
            // 
            this.AcceptButton = this.btnGetCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(508, 337);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.txtZipCode);
            this.Name = "frmCustomerMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMABooksDataSet mMABooksDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetCustomer;
    }
}

