﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Acme.Common;
using ACM.BL;

namespace Acme.CommomTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //--Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel handle",
                CurrentPrice = 6M
            };
            changedItems.Add(product as ILoggable);

            //--Act
            LoggingService.WriteToFile(changedItems);
            
            //--Assert
            //Nothing to assert
        }
    }
}
