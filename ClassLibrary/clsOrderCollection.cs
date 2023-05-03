using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // constuctor for the class
        public clsOrderCollection()
        {
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            // populate array list with data table
            PopulateArray(DB);
        }

        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        // private data member for ThiOrder
        clsOrder mThisOrder = new clsOrder();

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrder ThisOrder { 
            get
            {
                // return the private data
                return mThisOrder;
            }
            set
            {
                // set private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            // adds a new record to the db based on the values of mThisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the params for gthe stored procedure
            DB.AddParameter("@CustomerAddress", mThisOrder.CustomerAddress);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@Amount", mThisOrder.Amount);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@Paid", mThisOrder.Paid);
            // return the pk of the new record
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of this Address
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the params for gthe stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerAddress", mThisOrder.CustomerAddress);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@Amount", mThisOrder.Amount);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@Paid", mThisOrder.Paid);
            // execute the update procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the params for the stored proc
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerAddress(string CustomerAddress)
        {
            // filteres the records based on a full or partial address
            // connect to db
            clsDataConnection DB = new clsDataConnection();
            //send the address param to db
            DB.AddParameter("@CustomerAddress", CustomerAddress);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerAddress");
            // populate array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            //var for Index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount;
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank order
                clsOrder AnOrder = new clsOrder();
                // read in the fields from the current record
                AnOrder.Paid = Convert.ToBoolean(DB.DataTable.Rows[Index]["Paid"]);
                AnOrder.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                AnOrder.Amount = Convert.ToDecimal(DB.DataTable.Rows[Index]["Amount"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]);
                // add the record to the private data member
                mOrderList.Add(AnOrder);
                // point at next record
                Index++;

            }

        }

    }
}