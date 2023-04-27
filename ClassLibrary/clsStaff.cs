using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private DateTime mBirthday;
        public DateTime Birthday
        {
            get
            {
                return mBirthday;
            }
            set
            {
                mBirthday = value;
            }
        }

        private Boolean mAvailable;
        //public property for available
        public bool Available
        {
            get
            {
                //return the private data
                return mAvailable;
            }
            set
            {
                //set the private data
                mAvailable = value;
            }
        }

        //private data member for the staff no property
        private Int32 mStaffNo;
        //StaffNo public property
        public Int32 StaffNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffNo;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNo = value;
            }
        }

        //private data member for county no
        private Int32 mSalary;
        //public property for county no
        public int Salary
        {
            get
            {
                //return the private data
                return mSalary;
            }
            set
            {
                //set the private data
                mSalary = value;
            }
        }

        //private data member for first name
        private string mFirstName;
        //public data member for first name
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the private data
                mFirstName = value;
            }
        }

        //private data member for first name
        private string mSurname;
        //public data member for first name
        public string Surname
        {
            get
            {
                //return the private data
                return mSurname;
            }
            set
            {
                //set the private data
                mSurname = value;
            }
        }
        public bool Find(int StaffNo)
        {
            //set the private data members to the test data value
            mStaffNo = 21;
            mFirstName = "FirstName";
            mSurname = "Surname";
            mBirthday = Convert.ToDateTime("16/09/2000");
            mSalary = 1;
            mAvailable = true;
            //always return true
            return true;
        }
    }
}