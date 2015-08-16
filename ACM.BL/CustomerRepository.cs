using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            //Create the instance of the Customer Class
            Customer customer = new Customer(customerId);

            //Code that retrieves the defined customer

            //Temporary hard coded values to return 
            //a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
        public List<Customer> Retrieve()
        {
            //TBD
            return new List<Customer>();
        }
        public bool Save()
        {
            //TBD
            return true;
        }
    }
}
