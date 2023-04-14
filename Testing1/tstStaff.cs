using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            Boolean TestData = true;
            //assign data to the property
            AnStaff.Available = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.Available, TestData);
        }

        [TestMethod]
        public void BirthdayPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AnStaff.Birthday = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.Birthday, TestData);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            AnStaff.StaffNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            decimal TestData = 1;
            //assign data to the property
            AnStaff.Salary = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.Salary, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "FirstName";
            //assign data to the property
            AnStaff.FirstName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }

        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Surname";
            //assign data to the property
            AnStaff.Surname = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.Surname, TestData);
        }
    }
}
