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
            YearCombobox.DataSource= Enumerable.Range(2022, DateTime.UtcNow.Year - 2019).ToList();
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
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            if (YearCombobox.SelectedIndex > -1 && MonthsCombobox.SelectedIndex > -1)
            {
                YearlyProfit2.Text = Cs_Invoice.GetTotalInvoiceSumForThisYear(Convert.ToInt32(YearCombobox.SelectedItem)).ToString();
                MonthlyProfit2.Text = Cs_Invoice.GetTotalInvoiceSumForThisMonth(Convert.ToInt32(MonthsCombobox.SelectedItem), Convert.ToInt32(YearCombobox.SelectedItem)).ToString();
            }
            else
            {
                MessageBox.Show("برجاء اختيار الشهر والسنة");
            }
        }
    }
}
