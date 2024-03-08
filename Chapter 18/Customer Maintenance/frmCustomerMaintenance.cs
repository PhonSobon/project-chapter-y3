using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Maintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " +
                  "Some rows were not updated.", "Concurrency Exception");
                this.customersTableAdapter.Fill(
                    this.mMABooksDataSet.Customers);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                customersBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void frmCusomterMaintenance_Load(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.Fill(
                    this.mMABooksDataSet.Customers);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                  ": " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
