using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                // display current data for the record
                DisplayOrder();
            }
        }
    }

    private void DisplayOrder()
    {
        // creat instance of Order
        clsOrderCollection Order = new clsOrderCollection();
        // find the record to update
        Order.ThisOrder.Find(OrderID);
        // display the data for this record
        txtOrderID.Text = Order.ThisOrder.OrderID.ToString();
        txtAddress.Text = Order.ThisOrder.CustomerAddress;
        drpPaymentMethod.SelectedValue = Order.ThisOrder.PaymentMethod;
        txtAmount.Text = Order.ThisOrder.Amount.ToString();
        txtDateOrdered.Text = Order.ThisOrder.DateOrdered.ToString();
        chkPaid.Checked = Order.ThisOrder.Paid;
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

            // capture paid
            AnOrder.Paid = chkPaid.Checked;
            // create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            // if this is a new record i.e. OrderID = -1 then add the data
            if (OrderID == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                // add the new record
                OrderList.Add();
            }
            // otherwise it must be an update
            else
            {
                // find the record to update
                OrderList.ThisOrder.Find(OrderID);
                // set the thisorder property
                OrderList.ThisOrder = AnOrder;
                // update the record
                OrderList.Update();
            }
            
            // redirect back to the list page
            Response.Redirect("OrderList.aspx");
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
