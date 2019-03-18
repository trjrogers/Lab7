using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class RetailCustomer : Customer
    {
        public string homePhone;

        public RetailCustomer(string firstName, string lastName, string email, string homePhone) : base(firstName, lastName, email)
        {
            this.homePhone = homePhone;
        }

        public override string GetDisplayText()
        {
            return this.FirstName + " " + this.LastName + ", " + this.Email + " ph:  " + this.HomePhone;
        }

        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }
            set
            {
                this.homePhone = value;
            }
        }
    }
}
