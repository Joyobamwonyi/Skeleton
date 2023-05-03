using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // var to store the primary key of the record to be deleted
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get number of the order to be deleted from session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // crete new instance of Order class
        clsOrderCollection Order = new clsOrderCollection();
        // find the record to delete
        Order.ThisOrder.Find(OrderID);
        // delete the record
        Order.Delete();
        // redirect to mainpage 
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}