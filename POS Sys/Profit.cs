using POS_Sys.CS;
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
    public partial class Profit : Form
    {
        CS_Invoice Cs_Invoice;
        public Profit()
        {
            InitializeComponent();
            Cs_Invoice = new CS_Invoice();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Profit_Load(object sender, EventArgs e)    
        {
            DailyProfit.Text = Cs_Invoice.GetTotalInvoiceSumForToday().ToString();
            MonthlyProfit.Text = Cs_Invoice.GetTotalInvoiceSumForThisMonth().ToString();
            YearlyProfit.Text = Cs_Invoice.GetTotalInvoiceSumForThisYear().ToString();
            DailyTotal.Text = Cs_Invoice.GetTotalInvoiceTotalForToday().ToString();
            MonthlyTotal.Text = Cs_Invoice.GetTotalInvoiceTotalForThisMonth().ToString();
            YearlyTotal.Text = Cs_Invoice.GetTotalInvoiceTotalForThisYear().ToString();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            YearlyProfit2.Text = Cs_Invoice.GetTotalInvoiceSumForThisYear(dateTimePicker1.Value).ToString();
            MonthlyProfit2.Text = Cs_Invoice.GetTotalInvoiceSumForThisMonth(dateTimePicker1.Value).ToString();
            label2.Text = Cs_Invoice.GetTotalInvoiceSumForToday(dateTimePicker1.Value).ToString();
            TotalYearly.Text = Cs_Invoice.GetTotalInvoiceTotalForThisYear(dateTimePicker1.Value).ToString();
            TotalMonthly.Text = Cs_Invoice.GetTotalInvoiceTotalForThisMonth(dateTimePicker1.Value).ToString();
            TotalDaily.Text = Cs_Invoice.GetTotalInvoiceTotalForToday(dateTimePicker1.Value).ToString();
            label1.Text = dateTimePicker1.Value.Day.ToString();
            label7.Text = dateTimePicker1.Value.Month.ToString();
            label8.Text = dateTimePicker1.Value.Year.ToString();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
