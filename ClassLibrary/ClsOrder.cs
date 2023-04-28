using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
    {

        public class clsOrder

        {
            private int mord;


            public int OrderID
            {
                get { return mord; }

                set { mord = value; }
            }

            private string mAddress;
            public string Address
            {
                get { return mAddress; }

                set { mAddress = value; }
            }

            private DateTime mDatepaid;
            public System.DateTime Datepaid
            {
                get { return mDatepaid; }

                set { mDatepaid = value; }
            }


            private string mCustomerNames;
            public string CustomerNames
            {
                get { return mCustomerNames; }

                set { mCustomerNames = value; }
            }


            private Double mTotalCost;
            public Double TotalCost
            {
                get { return mTotalCost; }

                set { mTotalCost = value; }
            }


            private bool mOver18;
            public bool Over18
            {
                get { return mOver18; }

                set { mOver18 = value; }
            }






            public bool Find(int orderID)
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@OrderID", orderID);
                DB.Execute("sproc_tblOrder_FilterByOrderID");
                if (DB.Count == 1)
                {
                    mord = Convert.ToInt32(DB.DataTable.Rows[0]["Order_ID"]);
                    mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["Customer_Address"]);
                    mShippingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Shipping_Date"]);
                    mCustomerNames = Convert.ToString(DB.DataTable.Rows[0]["Customer_Names"]);
                    mTotalCost = Convert.ToDouble(DB.DataTable.Rows[0]["Total_cost"]);
                    mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over_18"]);

                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }

}
}
