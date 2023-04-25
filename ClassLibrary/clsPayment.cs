using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        public int cardNumber;
        public int cvv;
        public int customerName;

        public bool Active { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime DateAdded { get; set; }
        public String BillingAddress { get; set; }
        public string FullName { get; set; }
    }
}