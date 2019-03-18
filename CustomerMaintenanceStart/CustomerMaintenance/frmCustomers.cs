using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 12-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        // Initialize list that holds customers
        private List<Customer> customers = new List<Customer>();

        private void frmCustomers_Load(object sender, System.EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            FillCustomerListBox();
        }

        // Declare a method to iterate through each customer in list and add display text to list box
        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer customer in customers)
            {
                lstCustomers.Items.Add(customer.GetDisplayText() + "\t");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer newCustomerForm = new frmAddCustomer();
            Customer customer = newCustomerForm.GetNewCustomer();

            /* If customer object returned not null
             *      add new customer to array list
                    save list to CustomerDB
                    refresh customer list box
            */

            if (customer != null)
            {
                customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* Confirm delete operation?
             *      Removes customer from customers
                    Save list
                    Refresh list box
            */

            int index = lstCustomers.SelectedIndex;
            Customer delCustomer = customers[index];

            // Confirms whether or not user wants to delete a customer
            DialogResult button =
                MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            // If user confirms, removes customer at index, saves list, refreshes listbox
            if (button == DialogResult.Yes)
            {
                customers.Remove(delCustomer);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        // Closes form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}