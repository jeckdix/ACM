using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting;
using ACM.BLTest;
using ACM;


namespace ACM.BLTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullNameTestValid ()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };


            string expected = "Baggins, Bilbo";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);


        }
    }
}
