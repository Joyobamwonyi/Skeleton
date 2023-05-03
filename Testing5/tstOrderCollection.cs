using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary;

namespace Testing1
{
    class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AnOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Paid = true;
            TestItem.CustomerAddress = "123 Main Street";
            TestItem.PaymentMethod = "Credit Card";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Amount = 10.99m;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.Paid = true;
            TestOrder.CustomerAddress = "123 Main Street";
            TestOrder.PaymentMethod = "Credit Card";
            TestOrder.DateOrdered = DateTime.Now.Date;
            TestOrder.Amount = 10.99m;

            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Paid = true;
            TestItem.CustomerAddress = "123 Main Street";
            TestItem.PaymentMethod = "Credit Card";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Amount = 10.99m;

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            // var to store the pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Paid = true;
            TestItem.OrderID = 5;
            TestItem.CustomerAddress = "123 Main Street";
            TestItem.PaymentMethod = "Credit Card";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Amount = 10.99m;

            // set thisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //add the item to the test list
            PrimaryKey = AllOrders.Add();
            // set the pk of the test data
            TestItem.OrderID = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            // var to store the pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Paid = true;
            TestItem.CustomerAddress = "123 Main Street";
            TestItem.PaymentMethod = "Credit Card";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Amount = 10.99m;

            // set thisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //add the item to the test list
            PrimaryKey = AllOrders.Add();
            // set the pk of the test data
            TestItem.OrderID = PrimaryKey;

            //modify the test data
            TestItem.Paid = false;
            TestItem.CustomerAddress = "345 Main Street";
            TestItem.PaymentMethod = "Debit Card";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Amount = 1000.99m;

            // set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            // Update the record
            AllOrders.Update();
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            // var to store the pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Paid = true;
            TestItem.OrderID = 5;
            TestItem.CustomerAddress = "123 Main Street";
            TestItem.PaymentMethod = "Credit Card";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Amount = 10.99m;

            // set thisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //add the item to the test list
            PrimaryKey = AllOrders.Add();
            // set the pk of the test data
            TestItem.OrderID = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // delete the record
            AllOrders.Delete();
            // now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void ReportByCustomerAddressMethodOK()
        {
            // instance of class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            // instance of filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply blank string (should return all records
            FilteredOrders.ReportByCustomerAddress("");
            // test to see that two values are same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerAddressNoneFound()
        {
            // creete instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply a post code that doesn't exist
            FilteredOrders.ReportByCustomerAddress("ll lll");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerAddressDataFound()
        {
            // creete instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a post code that doesn't exist
            FilteredOrders.ReportByCustomerAddress("llkl lll");

            // check that correct no. of records are found
            if (FilteredOrders.Count == 2)
            {
                // check that first record is ID 36
                if (FilteredOrders.OrderList[0].OrderID != 1)
                {
                    OK = false;

                }
                // check that first record is ID 2
                if (FilteredOrders.OrderList[0].OrderID != 2)
                {
                    OK = false;

                }
                else
                {
                    OK = false;
                }


            }
            // test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
