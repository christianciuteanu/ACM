using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommomTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //--Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {
            //--Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //--Act
            var actual = source.InsertSpaces();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
