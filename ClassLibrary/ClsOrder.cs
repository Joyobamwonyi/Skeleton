using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrder

    {

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string ShippingAddress { get; set; }
        public int OrderDate { get; set; }
        public Object totalCost { get; set; }
        public string PaymentMethod { get; set; }

    }
}
