using POS_Sys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.CS
{
    public class InvoiceVM
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
        [DisplayName("تاريخ العملية")]
        public DateTime CreatedDate { get; set; }
        public InvoiceVM()
        {
        }
        public List<InvoiceVM> Getinvoices()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var invoices = db.Invoice.OrderByDescending(b => b.Id).Take(20).ToList();
                List<InvoiceVM> invoicesVM = new List<InvoiceVM>();

                foreach (var invoice in invoices)
                {
                    InvoiceVM invoices1 = new InvoiceVM();

                    invoices1.PaymentMethod = invoice.PaymentMethod;
                    invoices1.CreatedDate = invoice.CreatedDate;
                    invoices1.Discount = invoice.Discount;
                    invoices1.Id = invoice.Id;
                    invoices1.Pay = invoice.Pay;
                    invoices1.Total = invoice.Total;
                    invoices1.UserName = db.User.Find(invoice.UserId).Name;
                    invoicesVM.Add(invoices1);

                }
                return invoicesVM;
            }
        }
        public InvoiceVM GetInvoice(int invoiceId)
        {
            using(DatabaseContext db = new DatabaseContext())
            {
                var invoice = db.Invoice.Find(invoiceId);
                InvoiceVM invoices1 = new InvoiceVM();
                if (invoice == null)
                {
                    invoices1 = null;
                    return invoices1;
                }
                invoices1.PaymentMethod = invoice.PaymentMethod;
                invoices1.CreatedDate = invoice.CreatedDate;
                invoices1.Discount = invoice.Discount;
                invoices1.Id = invoice.Id;
                invoices1.Pay = invoice.Pay;
                invoices1.Total = invoice.Total;
                invoices1.UserName = db.User.Find(invoice.UserId).Name;
                return invoices1;
            }
        }
    }
}
