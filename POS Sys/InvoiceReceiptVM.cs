using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys
{
    public class InvoiceReceiptVM
    {
        [DisplayName("رقم الفاتورة")]
        public int Id { get; set; }
        [DisplayName("المبلغ الكلى")]
        public double Total { get; set; }
        [DisplayName("المدفوع")]
        public double Pay { get; set; }
        [DisplayName("الخصم")]
        public double Discount { get; set; }
        [DisplayName("طريقة الدفع")]
        public string PaymentMethod { get; set; }
        [DisplayName("الكاشير")]
        public string UserName { get; set; }

        public List<InvoiceProductVM> InvoiceProducts { get; set; }
        [DisplayName("تاريخ العملية")]
        public DateTime CreatedDate { get; set; }

    }
}
