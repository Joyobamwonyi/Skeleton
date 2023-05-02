using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        // good test data
        // create some test data to pass to the method
        string CustomerAddress = "123 Main Street";
        string PaymentMethod = "Credit Card";
        string Amount = (10.99m).ToString();
        string DateOrdered = DateTime.Now.Date.ToString();



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
            Int32 OrderID = 5;
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

        [TestMethod]

        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*      CustomerAddress Tests      */

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerAddress = "1oak"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerAddress = "1 Oak"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerAddress = "Ave Rd"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerAddress = "42 Argyle Street, Merchant City, Glasgow G2 8A UK"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerAddress = "42 Argyle Street, Merchant City, Glasgow G2 8A, UK"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerAddress = "15 Nassau Street, Dublin."; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerAddress = "42 Argyle Street, Merchant City, Glasgow G2 8AG, UK"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'a'); // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*      DateOrdered Tests      */

        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create a variable to store the test date data
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            // convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOrderedMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create a variable to store the test date data
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            // convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create a variable to store the test date data
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create a variable to store the test date data
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            // convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create a variable to store the test date data
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            // convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*   test for invalid data     */
        [TestMethod] 
        public void DateOrderedInvalidData()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the DateOrdered to a non date value
            string DateOrdered = "this is not a date";
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*    PaymentMethod tests: to note-> the input is a drop down select box so only three tests are needed: 
         
                    minLessOne, min, max
                
         */

        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string PaymentMethod = "0"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string PaymentMethod = "PayPal"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string PaymentMethod = "Credit Card"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*     Amount tests    */


        [TestMethod]
        public void AmountExtremeMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            decimal NoAmount = 0; // this should trigger an error
            NoAmount -= 1000000m;
            string Amount = NoAmount.ToString();
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Amount = ""; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AmountMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Amount = "1"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Amount = "2"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Amount = "500000"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AmountMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Amount = "999999"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AmountMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Amount = "1000000"; // this should be ok
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AmountMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Amount = "1000001"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AmountExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Amount = "20000000"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*   test for invalid amount     */
        [TestMethod]
        public void AmountInvalidData()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the Amount to a non amount value
            string Amount = "Hello";
            Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
