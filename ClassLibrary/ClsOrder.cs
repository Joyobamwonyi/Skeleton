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
            // set the private data members to the test data value
            mOrderID = 1;
            mCustomerAddress = "123 Main Street";
            mDateOrdered = Convert.ToDateTime("16/9/2023");
            mPaymentMethod = "Credit Card";
            mAmount = 10.99m;
            mPaid = true;

            // always return true
            return true;
        }
    }
}