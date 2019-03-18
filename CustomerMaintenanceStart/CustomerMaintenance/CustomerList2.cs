using CustomerMaintenanceClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenance
{
    public class CustomerList2 : List<Customer>
    {
        public void Fill()
        {
            List<Customer> customers = CustomerDB.GetCustomers();
            foreach (Customer c in customers)
            {
                base.Add(c);
            }
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(this);
        }

        public new void Add(Customer c)
        {
            base.Add(c);
        }

        public void Add(string firstName, string lastName, string email)
        {
            Customer c = new Customer(firstName, lastName, email);
            this.Add(c);
        }

        public new void Remove(Customer customer)
        {
            base.Remove(customer);
        }

        public override string ToString()
        {
            string str = "";
            foreach(Customer c in this)
            {
                str += (c.ToString());
            }
            return str;
        }

        public new Customer this[int i]
        {
            get
            {
                if (i < 0 || i >= base.Count)
                {
                    throw new ArgumentException(i.ToString());
                }
                return base[i];
            }
            set
            {
                base[i] = value;
            }
        }

        public static CustomerList2 operator + (CustomerList2 cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        public static CustomerList2 operator  - (CustomerList2 cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }
    }
}
