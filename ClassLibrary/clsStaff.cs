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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff no to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mBirthday = Convert.ToDateTime(DB.DataTable.Rows[0]["Birthday"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}