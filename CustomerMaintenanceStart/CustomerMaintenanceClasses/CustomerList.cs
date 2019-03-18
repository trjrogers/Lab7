using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList : List<Customer>
    {
        private List<Customer> customers;

        public int Count
        {
            get
            {
                return customers.Count;
            }
        }

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public Customer this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= customers.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return customers[i];
            }
            set
            {
                customers[i] = value;
            }
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Add(string firstName, string lastName, string email)
        {
            Customer c = new Customer(firstName, lastName, email);
            customers.Add(c);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }

        public static CustomerList operator +(CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        public static CustomerList operator -(CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }

        public new virtual string ToString()
        {
             {
                string str = "";
                foreach (Customer c in customers)
                {
                    str += (c.GetDisplayText() + "\n");
                }
                return str;
            }
        }
    }
}
