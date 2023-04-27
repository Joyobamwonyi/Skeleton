using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        //Private data me
        private Int32 mPymNo;
        public int mCardNumber;
        private int mcvv;
        public string mNameOnCard;
        private DateTime mExparationDate;
        private bool mActive;
        private string mPostalCode;

     
        public Int32 PymNo
        {
            get
            {
                return mPymNo;

            }
            set
            {
                mPymNo = value;
            }
        }
        public DateTime ExparationDate
        {
            get
            {
                return mExparationDate;
            }
            set
            {
                mExparationDate = value;
            }

        }
        public Int32 cvv
        {
            get
            {
                return mcvv;

            }
            set
            {
                mcvv = value;
            }
        }
        public string NameOnCard
        {
            get
            {
                return mNameOnCard;

            }
            set
            {
                mNameOnCard = value;
            }
        }
        public int CardNumber
        {
            get
            {
                return mCardNumber;

            }
            set
            {
                mCardNumber = value;
            }
        }
        public bool Active
        {
            get
            {
                return mActive;

            }
            set
            {
                mActive = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return mPostalCode;

            }
            set
            {
                mPostalCode = value;
            }
        }




        public bool Find(int PymNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PymNo", PymNo);
            DB.Execute("sproc_tblPayment_FilterByPymNo");
            if (DB.Count == 1)
            {
                mPymNo = Convert.ToInt32(DB.DataTable.Rows[0]["PymNo"]);
                mNameOnCard = Convert.ToString(DB.DataTable.Rows[0]["NameOnCard"]);
                mCardNumber = Convert.ToInt32(DB.DataTable.Rows[0]["cardNumber"]);
                mExparationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExparationDate"]);
                mcvv = Convert.ToInt32(DB.DataTable.Rows[0]["cvv"]);
                mPostalCode = Convert.ToString(DB.DataTable.Rows[0]["PostalCode"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Save"]);
                return true;

            }
            else
            {
                return false;
            }
        }
          public string Valid(string exparationDate, string postalCode, string cardNumber, string cvv)
        {
            return "";
        }
    }
    }

       