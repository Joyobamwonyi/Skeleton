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
        public void CustomerAddressPropertyOK()
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
        public void PaymentMethodPropertyOK()
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
        public void AmountPropertyOK()
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
        public void PaidPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // create test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Paid = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Paid, TestData);
        }

        // new code from here


        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddresFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the address
            if (AnOrder.CustomerAddress != "123 Main Street")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod] 
        public void TestDateOrderedFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK(Assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the property
            if (AnOrder.DateOrdered != Convert.ToDateTime("16/09/2023"))
            {
                OK = false;
            }

            // test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPaymentMethodFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK(Assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the property
            if (AnOrder.PaymentMethod != Convert.ToString("Credit Card"))
            {
                OK = false;
            }

            // test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAmountFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK(Assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the property
            if (AnOrder.Amount != Convert.ToDecimal(10.99m))
            {
                OK = false;
            }

            // test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPaidFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK(Assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the property
            if (AnOrder.Paid != Convert.ToBoolean(true))
            {
                OK = false;
            }

            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
