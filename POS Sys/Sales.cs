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
        List<InvoiceProduct> InvoiceProduct;
        InvoiceProduct invoiceProduct;
        CS_Invoice CS_Invoice;
        private List<Products> P_List;
        private List<Products> p_List;
        private Cs_Products p;
        Qform qform;
        double sum;
        int rowIndex;
        Cs_Products cs_Products; 
        public Sales()
        {
            InitializeComponent();
            Invoice = new Invoice();
            InvoiceProduct = new List<InvoiceProduct>();
            invoiceProduct = new InvoiceProduct();
            CS_Invoice = new CS_Invoice();
            P_List = new List<Products>();
            p_List = new List<Products>();
            p = new Cs_Products();
            DisplayProducts();
            sum = 0;
            cs_Products = new Cs_Products();
           
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
            InvoiceProduct = new List<InvoiceProduct>();
            DisplayProducts();
            label3.Text = "";
            dataGridView1.Rows.Clear();
            textBox1.Clear();
        }
        public void CalculateTotal()
        {
            sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sum += Convert.ToDouble(row.Cells[4].Value);
            }
            CalulateDiscount();
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

                if (ItemInCart(e.RowIndex))
                {
                    MessageBox.Show("المنتج موجود بالعربة مسبقا");
                    return;
                }
                dataGridView1.Rows.Add(0,dataGridView2.Rows[e.RowIndex].Cells[1].Value, dataGridView2.Rows[e.RowIndex].Cells[2].Value, qtity, (Convert.ToDouble(qtity) * Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[2].Value)));
                
                P_List[e.RowIndex].ShopQuantity -= qtity; 
                p_List.Add(P_List[e.RowIndex]);
                CalculateTotal();
                label3.Text = sum.ToString();
            }
        }

        public bool ItemInCart(int ind)
        {
            if (p_List.Contains(P_List[ind]))
            {
                return true;
            }
        
            return false;
          
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            PNameTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            UnitPText.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            QuantityTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TotalPText.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            String CName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (CName == "Remove")
            {
                p_List.RemoveAt(e.RowIndex);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                CalculateTotal();
                label3.Text = sum.ToString();
            }
            
        }

        private void DiscountBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void QuantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void QuantityTxt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(QuantityTxt.Text) <= (Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[3].Value) + p_List[rowIndex].ShopQuantity))
                {
                    p_List[rowIndex].ShopQuantity += (Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[3].Value)) - Convert.ToInt32(QuantityTxt.Text);
                    dataGridView1.Rows[rowIndex].Cells[3].Value =  Convert.ToInt32(QuantityTxt.Text);
                    dataGridView1.Rows[rowIndex].Cells[4].Value = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[2].Value);
                    MessageBox.Show("تم تعديل الكمية بنجاح");
                }
                else
                {
                    MessageBox.Show("لا يوجد كمية كافية");
                    QuantityTxt.Focus();
                }
            }
        }

        private void QuantityTxt_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void QuantityTxt_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(QuantityTxt.Text) <= (Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[3].Value) + p_List[rowIndex].ShopQuantity))
            {
                p_List[rowIndex].ShopQuantity += (Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[3].Value)) - Convert.ToInt32(QuantityTxt.Text);
                dataGridView1.Rows[rowIndex].Cells[3].Value = Convert.ToInt32(QuantityTxt.Text);
                dataGridView1.Rows[rowIndex].Cells[4].Value = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells[2].Value);
                sum = 0;
                CalculateTotal();
                label3.Text = sum.ToString();
                MessageBox.Show("تم تعديل الكمية بنجاح");
            }
            else
            {
                MessageBox.Show("لا يوجد كمية كافية");
                QuantityTxt.Focus();
            }
        }
        public void CalulateDiscount()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            double discount = sum - ((sum * Convert.ToDouble(textBox1.Text)) / 100);
            label3.Text = discount.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                int i;
                if (int.TryParse(textBox1.Text, out i))
                {
                    if (i >= 0 && i <= 100)
                    {
                        CalculateTotal();
                        return;
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PayAndPrintBtn_Click(object sender, EventArgs e)
        {
            CreateInvoice();
            UpdateProducts();
        }
        public void UpdateProducts()
        {
            for (int i = 0; i < p_List.Count; i++)
            {
                cs_Products.AddOrUpdateProduct(p_List[i]);
            }
        }
        public void CreateInvoice()
        {
            Invoice.Discount = Convert.ToInt32(textBox1.Text);
            Invoice.PaymentMethod = "Cash";
            Invoice.Pay = 14.5;
            Invoice.UserId = 1008;
            Invoice.Total = sum;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                invoiceProduct = new InvoiceProduct();
                invoiceProduct.ProductId = p_List[i].Id;
                invoiceProduct.Quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                InvoiceProduct.Add(invoiceProduct);
                invoiceProduct = null;
                GC.Collect();
            }
            CS_Invoice.CreateInvoice(Invoice, InvoiceProduct);
        }

        private void SearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
