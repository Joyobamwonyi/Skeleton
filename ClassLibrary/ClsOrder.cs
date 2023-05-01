using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        // private data members for properties
        private Int32 mOrderID;
        private string mCustomerAddress;
        private DateTime mDateOrdered;
        private string mPaymentMethod;
        private decimal mAmount;
        private Boolean mPaid;
       

        public DateTime DateOrdered 
        { 
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered = value;
            }
        }
        public string CustomerAddress { 
            get
            {
                // this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                // this line of code allows data into the property
                mCustomerAddress = value;
            }
        }
        public string PaymentMethod 
        {
            get
            {
                return mPaymentMethod;
            }
            set
            {
                mPaymentMethod = value;
            }
        }
        public decimal Amount
        {
            get
            {
                return mAmount;
            }

            set
            {
                mAmount = value;
            }
        }
        public Boolean Paid
        {
            get
            {
                return mPaid;
            }

            set
            {
                mPaid = value;
            }
        }

        public bool Find(int OrderID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the address no to search for
            DB.AddParameter("@OrderID", OrderID);
            // executre the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                mPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["Paid"]);
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
            // set the private data members to the test data value
           /* mOrderID = 1;
            mCustomerAddress = "123 Main Street";
            mDateOrdered = Convert.ToDateTime("16/9/2023");
            mPaymentMethod = "Credit Card";
            mAmount = 10.99m;
            mPaid = true;*/

            // always return true
            return true;
        }
    }
}