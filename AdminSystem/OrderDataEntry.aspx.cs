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
        string CustomerAddress = txtAddress.Text;
        // capture the payment method
        string PaymentMethod = drpPaymentMethod.SelectedValue;
        // capture the Amount
        string Amount = txtAmount.Text;
        // capture the order date
        string DateOrdered = txtDateOrdered.Text;

        String Error = "";

        // validate the data
        Error = AnOrder.Valid(CustomerAddress, PaymentMethod, Amount, DateOrdered);

        if (Error == "")
        {
            // capture the customer address
            AnOrder.CustomerAddress = txtAddress.Text;
            // capture the payment method
            AnOrder.PaymentMethod = drpPaymentMethod.SelectedValue;
            // capture the Amount
            AnOrder.Amount = Convert.ToDecimal(txtAmount.Text);
            // capture the order date
            AnOrder.DateOrdered = Convert.ToDateTime(txtDateOrdered.Text);

            // store the order in the session object
            Session["AnOrder"] = AnOrder;
            // navigate to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }   
        else
        {
            // display the error message
            lblError.Text = Error;
        }
    }

    protected void chkPaid_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // creat an instance of the order class
        clsOrder AnOrder = new clsOrder();
        // variable to store the primary key
        Int32 OrderID;
        // variable to store the result of the find operation
        Boolean Found = false;
        // get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        // find the record
        Found = AnOrder.Find(OrderID);
        // if found
        if (Found == true)
        {
            // display the values of the properties in the form
            txtAddress.Text = AnOrder.CustomerAddress;
            drpPaymentMethod.SelectedValue = AnOrder.PaymentMethod;
            txtAmount.Text = AnOrder.Amount.ToString();
            txtDateOrdered.Text = AnOrder.DateOrdered.ToString();
            chkPaid.Checked = AnOrder.Paid; 
        }
    }
}
