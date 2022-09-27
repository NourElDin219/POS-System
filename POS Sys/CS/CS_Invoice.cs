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
            db.Invoice.Add(invoice);
            db.SaveChanges();
            int id= GetLatestInvoiceNumber();
            for (int i = 0; i < products.Count; i++)
            {
                products[i].InvoiceId = id;
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
        public void EditInvoiceProduct(int IPID)
        {
            var IP = db.InvoiceProduct.Find(IPID);
            db.InvoiceProduct.Remove(IP);
            db.SaveChanges();
        }
        public void UpdateInvoice(int Id,double total)
        {
            Invoice inv = new Invoice();
            inv = db.Invoice.Find(Id);
            inv.Pay = total;
            inv.Total = total;
            db.Invoice.AddOrUpdate(inv);
            db.SaveChanges();
        }
        public void RemoveInvoice(int Id)
        {
            Invoice inv = new Invoice();
            inv = db.Invoice.Find(Id);
            db.Invoice.Remove(inv);
            db.SaveChanges();
        }
        public double GetTotalInvoiceSumForToday()
        {

            var Result = db.Invoice.Where(x => x.CreatedDate >= DateTime.Today).Sum(x => (double?)x.Total)??0;
            
            
            return Result;
        }

        public double GetTotalInvoiceSumForThisMonth()
        {
            DateTime d = DateTime.Now;
            var MonthDate = new DateTime(d.Year, d.Month, 1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= MonthDate).Sum(x => (double?)x.Total)??0;
            return Result;
        }
        public double GetTotalInvoiceSumForThisYear()
        {
            DateTime d = DateTime.Now;
            var YearDate = new DateTime(d.Year, 1, 1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= YearDate).Sum(x => (double?)x.Total)??0;
            return Result;
        }
        //Shoof dh 
        public double GetTotalInvoiceSumForThisMonth(int m,int y)
        {
            //DateTime d = DateTime.Now;
            var MonthDate = new DateTime(y, m, 1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= MonthDate).Sum(x => (double?)x.Total)??0;
            return Result;
        }
        public double GetTotalInvoiceSumForThisYear(int y)
        {
            //DateTime d = DateTime.Now;
            var YearDate = new DateTime(y, 1, 1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= YearDate).Sum(x => (double?)x.Total)??0;
            return Result;
        }
    }
}
