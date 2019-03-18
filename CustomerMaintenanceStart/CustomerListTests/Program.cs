using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerListTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerListConstructor();
            TestCustomerListAdd();
            TestCustomerListRemove();
            TestCustomerListIndexers();
            Console.WriteLine();


            TestWholeSaleCustomer();
            Console.WriteLine();
            TestRetailCustomer();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestCustomerListConstructor()
        {
            CustomerList cList = new CustomerList();

            Console.WriteLine("Testing constructor");
            Console.WriteLine("Default constructor. Expecting count of 0 " + cList.Count);
            Console.WriteLine("Default constructor. Expecting empty string" + cList);
            Console.WriteLine();
        }

        static void TestCustomerListAdd()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");
            Customer c3 = new Customer("Trevor", "Rogers", "randomstuff@gmail.com");

            Console.WriteLine("Testing Add method");
            cList.Add(c1);
            Console.WriteLine("Testing Add method that takes a customer parameter");
            Console.WriteLine("Expecting count of 1 " + cList.Count);
            Console.WriteLine("Expecting list of 1 customer: \n" + cList);

            cList.Add("Trevor", "Rogers", "fakeemail@email.com");
            Console.WriteLine("Add that takes individual customer attributes and constructs customer");
            Console.WriteLine("Expecting count of 2 " + cList.Count);
            Console.WriteLine("Expecting list of 2 customers: \n" + cList);

            cList += c3;
            Console.WriteLine("Testing overloaded + operator");
            Console.WriteLine("Expecting count of 3 " + cList.Count);
            Console.WriteLine("Expecting list of 3 customers:\n" + cList);
            Console.WriteLine();
        }

        static void TestCustomerListRemove()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");
            Customer c3 = new Customer("Trevor", "Rogers", "randomstuff@gmail.com");

            cList.Add(c1);
            cList.Add("Trevor", "Rogers", "fakeemail@email.com");
            cList += c3;

            Console.WriteLine("Testing Remove method");
            cList.Remove(c1);
            Console.WriteLine("Expecting count of 2 " + cList.Count);
            Console.WriteLine("Expecting list of 2 customers: \n" + cList);

            cList -= c3;
            Console.WriteLine("Testing overloaded - operator");
            Console.WriteLine("Expecting count of 1 " + cList.Count);
            Console.WriteLine("Expecting list of 1 customer: \n" + cList);
            Console.WriteLine();
        }

        static void TestCustomerListIndexers()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");
            Customer c3 = new Customer("Trevor", "Rogers", "randomstuff@gmail.com");

            cList.Add(c1);
            cList.Add("Trevor", "Rogers", "fakeemail@email.com");
            cList += c3;

            Console.WriteLine("Testing indexer");
            Console.WriteLine("Get customer with index 0");
            Customer c4 = cList[0];
            Console.WriteLine("Expecting Trevor with lane email address. " + c4.GetDisplayText());
            Console.WriteLine("Should not change list. Expecting count of 3 " + cList.Count);
            Console.WriteLine("Expecting list of 3 customers.  Trevor with lane email address is the first element in list:\n" + cList);
        }

        static void TestWholeSaleCustomer()
        {
            Console.WriteLine("Testing WholeSaleCustomer constructor.");
            WholesaleCustomer wholecus1 = new WholesaleCustomer("Bob", "Vance", "vancefridge@scranton.com", "Vance Refrigeration" );
            WholesaleCustomer wholecus2 = new WholesaleCustomer("Trevor", "Rogers", "rogerst@my.lanecc.edu", "Freelance Programmer");
            Console.WriteLine("Expecting Bob Vance, vancefridge@scranton.com (Vance Refrigeration).\n" + wholecus1.GetDisplayText());
            Console.WriteLine("Expecting Trevor Rogers, rogerst@my.lanecc.edu (Freelance Programmer).\n" + wholecus2.GetDisplayText());
        }

        static void TestRetailCustomer()
        {
            Console.WriteLine("Testing RetailCustomer constructor.");
            RetailCustomer retailcus1 = new RetailCustomer("John", "Smith", "jsmith@gmail.com", "(541)-123-4567");
            RetailCustomer retailcus2 = new RetailCustomer("Jon", "Snow", "kinginthenorth@winterfell.gov", "(123)-456-7890");

            Console.WriteLine("Expecting John Smith, jsmith@gmail.com ph: (541)-123-4567.\n" + retailcus1.GetDisplayText());
            Console.WriteLine("Expecting Jon Snow, kinginthenorth@winterfell.gov ph: (123)-456-7890.\n" + retailcus2.GetDisplayText());
        }
    }
}
