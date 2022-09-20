using POS_Sys.CS;
using POS_Sys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Sys
{
    public partial class Sales : Form
    {
        ViewProducts frm;
        Invoice Invoice;
        InvoiceProduct InvoiceProduct;
        CS_Invoice CS_Invoice;
        public Sales()
        {
            InitializeComponent();
            frm = new ViewProducts();
            Invoice = new Invoice();
            InvoiceProduct = new InvoiceProduct();
            CS_Invoice = new CS_Invoice();
            TransactionL.Text = (CS_Invoice.GetLatestInvoiceNumber() + 1).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateL.Text = DateTime.Now.ToShortDateString();
            TimeL.Text = DateTime.Now.ToShortTimeString();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            frm.BringToFront();
            frm.ShowDialog();

        }

        private void NTransaction_Click(object sender, EventArgs e)
        {
            Invoice = new Invoice();
            InvoiceProduct = new InvoiceProduct();
            TransactionL.Text = (CS_Invoice.GetLatestInvoiceNumber() + 1).ToString();
        }
    }
}
