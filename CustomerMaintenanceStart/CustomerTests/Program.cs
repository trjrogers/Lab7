using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;
using CustomerMaintenance;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerConstructor();
            TestCustomerPropertyGetter();
            TestCustomerPropertySetter();
            TestCustomerGetDisplayText();
            TestCustomerList2();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestCustomerConstructor()
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");

            Console.WriteLine("Testing constructors.");
            Console.WriteLine("Default constructor. Expecting default values." + customer1.GetDisplayText());
            Console.WriteLine("Overloaded constructor. Expecting Trevor Rogers, rogerst@my.lanecc.edu. " + customer2.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerPropertyGetter()
        {
            Customer customer = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");

            Console.WriteLine("Testing getters.");
            Console.WriteLine("Testing first name. Expecting Trevor. " + customer.FirstName);
            Console.WriteLine("Testing last name. Expecting Rogers. " + customer.LastName);
            Console.WriteLine("Testing email. Expecting rogerst@my.lanecc.edu. " + customer.Email);
            Console.WriteLine();

        }

        static void TestCustomerPropertySetter()
        {
            Customer customer = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");

            Console.WriteLine("Testing setters.");
            customer.FirstName = "Griffin";
            customer.LastName = "McElroy";
            customer.Email = "test@test.com";

            Console.WriteLine("Expecting Griffin McElroy, test@test.com. " + customer.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerGetDisplayText()
        {
            Customer customer = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");

            Console.WriteLine("Testing GetDisplayText() method.");
            Console.WriteLine("Expecting Trevor Rogers, rogerst@my.lanecc.edu. " + customer.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerList2()
        {
            Console.WriteLine("Testing retail and wholesale in same list.");
            CustomerList2 cList = new CustomerList2();
            WholesaleCustomer wc1 = new WholesaleCustomer("Amy", "Johnson", "johnsona@lanecc.edu", "LCC");
            RetailCustomer rc1 = new RetailCustomer("Juan", "Lopez", "lopezj@lanecc.edu", "(541)-123-4567");
            cList.Add(wc1);
            cList += rc1;
            Console.WriteLine("Expecting list containing a wholesale customer, 'Amy Johnson', and a retail customer, 'Juan Lopez'\n" + cList);
            string allFirstNames = "";
            foreach (Customer c in cList)
            {
                allFirstNames = allFirstNames + " " + c.FirstName;
            }
            Console.WriteLine(allFirstNames);
        }
    }
}
