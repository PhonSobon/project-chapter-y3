using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Maintenance
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        private ProductList products = new ProductList();

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            products.Changed += new ProductList.ChangeHandler(HandleChange);
            products.Fill();
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            Product p;
            lstProducts.Items.Clear();
            for (int i  = 0; i < products.Count; i++) 
            {
                p = products[i]; // Use Indexer
                lstProducts.Items.Add(p.GetDisplayText(" \t"));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new frmNewProduct();
            Product product = newProductForm.GetNewProduct();
            if(product != null)
            {
                products += product; // Overloaded Operator
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstProducts.SelectedIndex;
            if(i != -1)
            {
                Product product = products[i]; // Use Indexer
                string message = "Are you sure you want to delete " + product.Description + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if(button == DialogResult.Yes)
                {
                    products -= product; // Overloaded Operator
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HandleChange(ProductList products)
        {
            products.Save();
            FillProductListBox();
        }
    }
}
