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
        public void ExpiredDatePropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            DateTime TestData = DateTime.Now.Date;
            AnPayment.ExpiredDate = TestData;
            Assert.AreEqual(AnPayment.ExpiredDate, TestData);
        }
        [TestMethod]
        public void BillingAddressPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            String TestData = "";
            AnPayment.BillingAddress = TestData;
            Assert.AreEqual(AnPayment.BillingAddress, TestData);
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
        public void FullNamePropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            String TestData = "";
            AnPayment.FullName = TestData;
            Assert.AreEqual(AnPayment.FullName, TestData);
        }


    }
}
