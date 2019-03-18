using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;

        public Customer() { }

        public Customer(string first, string last, string em)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Email = em;
        }

        public string FirstName
        {
            get
            {
                if (firstName.Length > 50)
                {
                    throw new ArgumentException("firstName");
                } else
                {
                    return firstName;
                }
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                if (lastName.Length > 50)
                {
                    throw new ArgumentException("lastName");
                } else
                {
                    return lastName;
                }
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                if (email.Length > 50)
                {
                    throw new ArgumentException("email");
                } else
                {
                    return email;
                }
            }
            set
            {
                email = value;
            }
        }

        public virtual string GetDisplayText()
        {
            string info;
            info = firstName + " " + lastName + ", " + email;
            return info;
        }
    }
}
