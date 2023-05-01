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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        // capture the customer address
        AnOrder.CustomerAddress = txtAddress.Text;
        // capture the payment method
        AnOrder.PaymentMethod = drpPaymentMethod.SelectedValue;
        // capture the Amount
        AnOrder.Amount = Convert.ToDecimal(txtAmount.Text);
        // capture the order date
        AnOrder.DateOrdered = Convert.ToDateTime(txtDateOrdered.Text);
        // capture the payment method
        AnOrder.Paid = chkPaid.Checked;
        
        // store the address in the session object
        Session["AnOrder"] = AnOrder;

        // navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void chkPaid_CheckedChanged(object sender, EventArgs e)
    {

    }
}