using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Available = true;
            TestItem.StaffNo = 1;
            TestItem.Salary = 1;
            TestItem.Birthday = DateTime.Now.Date;
            TestItem.FirstName = "Jenny";
            TestItem.Surname = "Blue";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Available = true;
            TestStaff.StaffNo = 1;
            TestStaff.Salary = 1;
            TestStaff.Birthday = DateTime.Now.Date;
            TestStaff.FirstName = "Jenny";
            TestStaff.Surname = "Blue";
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Available = true;
            TestItem.StaffNo = 1;
            TestItem.Salary = 1;
            TestItem.Birthday = DateTime.Now.Date;
            TestItem.FirstName = "Jenny";
            TestItem.Surname = "Blue";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.StaffNo = 1;
            TestItem.Salary = 1;
            TestItem.Birthday = DateTime.Now.Date;
            TestItem.FirstName = "Jenny";
            TestItem.Surname = "Blue";
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff,TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.StaffNo = 1;
            TestItem.Salary = 1;
            TestItem.Birthday = DateTime.Now.Date;
            TestItem.FirstName = "Jenny";
            TestItem.Surname = "Blue";
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.StaffNo = 1;
            TestItem.Salary = 1;
            TestItem.Birthday = DateTime.Now.Date;
            TestItem.FirstName = "Jenny";
            TestItem.Surname = "Blue";
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //Set the primary for the last data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffs.Delete();
            //now find the record
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySalaryMethodOK()
        {
            //create an instance of the class cointaining unfilitered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaffs.ReportBySalary("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportBySalaryNoneFound()
        {
            //create an instance of the filitered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a salary that doesn't exist
            FilteredStaffs.ReportBySalary("");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportBySalary(string Salary)
        {
            //filters the records based on a full or partial salary
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the salary parameter to the database
            DB.AddParameter("@Salary", Salary);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterBySalary");
        }

        [TestMethod]
        public void ReportBySalaryTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredStaffs.ReportBySalary("4000");
            //check that the correct number of records are found
            if (FilteredStaffs.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStaffs.StaffList[0].StaffNo != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredStaffs.StaffList[1].StaffNo != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }

}
