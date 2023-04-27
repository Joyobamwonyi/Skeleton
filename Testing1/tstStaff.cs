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
            Int32 TestData = 1;
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boollean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use within the method
            Int32 StaffNo= 3;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //booolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.StaffNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 2;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the property
            if (AnStaff.FirstName != "Karla")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 4;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the property
            if (AnStaff.Surname != "Hails")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBirthdayFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the property
            if (AnStaff.Birthday !=Convert.ToDateTime("11/05/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 2;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the property
            if (AnStaff.Salary != 2200)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 4;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the property
            if (AnStaff.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
