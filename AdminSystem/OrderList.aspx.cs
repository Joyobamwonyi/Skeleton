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
}