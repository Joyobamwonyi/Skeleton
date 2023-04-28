using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff { get; set; }

        public clsStaffCollection()
        {
            //create the items of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Available = true;
            TestItem.StaffNo = 1;
            TestItem.Salary = 1;
            TestItem.Birthday = DateTime.Now.Date;
            TestItem.FirstName = "Jenny";
            TestItem.Surname = "Blue";
            //add the item to the test list
            mStaffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStaff();
            //set its properties
            TestItem.Available = true;
            TestItem.StaffNo = 2;
            TestItem.Salary = 2;
            TestItem.Birthday = DateTime.Now.Date;
            TestItem.FirstName = "Karla";
            TestItem.Surname = "Bird";
            //add the item to the test list
            mStaffList.Add(TestItem);
        }
    }
}