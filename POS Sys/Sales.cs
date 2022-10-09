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
using System.Net.Mail;
using System.Net;

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
        int CashierId;
        Cs_Products cs_Products;
        Cs_Category Cs_Category;
        List<Category> CatList;
        string CashierName;
        bool check;
        int index;
        private InvoiceVM InvoiceVM;
        private List<InvoiceVM> Invoices;
        private InvoiceProductVM IP;
        public Sales(string CashierName, int CashierId)
        {
            InitializeComponent();
            Invoice = new Invoice();
            InvoiceProduct = new List<InvoiceProduct>();
            invoiceProduct = new InvoiceProduct();
            CS_Invoice = new CS_Invoice();
            P_List = new List<Products>();
            p_List = new List<Products>();
            p = new Cs_Products();
            Cs_Category = new Cs_Category();
            DisplayProducts();
            sum = 0;
            cs_Products = new Cs_Products();
            CatList = new List<Category>();
            InvoiceVM = new InvoiceVM();
            Invoices = new List<InvoiceVM>();
            IP = new InvoiceProductVM();
            this.CashierId = CashierId;
            this.CashierName = CashierName;

        }
        public void RefreshForm()
        {
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
                dataGridView2.Rows.Add(i + 1, P_List[i].Name, Cs_Category.GetCategory(P_List[i].CategoryId).Name, P_List[i].SellingPrice, P_List[i].ShopQuantity);
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
            CatList = Cs_Category.GetCategoryList();
            for (int i = 0; i < CatList.Count; i++)
                comboBox2.Items.Add(CatList[i].Name);
            comboBox2.SelectedIndex = -1;
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
            LogoutMail();
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void NInvoiceBtn_Click(object sender, EventArgs e)
        {
            Invoice = new Invoice();
            InvoiceProduct = new List<InvoiceProduct>();
            p_List.Clear();
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
            //CalulateDiscount();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String CName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (CName == "AddToCart" && e.RowIndex != -1)
            {
                index = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value) - 1;
                qform = new Qform();
                qform.ShowDialog();
                int qtity = qform.GetQuantity();
                int q = Convert.ToInt32(dataGridView2.Rows[index].Cells[4].Value);
            here: if (qtity > 0)
                {
                    if (q >= qtity)
                    {
                        qform.dispose();
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد كمية كافية");
                        qform.ShowDialog();
                        qtity = qform.GetQuantity();
                        goto here;
                    }

                    if (ItemInCart(index))
                    {
                        MessageBox.Show("المنتج موجود بالعربة مسبقا");
                        return;
                    }
                    dataGridView1.Rows.Add(0, dataGridView2.Rows[index].Cells[1].Value, dataGridView2.Rows[index].Cells[3].Value, qtity, (Convert.ToDouble(qtity) * Convert.ToDouble(dataGridView2.Rows[index].Cells[3].Value)));

                    P_List[index].ShopQuantity -= qtity;
                    p_List.Add(P_List[index]);
                    CalculateTotal();
                    label3.Text = sum.ToString();
                }
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
                    dataGridView1.Rows[rowIndex].Cells[3].Value = Convert.ToInt32(QuantityTxt.Text);
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
            if (comboBox1.SelectedItem.ToString() == "%")
            {
                double discount = sum - ((sum * Convert.ToDouble(textBox1.Text)) / 100);
                label3.Text = discount.ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "$")
            {
                double discount = sum - Convert.ToDouble(textBox1.Text);
                label3.Text = discount.ToString();
            }
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
            check = false;
            CreateInvoice();
            PrintReceipt();
            if (!check)
                UpdateProducts();
        }
        public void PrintReceipt()
        {
            List<InvoiceProductVM> List = new List<InvoiceProductVM>();
            List = IP.SendInvoiceToReport(InvoiceProduct);
            using (PrintReceipt frm = new PrintReceipt(List, Invoice.Total.ToString(), Invoice.Pay.ToString(), (Invoice.Pay - Invoice.Total).ToString(), CS_Invoice.GetLatestInvoiceNumber().ToString(), Invoice.CreatedDate.ToString(), CashierName,Invoice.Discount.ToString(),Invoice.PaymentMethod))
            {
                frm.ShowDialog();
            }
        }
        public void UpdateProducts()
        {
            for (int i = 0; i < p_List.Count; i++)
            {
                cs_Products.AddOrUpdateProduct(p_List[i]);
            }
            NInvoiceBtn.PerformClick();
        }
        public void CreateInvoice()
        {
            PayAndPrint PnP = new PayAndPrint(sum, Convert.ToDouble(label3.Text));
            PnP.ShowDialog();
            if (PnP.paid == 0 || PnP.method == null)
            {
                check = true;
                return;
            }
            if (PnP.paid < PnP.total)
            {
                MessageBox.Show("المبلغ المدفوع أقل من المطلوب");
                PnP.ShowDialog();
            }
            Invoice.Pay = PnP.paid;
            Invoice.Discount = sum - Convert.ToDouble(label3.Text);
            Invoice.PaymentMethod = PnP.method;
            Invoice.Total = PnP.total;
            Invoice.UserId = CashierId;
            PnP.Dispose();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalulateDiscount();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Password pform = new Password();
            pform.ShowDialog();
            bool Authorized = pform.Authorized();
            pform.Dispose();
            if (Authorized)
            {
                ReturningAProduct frm = new ReturningAProduct();
                frm.ShowDialog();
                frm.Dispose();
                RefreshForm();
            }
            else if (!Authorized)
                MessageBox.Show("أنت لا تملك الصلاحية للقيام بهذه العملية");
            else
                return;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetFilterBtn_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                SetAllRowsVisible(dataGridView2, true);
            }
            else
            {
                ApplyGridViewFilters();
            }
        }
        private void ApplyGridViewFilters()
        { 
            FilterGridviewByEmpId(comboBox2.SelectedItem.ToString());
        }

        private void FilterGridviewByEmpId(string category)
        {
            SetAllRowsVisible(dataGridView2, true);
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.Cells[2].Value.Equals(category))
                {
                    row.Visible = false;
                }
            }
        }

        private void SetAllRowsVisible(DataGridView gv, bool visibility)
        {
            foreach (DataGridViewRow row in gv.Rows)
            {
                row.Visible = visibility;
            }
        }

        private void SendReportBtn_Click(object sender, EventArgs e)
        {
            string fromMail = "alhabashy1983@gmail.com";
            MailMessage message = new MailMessage();
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.From = new MailAddress(fromMail);
            message.Subject = "التقرير اليومى";
            message.To.Add(new MailAddress("nour.eldine@hotmail.com"));

            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Invoices = InvoiceVM.GetTotalInvoicesForToday(dt.Date);
            message.Body += "<html dir=\"rtl\" lang=\"ar\"><table width='100%' style='border:Solid 1px Black;'>";
            message.Body += "<tr>";
            message.Body += "<td stlye='color:blue;'>" + "رقم الفاتورة" + "</td>" + "<td stlye='color:blue;'>" + "المبلغ الكلى" + "</td>" + "<td stlye='color:blue;'>" + "المدفوع" + "</td>" + "<td stlye='color:blue;'>" + "الخصم" + "</td>" + "<td stlye='color:blue;'>" + "طريقة الدفع" + "</td>" + "<td stlye='color:blue;'>" + "الكاشير" + "</td>" + "<td stlye='color:blue;'>" + "تاريخ العملية" + "</td>" ;
            message.Body += "</tr>";
            foreach (var item in Invoices)
            {
                message.Body += "<tr>";
                message.Body += "<td stlye='color:blue;'>" + item.Id + "</td>" + "<td stlye='color:blue;'>" + item.Total + "</td>" + "<td stlye='color:blue;'>" + item.Pay + "</td>" + "<td stlye='color:blue;'>" + item.Discount + "</td>" + "<td stlye='color:blue;'>" + item.PaymentMethod + "</td>" + "<td stlye='color:blue;'>" + item.UserName + "</td>" + "<td stlye='color:blue;'>" + item.CreatedDate + "</td>";
                message.Body += "</tr>";
            }
            message.Body += "</table></html>";
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("alhabashy1983@gmail.com", "fwbhjenehgdxshqt"),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }
        public void LogoutMail()
        {
            string fromMail = "alhabashy1983@gmail.com";
            MailMessage message = new MailMessage();
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.From = new MailAddress(fromMail);
            message.Subject = "تسجيل خروج";
            message.To.Add(new MailAddress("nour.eldine@hotmail.com"));

            DateTime dt = new DateTime();
            dt = DateTime.Now;
            message.Body = "<html dir=\"rtl\" lang=\"ar\"><body><p>"+ CashierName +" "+ "قام بتسجيل الخروج. <br>الساعة:"+" "+ dt.ToString("hh:mm tt") +"</P></body></html>";
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("alhabashy1983@gmail.com", "fwbhjenehgdxshqt"),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }

    }
}
