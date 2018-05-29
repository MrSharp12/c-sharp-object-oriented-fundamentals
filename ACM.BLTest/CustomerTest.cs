using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //arrange
            Customer customer = new Customer();
            customer.FirstName = "Glenn";
            customer.LastName = "Danzig";

            string expected = "Danzig, Glenn";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //arrange
            Customer customer = new Customer();
            customer.LastName = "Danzig";
            string expected = "Danzig";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLasttNameEmpty()
        {
            //arrange
            Customer customer = new Customer();
            customer.FirstName = "Glenn";
            string expected = "Glenn";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //arrange
            var c1 = new Customer();
            c1.FirstName = "Glenn";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Doyle";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rick";
            Customer.InstanceCount += 1;

            //act


            //assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //arrange
            var customer = new Customer();
            customer.LastName = "Danzig";
            customer.EmailAddress = "RealmofDarkness@darkness.com";

            var expected = true;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //arrange
            var customer = new Customer();
            customer.EmailAddress = "RealmofDarkness@darkness.com";

            var expected = false;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
