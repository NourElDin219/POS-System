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
        public void UpdateInvoice(int Id,double total,double totalProfit)
        {
            Invoice inv = new Invoice();
            inv = db.Invoice.Find(Id);
            inv.Pay = total;
            inv.Total = total;
            inv.TotalProfit = totalProfit;
            db.Invoice.AddOrUpdate(inv);
            db.SaveChanges();
        }
        public void UpdateInvoiceProducts(int Id,int PID,int Qty)
        {
            List<InvoiceProduct> invoiceProducts =new List<InvoiceProduct>();
            invoiceProducts = db.InvoiceProduct.Where(x => x.InvoiceId == Id &&x.ProductId==PID).ToList();
            invoiceProducts[0].Quantity = Qty;
            db.InvoiceProduct.AddOrUpdate(invoiceProducts[0]);
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

            var Result = db.Invoice.Where(x => x.CreatedDate >= DateTime.Today).Sum(x => (double?)x.TotalProfit)??0;
            var AP= db.AdvancePayment.Where(x => x.CreatedDate >= DateTime.Today).Sum(x=>(double?)x.Amount)??0;
            Result -= AP;
            
            return Result;
        }
        public double GetTotalInvoiceTotalForToday()
        {

            var Result = db.Invoice.Where(x => x.CreatedDate >= DateTime.Today).Sum(x => (double?)x.Total) ?? 0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >= DateTime.Today).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;

            return Result;
        }
        //public double GetTotalInvoiceSumForThisMonth()
        //{
        //    DateTime d = DateTime.Now;
        //    var MonthDate = new DateTime(d.Year, d.Month, 1);
        //    var Result = db.Invoice.Where(x => x.CreatedDate >= MonthDate).Sum(x => (double?)x.Total) ?? 0;
        //    return Result;
        //}
        public double GetTotalInvoiceSumForThisMonth()
        {
            DateTime d = DateTime.Now;
            var MonthDate = new DateTime(d.Year, d.Month, 1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= MonthDate).Sum(x => (double?)x.TotalProfit)??0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >= MonthDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        public double GetTotalInvoiceTotalForThisMonth()
        {
            DateTime d = DateTime.Now;
            var MonthDate = new DateTime(d.Year, d.Month, 1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= MonthDate).Sum(x => (double?)x.Total) ?? 0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >= MonthDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        //public double GetTotalInvoiceSumForThisYear()
        //{
        //    DateTime d = DateTime.Now;
        //    var YearDate = new DateTime(d.Year, 1, 1);
        //    var Result = db.Invoice.Where(x => x.CreatedDate >= YearDate).Sum(x => (double?)x.Total) ?? 0;
        //    return Result;
        //}
        public double GetTotalInvoiceSumForThisYear()
        {
            DateTime d = DateTime.Now;
            var YearDate = new DateTime(d.Year, 1, 1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= YearDate).Sum(x => (double?)x.TotalProfit)??0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >= YearDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        public double GetTotalInvoiceTotalForThisYear()
        {
            DateTime d = DateTime.Now;
            var YearDate = new DateTime(d.Year, 1, 1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= YearDate).Sum(x => (double?)x.Total) ?? 0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >= YearDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        //public double GetTotalInvoiceSumForThisMonth(DateTime dt)
        //{
        //    dt = new DateTime(dt.Year, dt.Month, 1);
        //    var MonthDate = dt.AddMonths(1);
        //    var Result = db.Invoice.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Total) ?? 0;
        //    return Result;
        //}
        public double GetTotalInvoiceSumForThisMonth(DateTime dt)
        {
            dt = dt.Date;
            dt =new DateTime(dt.Year, dt.Month, 1);
            var MonthDate = dt.AddMonths(1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= dt&&x.CreatedDate<MonthDate).Sum(x => (double?)x.TotalProfit)??0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >=dt&& x.CreatedDate<MonthDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        public double GetTotalInvoiceTotalForThisMonth(DateTime dt)
        {
            dt = dt.Date;
            dt = new DateTime(dt.Year, dt.Month, 1);
            var MonthDate = dt.AddMonths(1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Total) ?? 0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        //public double GetTotalInvoiceSumForThisYear(DateTime dt)
        //{
        //    dt = new DateTime(dt.Year, 1, 1);
        //    var MonthDate = dt.AddYears(1);
        //    var Result = db.Invoice.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Total) ?? 0;
        //    return Result;
        //}
        public double GetTotalInvoiceSumForThisYear(DateTime dt)
        {
            dt = dt.Date;
            dt = new DateTime(dt.Year, 1, 1);
            var MonthDate = dt.AddYears(1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= dt && x.CreatedDate<MonthDate).Sum(x => (double?)x.TotalProfit)??0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >=dt&&x.CreatedDate< MonthDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        public double GetTotalInvoiceTotalForThisYear(DateTime dt)
        {
            dt = dt.Date;
            dt = new DateTime(dt.Year, 1, 1);
            var MonthDate = dt.AddYears(1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Total) ?? 0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        //public double GetTotalInvoiceSumForToday(DateTime dt)
        //{
        //    var MonthDate = dt.AddDays(1);
        //    var Result = db.Invoice.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Total) ?? 0;
        //    return Result;
        //}
        public double GetTotalInvoiceSumForToday(DateTime dt)
        {
            dt = dt.Date;
            var MonthDate = dt.AddDays(1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= dt&&x.CreatedDate<MonthDate).Sum(x => (double?)x.TotalProfit) ?? 0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >=dt&&x.CreatedDate<MonthDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }
        public double GetTotalInvoiceTotalForToday(DateTime dt)
        {
            dt = dt.Date;
            var MonthDate = dt.AddDays(1);
            var Result = db.Invoice.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Total) ?? 0;
            var AP = db.AdvancePayment.Where(x => x.CreatedDate >= dt && x.CreatedDate < MonthDate).Sum(x => (double?)x.Amount) ?? 0;
            Result -= AP;
            return Result;
        }


    }
}
