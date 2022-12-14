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
    public partial class PayAndPrint : Form
    {
        public double total;
        public double paid;
        public string method;
        public bool checkk;
        public PayAndPrint(double sum,double total)
        {
            InitializeComponent();
            this.total = total;
            this.ActiveControl = button1;
            this.radioButton1.Checked = true;
            checkk = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void PayAndPrint_Load(object sender, EventArgs e)
        {
            textBox1.Text = total.ToString();
            textBox2.Text = total.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paid = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                method = "Cash";
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                method = "Visa";
                this.Hide();
            }
            else
                MessageBox.Show("برجاء اختيار طريقة الدفع");

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void PayAndPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void PayAndPrint_FormClosed(object sender, FormClosedEventArgs e)
        {
            checkk = true;
            this.Dispose();
        }
    }
}
