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
        //capture the Staff number
        AnStaff.StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //capture the First name
        AnStaff.FirstName = txtFirstName.Text;
        //capture the Surname
        AnStaff.Surname = txtSurname.Text;
        //set the birthday property
        AnStaff.Birthday = Convert.ToDateTime(txtBirthday.Text);
        //set the salary property
        AnStaff.Salary = Convert.ToInt32(txtSalary.Text);
        //set the checkbox available property
        AnStaff.Available = chkAvailable.Checked;
        //store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
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
            txtStaffNo.Text = AnStaff.StaffNo;
            txtFirstName.Text = AnStaff.FirstName;
            txtSurname.Text = AnStaff.Surname;
            txtBirthday.Text = AnStaff.Birthday.DateAdded.ToString();
            txtSalary.Text = AnStaff.Salary;
            chkAvailable.Checked = AnStaff.Available;
        }
    }
}