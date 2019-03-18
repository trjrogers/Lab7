using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class WholesaleCustomer : Customer
    {
        public string company;

        public WholesaleCustomer(string firstName, string lastName, string email, string company) : base(firstName, lastName, email)
        {
            this.company = company;
        }

        public override string GetDisplayText()
        {
            return this.FirstName + " " + this.LastName + ", " + this.Email + " ( " + this.Company + ")";
        }

        public string Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }
    }
}
