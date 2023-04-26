using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        public int cardNumber;
        public int cvv;
        public int customerName;

        public bool Active { get; set; }
        public DateTime ExparationDate { get; set; }
        public string NameOnCard { get; set; }
        public int CardNumber { get; set; }
        public int Cvv { get; set; }
        public string PostalCode { get; set; }
    }
}