﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FulNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //--Act

            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FulNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Bilbo";

            string expected = "Bilbo";

            //--Act

            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FulNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Baggins";

            string expected = "Baggins";

            //--Act

            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest() 
        { 
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //--Act
            //--Assert
            Assert.AreEqual(Customer.InstanceCount, 3);
        }

        [TestMethod]
        public void ValidateValid() 
        {
            //--Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = true; 

            //--Act
            var actual = customer.Validate();

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange
            var customer = new Customer();
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = false;

            //--Act
            var actual = customer.Validate();

            //-Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
