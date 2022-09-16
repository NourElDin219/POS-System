using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.Models
{
    public class InvoiceProduct
    {
        public int Id { get; set; }
        // forieng key
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        // forieng key
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
    }
}
