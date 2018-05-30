using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        /// <summary>
        /// Retrieves one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //create the instance of the customer class
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            //code that retrieves the defined customer

            //temporary hard coded values to return
            //a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "LordofDarkness@darkness.com";
                customer.FirstName = "Glenn";
                customer.LastName = "Danzig";
            }

            return customer;
        }

        /// <summary>
        /// Retrieve
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined customer
            return true;
        }
    }
}
