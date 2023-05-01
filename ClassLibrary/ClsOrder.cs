using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public DateTime DateOrdered { get; set; }
        public string CustomerAddress { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public Boolean Paid { get; set; }
    }
}