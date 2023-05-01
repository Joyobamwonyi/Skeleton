using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);

        }

        [TestMethod]
        public void DateOrderedPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            // create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateOrdered = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }


        [TestMethod]
        public void CustomerAddressProperty()
        {
            clsOrder AnOrder = new clsOrder();
            // create test data to assign to the property
            string TestData = "123 Main Street";
            //assign the data to the property
            AnOrder.CustomerAddress = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerAddress, TestData);
        }


        [TestMethod]
        public void PaymentMethodProperty()
        {
            clsOrder AnOrder = new clsOrder();
            // create test data to assign to the property
            string TestData ="Credit Card";
            //assign the data to the property
            AnOrder.PaymentMethod = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentMethod, TestData);
        }


        [TestMethod]
        public void AmountProperty()
        {
            clsOrder AnOrder = new clsOrder();
            // create test data to assign to the property
            decimal TestData = 10.99m;
            //assign the data to the property
            AnOrder.Amount = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Amount, TestData);
        }


        [TestMethod]
        public void PaidProperty()
        {
            clsOrder AnOrder = new clsOrder();
            // create test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Paid = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Paid, TestData);
        }




    }
}
