using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys
{
    public class InvoiceDetail
    {
        public int InvoiceId { get; set; }
        public string PName { get; set; }
        public double UPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public double Paid { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime DateTime { get; set; }
    }
}
