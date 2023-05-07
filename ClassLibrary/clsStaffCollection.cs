using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for the list
        clsStaff mThisStaff = new clsStaff();
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
        public List <clsStaff> StaffList
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

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@Birthday", mThisStaff.Birthday);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@Available", mThisStaff.Available);
            //execute the query returin the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@Birthday", mThisStaff.Birthday);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@Available", mThisStaff.Available);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public clsStaffCollection()
        {
            
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //updete the list box
                DisplayStaffs();
            }
        }

        void DiplayStaffs()
        {
            //create an instance of the Address collection
            clsStaffCollection AnStaff = new clsStaffCollection();
            //set the data source to list of staffs in the collection
            lstStaffList.DataSource = AnStaff.StaffList;
            //set the name of the primary key
            lstStaffList.DataValueField = "StaffNo";
            //set the data field to display
            lstStaffList.DataTextField = "Salary";
            //blind the data to the list
            lstStaffList.DataBlind();
        }

        public void ReportBySalary(string Salary)
        {
            //filter the records based on a full or partial Salary
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Salary parameter to the database
            DB.AddParameter("@Salary", Salary);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterBySalary");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramater DB
            //var for the index
            Int32 Index = 0;
            //var to store the record
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current records
                AnStaff.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AnStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AnStaff.Salary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);
                AnStaff.Birthday = Convert.ToDateTime(DB.DataTable.Rows[Index]["Birthday"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["First Name"]);
                AnStaff.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }
        }
    }
}