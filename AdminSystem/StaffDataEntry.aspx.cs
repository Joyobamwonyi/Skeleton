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
}