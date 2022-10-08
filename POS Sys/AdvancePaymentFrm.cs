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
        private UserCrudOps us;
        private List<Users> users;
        private List<AdvancePayment> PaymentsList;
        private AdvancePayment advp;
        private int rowIndex;
        public AdvancePaymentFrm()
        {
            InitializeComponent();
            us = new UserCrudOps();
            users = new List<Users>();
            PaymentsList = new List<AdvancePayment>();
            
        }

        private void AdvancePaymentFrm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            users = us.ReadAllUsers();

            table.Columns.Add("الاسم", typeof(string));
            table.Columns.Add("اسم المستخدم", typeof(string));

            for (int i = 0; i < users.Count(); i++)
            {
                table.Rows.Add(users[i].Name, users[i].UserName);
            }
            UsersDgv.DataSource = table;
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
            users = us.ReadAllUsers();

            table.Columns.Add("الاسم", typeof(string));
            table.Columns.Add("المبلغ المسحوب", typeof(string));

            foreach (AdvancePayment item in PaymentsList)
            {
                us.ReadUser(item.UserId);
                table.Rows.Add(us.getName(), item.Amount);
            }
            APDgv.DataSource = table;
        }

        private void UsersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name.Text = users[e.RowIndex].Name;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            advp = new AdvancePayment();
            us.ReadUserT(txt_Name.Text);
            advp.UserId = us.Id;
            advp.Amount = Convert.ToDouble(metroTextBox1.Text);
            using(DatabaseContext db=new DatabaseContext())
            {
                if (!db.AdvancePayment.Any(x=>x.UserId==us.Id) )
                {
                    db.AdvancePayment.Add(advp);
                    db.SaveChanges();
                }
            }
            DisplayAdvPayments();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            advp = new AdvancePayment();
            us.ReadUserT(APDgv.Rows[rowIndex].Cells[0].Value.ToString());
            using (DatabaseContext db = new DatabaseContext())
            {
                if (db.AdvancePayment.Where(x => x.UserId == us.Id).Count() > 0)
                {
                    var ro = from U in db.AdvancePayment
                             where U.UserId == us.Id
                             select new
                             {
                                 n = U.Id,
                                 i = U.UserId,
                                 r = U.Amount
                             };
                    foreach (var obj in ro)
                    {
                        advp.Id = obj.n;
                        advp.UserId = obj.i;
                        advp.Amount = obj.r;
                    }
                    db.AdvancePayment.Attach(advp);
                    db.AdvancePayment.Remove(advp);
                    db.SaveChanges();
                    DisplayAdvPayments();
                    MessageBox.Show("تمت الازالة بنجاح");

                } 
            }
        }

        private void APDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
