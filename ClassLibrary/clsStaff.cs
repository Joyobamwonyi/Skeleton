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

        public object TestItem { get; set; }

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

        public string Valid(string firstName,string birthday, string surname,string salary)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the first name is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            //if the first name is greater than 9 chracters
            if (firstName.Length > 9)
            {
                //record the error
                Error = Error + "The first name must be less than 9 characters : ";
            }
            try
            {
                //copy the birthday value to the dateTemp variable
                DateTemp = Convert.ToDateTime(birthday);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date can not be in the future : ";
                }
                if (DateTemp == DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date can not be now : ";
                }
            }
            catch
            {
                //return the error
                Error = Error + "The date was not a valid date : ";
            }
            //if the surname is blank
            if (surname.Length == 0)
            {
                //record the error
                Error = Error + "The surname may not be blank : ";
            }
            //if the surname is greater than 9 chracters
            if (surname.Length > 9)
            {
                //record the error
                Error = Error + "The surname must be less than 9 characters : ";
            }
            //if the salary is blank
            if (salary.Length == 0)
            {
                //record the error
                Error = Error + "The salary may not be blank : ";
            }
            //if the salary is greater than 9 chracters
            if (salary.Length > 9)
            {
                //record the error
                Error = Error + "The salary must be less than 9 characters : ";
            }
            //return any error message
            return Error;
        }
    }
}