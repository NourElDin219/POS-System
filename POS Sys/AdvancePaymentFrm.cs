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
    public partial class AdvancePaymentFrm : Form
    {

        private List<AdvancePayment> PaymentsList;
        private AdvancePayment advp;
        private int rowIndex;
        public AdvancePaymentFrm()
        {
            InitializeComponent();
            PaymentsList = new List<AdvancePayment>();
            
        }

        private void AdvancePaymentFrm_Load(object sender, EventArgs e)
        {
            DisplayAdvPayments();
        }
        public void DisplayAdvPayments()
        {
            using(DatabaseContext db=new DatabaseContext())
            {
                var List = db.AdvancePayment.ToList();
                PaymentsList.Clear();
                PaymentsList = List;
            }
            DataTable table = new DataTable();

            table.Columns.Add("الاسم", typeof(string));
            table.Columns.Add("المبلغ", typeof(double));
            table.Columns.Add("السبب", typeof(string));
            table.Columns.Add("التاريخ و الوقت", typeof(string));
            foreach (AdvancePayment item in PaymentsList)
            {
                table.Rows.Add(item.UserName, item.Amount,item.Description,item.CreatedDate);
            }
            UsersDgv.DataSource = table;
        }

        private void UsersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void APDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (text_Name.Text == "" || text_Amount.Text == "" || text_Reason.Text == "")
            {
                MessageBox.Show("برجاء ملئ جميع الخانات");
            }
            else
            {
                advp = new AdvancePayment();
                advp.UserName = text_Name.Text;
                advp.Amount = Convert.ToDouble(text_Amount.Text);
                advp.Description = text_Reason.Text;
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.AdvancePayment.Add(advp);
                    db.SaveChanges();
                }
                advp = null;
                DisplayAdvPayments();
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.AdvancePayment.Attach(PaymentsList[rowIndex]);
                db.AdvancePayment.Remove(PaymentsList[rowIndex]);
                db.SaveChanges();
            }
            DisplayAdvPayments();

        }

        private void text_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
