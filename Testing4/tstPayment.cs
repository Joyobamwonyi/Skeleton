using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstPayment
    {
        

        string PymNo = "2";
        string ExparationDate = DateTime.Now.Date.ToString();
        string PostalCode = "le2 6fp";
        string CardNumber = "1234";
        string cvv = "123";


        [TestMethod]
        public void InstanceOK()
        {
            clsPayment AnPayment = new clsPayment();
            Assert.IsNotNull(AnPayment);
        }

        [TestMethod]
        public void ActivePropretyOK()
        {
            clsPayment AnPayment = new clsPayment();
            Boolean TestData = true;
            AnPayment.Active = TestData;
            Assert.AreEqual(AnPayment.Active, TestData);


        }
        [TestMethod]
        public void ExparationDatePropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            DateTime TestData = DateTime.Now.Date;
            AnPayment.ExparationDate = TestData;
            Assert.AreEqual(AnPayment.ExparationDate, TestData);
        }
        [TestMethod]
        public void PostalCodePropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            String TestData = "";
            AnPayment.PostalCode = TestData;
            Assert.AreEqual(AnPayment.PostalCode, TestData);
        }

        [TestMethod]
        public void cardNumberPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            Int32 TestData = 1;
            AnPayment.CardNumber = TestData;
            Assert.AreEqual(AnPayment.CardNumber, TestData);
        }
        [TestMethod]
        public void cvvPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            Int32 TestData = 1;
            AnPayment.cvv = TestData;
            Assert.AreEqual(AnPayment.cvv, TestData);
        }
        [TestMethod]
        public void savePaymentInfoPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            Int32 TestData = 1;
            AnPayment.cvv = TestData;
            Assert.AreEqual(AnPayment.cvv, TestData);
        }

        [TestMethod]
        public void NameOnCardPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            String TestData = "";
            AnPayment.NameOnCard = TestData;
            Assert.AreEqual(AnPayment.NameOnCard, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsPayment AnPayment = new clsPayment();
            Boolean Found = false;
            Int32 PymNo = 1;
            Found = AnPayment.Find(PymNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestPaymentNotFound()
        {
            clsPayment AnPayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PymNo = 1;
            Found = AnPayment.Find(PymNo);
            if (AnPayment.PymNo != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestNameOnCardFound()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PymNo = 1;
            //invoke the method
            Found = AnPayment.Find(PymNo);
            //check the property
            if (AnPayment.NameOnCard != "Badr")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestcvvFound()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PymNo = 1;
            //invoke the method
            Found = AnPayment.Find(PymNo);
            //check the property
            if (AnPayment.cvv != 211)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCardNumberFound()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PymNo = 1;
            //invoke the method
            Found = AnPayment.Find(PymNo);
            //check the property
            if (AnPayment.CardNumber != 123456)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestExparationDateFound()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PymNo = 1;
            //invoke the method
            Found = AnPayment.Find(PymNo);
            //check the property
            if (AnPayment.ExparationDate != Convert.ToDateTime("10/10/2002 00:00:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostalCodeFound()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PymNo = 1;
            //invoke the method
            Found = AnPayment.Find(PymNo);
            //check the property
            if (AnPayment.PostalCode != "le2 6p")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
           

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsPayment AnPayment = new clsPayment();
            String Error = "";
            Error = AnPayment.Valid(ExparationDate, PostalCode, CardNumber, cvv);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void cardNumberMin()
        {
            //create an instance of the class we want to create
            clsPayment AnAddress = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = ""; //this should be ok
            //invoke the method
            Error = AnAddress.Valid(HouseNo, Street, Town, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
    }
