using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Retrieve one address
    /// </summary>
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            //create the instance of the Address class
            Address address = new Address(addressId);

            //code that retrieves the defined customer

            //temporary hard coded values to return
            //a populated address
            if (addressId == 1)
            {
                address.StreetLine1 = "123 Kitten Lane";
                address.StreetLine2 = "Kitten Town";
                address.City = "Hoboken";
                address.State = "New Jersey";
                address.Country = "United States";
                address.PostalCode = "666";

            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //code that retrieves the defined addresses
            //for customer

            //temporary hard coded values to return
            //a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "123 Kitten Lane",
                StreetLine2 = "Kitten Town",
                City = "Hoboken",
                State = "New Jersey",
                Country = "United States",
                PostalCode = "666"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "123"
            };
            addressList.Add(address);
        }

        /// <summary>
        /// Saves the current address
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            //code that saves a defined order
            return true;
        }
    }
}
