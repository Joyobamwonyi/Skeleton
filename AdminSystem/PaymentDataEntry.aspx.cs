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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void btnPay_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsPayment AnPayment = new clsPayment();
        //capture the name on card
        AnPayment.NameOnCard = txtNameonCard.Text;
        AnPayment.CardNumber = Convert.ToInt32(txtCardNumber.Text);
        AnPayment.cvv = Convert.ToInt32(txtCvv.Text);
        AnPayment.PostalCode = txtPostalCode.Text;
        AnPayment.Active = chkActive.Checked;
        AnPayment.ExparationDate = Convert.ToDateTime(txtExparationDate);


        //store the payment in the session object
        Session["AnPayment"] = AnPayment;

        //navigate to the viewer page
        Response.Redirect("PaymentViewer.aspx");
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsPayment AnPayment = new clsPayment();
        Int32 PymNo;
        Boolean Found = false;
        PymNo = Convert.ToInt32(txtPymNo.Text);
        Found = AnPayment.Find(PymNo);
        if (Found == true)
        {
            txtCardNumber.Text = AnPayment.CardNumber.ToString();
            txtCvv.Text = AnPayment.cvv.ToString();
            txtExparationDate.Text = AnPayment.ExparationDate.ToString();
            txtNameonCard.Text = AnPayment.NameOnCard;
            txtPostalCode.Text = AnPayment.PostalCode;
            chkActive.Checked = AnPayment.Active;


        }

    }

    protected void TextBox1_TextChanged2(object sender, EventArgs e)
    {

    }
}