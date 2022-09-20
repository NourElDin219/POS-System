using POS_Sys.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.CS
{
    public class CS_Invoice
    {
        public DatabaseContext db;
        public CS_Invoice()

        {
            db = new DatabaseContext();
        }
        public Invoice GetInvoice(int invoiceId)
        {
            var invoice = db.Invoice.Find(invoiceId);
            return invoice;
        }
        public void CreateInvoice(Invoice invoice, List<InvoiceProduct> products)
        {
            db.Invoice.AddOrUpdate(invoice);
            for (int i = 0; i < products.Count; i++)
            {
                products[i].InvoiceId = invoice.Id;
            }
            db.InvoiceProduct.AddRange(products);

            db.SaveChanges();

        }
        public int GetLatestInvoiceNumber()
        {
            int max = db.Invoice.Select(p => p.Id)
                             .DefaultIfEmpty(0)
                             .Max();
            return max;
        }

        public void Deleteinvoice(int invoiceId)
        {
            var d = db.InvoiceProduct.Where(x => x.InvoiceId == invoiceId).ToList();
            db.InvoiceProduct.RemoveRange(d);
            var invoice = db.Invoice.Find(invoiceId);
            db.Invoice.Remove(invoice);

            db.SaveChanges();
        }
        public List<Invoice> Getinvoices(int PageIndex)
        {
            var invoices = db.Invoice.OrderBy(b => b.Id).Skip(PageIndex * 10).Take(10).ToList();
            return invoices;
        }
    }
}
