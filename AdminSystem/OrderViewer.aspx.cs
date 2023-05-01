using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create anew instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        // get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        // display the customer address for this entry
        Response.Write(AnOrder.CustomerAddress);
        Response.Write(AnOrder.Amount);
        Response.Write(AnOrder.DateOrdered);
        Response.Write(AnOrder.PaymentMethod);
        Response.Write(AnOrder.Paid);

    }
}