using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstPayment
    {
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
            AnPayment.cardNumber = TestData;
            Assert.AreEqual(AnPayment.cardNumber, TestData);
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


    }
}
