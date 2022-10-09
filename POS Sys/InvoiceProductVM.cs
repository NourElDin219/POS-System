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
        public double Price { get; set; }
        public List<InvoiceProductVM> SendInvoiceToReport(List<InvoiceProduct> invoicesProduct)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<InvoiceProductVM> invoicesVM = new List<InvoiceProductVM>();
                
                foreach (var invoice in invoicesProduct)
                {
                    InvoiceProductVM invoices1 = new InvoiceProductVM();
                    invoices1.ProductName = db.Product.Find(invoice.ProductId).Name;
                    invoices1.Quantity = invoice.Quantity;
                    invoices1.Price = db.Product.Find(invoice.ProductId).SellingPrice;
                    invoicesVM.Add(invoices1);
                }
                return invoicesVM;
            }
        }
    }
    
}
