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
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        // create instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        // set the name of primary key
        lstOrderList.DataValueField = "OrderID";
        // set the data field to display
        lstOrderList.DataTextField = "CustomerAddress";
        

        // bind the data to the list
        lstOrderList.DataBind();
    }









    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        // redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the pk value of the record to be edited
        Int32 OrderID;
        // if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // get pk value of record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            // store the data in the session object            
            Session["OrderID"] = OrderID;
            // redirect to the data entry page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the pk value of the record to be edited
        Int32 OrderID;
        // if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // get pk value of record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            // store the data in the session object            
            Session["OrderID"] = OrderID;
            // redirect to the data entry page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // create instance of order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerAddress(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        // set name of pk
        lstOrderList.DataValueField = "OrderID";
        // set name of field to display
        lstOrderList.DataTextField = "CustomerAddress";
        // bind data to list
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {

        // create instance of order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerAddress("");
        // clear any existing filter to tidy up interface
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        // set name of pk
        lstOrderList.DataValueField = "OrderID";
        // set name of field to display
        lstOrderList.DataTextField = "CustomerAddress";
        // bind data to list
        lstOrderList.DataBind();
    }
}