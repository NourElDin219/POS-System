using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Sys.CS;
using POS_Sys.Models;

namespace POS_Sys
{
    public partial class Reports : Form
    {
        private InvoiceVM InvoiceVM;
        private List<InvoiceVM> InvoiceList;
        public Reports()
        {
            InitializeComponent();
            InvoiceVM = new InvoiceVM();
            InvoiceList = new List<InvoiceVM>();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            InvoiceList = InvoiceVM.Getinvoices();
            InvoiceDGV.DataSource = InvoiceList;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (InvoiceVM.GetInvoice(Convert.ToInt32(textBox1.Text)) == null)
                {
                    MessageBox.Show("لا يوجد فواتير بهذا الرقم");
                    return;
                }
                InvoiceList.Clear();
                InvoiceList.Add(InvoiceVM.GetInvoice(Convert.ToInt32(textBox1.Text)));
                InvoiceDGV.DataSource = null;
                InvoiceDGV.Columns.Clear();
                InvoiceDGV.Rows.Clear();
                InvoiceDGV.DataSource = InvoiceList;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DisplayDayBtn_Click(object sender, EventArgs e)
        {
            if (InvoiceVM.GetTotalInvoicesForToday(dateTimePicker1.Value) == null)
            {
                MessageBox.Show("لا يوجد فواتير بهذا اليوم");
                return;
            }
            InvoiceList.Clear();
            InvoiceList = InvoiceVM.GetTotalInvoicesForToday(dateTimePicker1.Value.Date);
            InvoiceDGV.DataSource = null;
            InvoiceDGV.Columns.Clear();
            InvoiceDGV.Rows.Clear();
            InvoiceDGV.DataSource = InvoiceList;
        }

        private void InvoiceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvoiceDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = Convert.ToInt32(InvoiceDGV.Rows[e.RowIndex].Cells[0].Value);
            using (DatabaseContext db = new DatabaseContext())
            {
                if (db.InvoiceProduct.Where(x => x.InvoiceId == k).Count() > 0)
                {
                    var ro = from IP in db.InvoiceProduct
                             from P in db.Product
                             where IP.InvoiceId == k && P.Id == IP.ProductId
                             select new
                             {
                                 ProductName = P.Name,
                                 UnitPrice = P.SellingPrice,
                                 Quantity = IP.Quantity,
                                 ProductId = P.Id,

                                 SPrice = P.SellingPrice,
                                 CatId = P.CategoryId,
                                 ShopQty = P.ShopQuantity,
                                 InvQty = P.InvQuantity,
                                 InvoiceProductID = IP.Id
                             };
                    InvoiceDGV.DataSource = null;
                    InvoiceDGV.Rows.Clear();
                    InvoiceDGV.Columns.Add("Name","اسم المنتج");
                    InvoiceDGV.Columns.Add("UnitPrice", "سعر القطعة");
                    InvoiceDGV.Columns.Add("Qty", "الكمية");
                    InvoiceDGV.Columns.Add("TotalPrice", "السعر الكلى");

                    foreach (var obj in ro)
                    {
                       InvoiceDGV.Rows.Add(obj.ProductName, obj.UnitPrice, obj.Quantity, Convert.ToDouble((obj.UnitPrice) * (obj.Quantity)));
                    }
                }
            }
        }
    }
}
