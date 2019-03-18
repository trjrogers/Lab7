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

    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        // Customer class variable init as null
        public Customer customer = null;

        // Displays form, returns Customer object
        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        // Validates form data
        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) && Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtEmail) && Validator.IsValidEmail(txtEmail);
        }

        // Validates form data, creates new customer
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                this.Close();
            }
        }

        // Closes form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}