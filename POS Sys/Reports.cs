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
    }
}
