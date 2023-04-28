using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

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
            //capture the first name
            AnStaff.FirstName = FirstName;
            //capture the surname
            AnStaff.Surname = Surname;
            //capture the birthday
            AnStaff.Birthday = Convert.ToDateTime(Birthday);
            //capture the salary
            AnStaff.Salary = Convert.ToInt32(Salary);
            //store the staff in the session object
            Session["AnStaff"] = AnStaff;
            //redirect to the viewer page
            Response.Write("StaffViewer.aspx");
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
        if (Found == true) ;
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