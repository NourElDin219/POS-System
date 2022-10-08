using POS_Sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys
{
    public class InvoiceProductVM
    {

        public string ProductName { get; set; }

        public int Quantity { get; set; }
        public List<InvoiceProductVM> SendInvoiceToReport(List<InvoiceProduct> invoicesProduct)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<InvoiceProductVM> invoicesVM = new List<InvoiceProductVM>();
                InvoiceProductVM invoices1 = new InvoiceProductVM();
                foreach (var invoice in invoicesProduct)
                {
                    invoices1.ProductName = db.Product.Find(invoice.ProductId).Name;
                    invoices1.Quantity = invoice.Quantity;
                    invoicesVM.Add(invoices1);
                }
                return invoicesVM;
            }
        }
    }
    
}
