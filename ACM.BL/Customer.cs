using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
            : this(0)//constructor chaining, this constructor calls the other constructor
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();//sets an empty list
        }

        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        private string _lastName;//field

        public string LastName //property
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName { get; set; }  //auto-implemented property, field is in the background

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }//we can set this property, but any code external to this cannot

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;      
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
