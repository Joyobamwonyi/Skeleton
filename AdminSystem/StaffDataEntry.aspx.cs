using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false);
        {
            //if this is not a new record
            if (StaffNo != -1)
            {
                //display the current data for the record
                //DisplayStaff();
            }
        }

    }

    /*void DisplayStaff()
    {
        //create an instance of the staff
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffNo);
        //display the data for this record
        txtStaffNo.Text = StaffBook.ThisStaff.StaffNo.ToString(); ;
        txtFirstName.Text = StaffBook.ThisStaff.FirstName;
        txtSurname.Text = StaffBook.ThisStaff.Surname;
        txtBirthday.Text = StaffBook.ThisStaff.Birthday.ToString();
        txtSalary.Text = StaffBook.ThisStaff.Salary.ToString(); ;
        chkAvailable.Checked = StaffBook.ThisStaff.Available;

    } */

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the First name
        string FirstName = txtFirstName.Text;
        //capture the Surname
        string Surname = txtSurname.Text;
        //set the birthday property
        string Birthday = txtBirthday.Text;
        //set the salary property
        string Salary = txtSalary.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(FirstName, Surname, Birthday, Salary);
        if (Error == "")
        {
            //capture the Staff number
            AnStaff.StaffNo = StaffNo;
            //capture the first name
            AnStaff.FirstName = FirstName;
            //capture the surname
            AnStaff.Surname = Surname;
            //capture the birthday
            AnStaff.Birthday = Convert.ToDateTime(Birthday);
            //capture the salary
            AnStaff.Salary = Convert.ToInt32(Salary);
            //capture available
            AnStaff.Available = chkAvailable.Checked;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffNo = -1 then add the data
            if (StaffNo == -1)
            {
            // set the ThisStaff property
            StaffList.ThisStaff = AnStaff;
            //add the new record
            StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffNo);
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //update the record
                StaffList.Update();
            }
            //redirect to the the listpage
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the of the staff class
        clsStaff AnStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find the record
        Found = AnStaff.Find(StaffNo);
        //if found
        if (Found == true) 
        {
            //display the values of the properties in the form
            txtStaffNo.Text = AnStaff.StaffNo.ToString(); ;
            txtFirstName.Text = AnStaff.FirstName;
            txtSurname.Text = AnStaff.Surname;
            txtBirthday.Text = AnStaff.Birthday.ToString();
            txtSalary.Text = AnStaff.Salary.ToString(); ;
            chkAvailable.Checked = AnStaff.Available;
        }
    }
}