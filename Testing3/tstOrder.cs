using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder clSO = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(clSO);

        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder clsO = new clsOrder();

            int testID = 1;
            clsO.OrderID = testID;

            Assert.AreEqual(clsO.OrderID, testID);

        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsOrder clsO = new clsOrder();
            string testData = "String";
            clsO.Address = testData;
            Assert.AreEqual(clsO.Address, testData);

        }


    }
}



