using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If this is the first time the page is displaced
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }

    }
    
    void DisplayStaffs()
    {
        //create an instance of the Staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of staff in collection
        lstStaffs.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffs.DataValueField = "StaffNo";
        //set the data field to the display
        lstStaffs.DataTextField = "Salary";
        //blind the data to the list
        lstStaffs.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaffs.SelectedIndex != -1)
        {
            //get the primary key value of the record edit
            StaffNo = Convert.ToInt32(lstStaffs.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
        //redirect to the edit page
        Response.Redirect("StaffDataEntry.aspx");
        }
        else//if no record has been selected
        {
            lblEnter.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be deleted
        Int32 StaffNo;
        //if a record has been selected from the list
        if (lstStaffs.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffNo = Convert.ToInt32(lstStaffs.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblEnter.Text = "Please select a record to deleted from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportBySalary(txtFilter.Text);
        lstStaffs.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffs.DataValueField = "StaffNo";
        //set the name of the data field to the display
        lstStaffs.DataTextField = "Salary";
        //blind the data to the list
        lstStaffs.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportBySalary("");
        //clear my existing filter to tidy up the interface
        txtFilter.Text = "";
        lstStaffs.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffs.DataValueField = "StaffNo";
        //set the data field to the display
        lstStaffs.DataTextField = "Salary";
        //blind the data to the list
        lstStaffs.DataBind();
    }
}