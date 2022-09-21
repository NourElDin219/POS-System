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
        Invoice Invoice;
        InvoiceProduct InvoiceProduct;
        CS_Invoice CS_Invoice;
        private List<Products> P_List;
        private Cs_Products p;
        Qform qform;
        double sum;
        public Sales()
        {
            InitializeComponent();
            Invoice = new Invoice();
            InvoiceProduct = new InvoiceProduct();
            CS_Invoice = new CS_Invoice();
            P_List = new List<Products>();
            p = new Cs_Products();
            DisplayProducts();
            sum = 0;
        }
        private void DisplayProducts()
        {
            dataGridView2.Rows.Clear();
            P_List = p.GetProducts();
            for (int i = 0; i < P_List.Count(); i++)
            {
                dataGridView2.Rows.Add(i + 1, P_List[i].Name, P_List[i].SellingPrice, P_List[i].ShopQuantity);
            }
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
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = SearchTxt.Text;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SearchTxt_MouseClick(object sender, MouseEventArgs e)
        {
            SearchTxt.Clear();
        }

        private void LogoutBtn_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void NInvoiceBtn_Click(object sender, EventArgs e)
        {
            Invoice = new Invoice();
            InvoiceProduct = new InvoiceProduct();
            DisplayProducts();
            sum = 0;
            label3.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String CName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (CName == "AddToCart")
            {
                qform = new Qform();
                qform.ShowDialog();
                int qtity = qform.GetQuantity();
                int q = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
                if (q >= qtity)
                {
                    qform.dispose();
                }
                else
                {
                    MessageBox.Show("لا يوجد كمية كافية");
                    qform.ShowDialog();
                    qtity = qform.GetQuantity();
                }
                dataGridView1.Rows.Add(0,dataGridView2.Rows[e.RowIndex].Cells[1].Value, dataGridView2.Rows[e.RowIndex].Cells[2].Value, qtity, (qtity * Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value)));
                sum += qtity * Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
                label3.Text = sum.ToString();
            }
        }


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            UnitPText.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            QuantityTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TotalPText.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            String CName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (CName == "Remove")
            {
                sum -= Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                label3.Text = sum.ToString();
            }
            
        }

        private void DiscountBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
