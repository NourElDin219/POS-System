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
    public partial class ProductsForm : Form
    {
        private Products Product;
        private Cs_Products p;
        private Cs_Category cs_Category;
        private List<Products> P_List;
        private int rowIndex;
        DataTable table;
        public ProductsForm()
        {
            InitializeComponent();
            p = new Cs_Products();
            cs_Category = new Cs_Category();
            P_List = new List<Products>();
            Product = new Products();
            table = new DataTable();
            
            FillCategoryList();
            
        }
        private void Clear()
        {
            TxtName.Clear();
            TxtSPrice.Clear();
            TxtSQuantity.Clear();
            TxtIQuantity.Clear();
            ComboCat.Text = "";
        }
        public void FillCategoryList()
        {
            ComboCat.DisplayMember = "Name";
            ComboCat.ValueMember = "Id";
            ComboCat.DataSource = cs_Category.GetCategoryList();
            if(ComboCat.Items.Count>0)
            ComboCat.SelectedIndex = 0;
        }
        public void FillCategoryList2()
        {
            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "Id";
            metroComboBox1.DataSource = cs_Category.GetCategoryList();
            if (metroComboBox1.Items.Count > 0)
                metroComboBox1.SelectedIndex = 0;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (p.Exists(TxtName.Text))
            {
                MessageBox.Show("المنتج موجود مسبقا");
                Clear();
            }
            else
            {
                Product.Name = TxtName.Text;
                Product.SellingPrice = Convert.ToDouble(TxtSPrice.Text);
                Product.ShopQuantity = Convert.ToInt32(TxtSQuantity.Text);
                Product.InvQuantity = Convert.ToInt32(TxtIQuantity.Text);
                Product.CategoryId = cs_Category.GetCategory(ComboCat.Text).Id;
                p.AddOrUpdateProduct(Product);
                MessageBox.Show("تمت اضافة المنتج بنجاح");
                Clear();
            }
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            table.Columns.Clear();
            table.Rows.Clear();
            P_List = p.GetProducts();
            table.Columns.Add("اسم المنتج", typeof(string));
            table.Columns.Add("سعر البيع", typeof(double));
            table.Columns.Add("الكمية فى المتجر", typeof(int));
            table.Columns.Add("الكمية فى المخزن", typeof(int));

            for (int i = 0; i < P_List.Count(); i++)
            {
                table.Rows.Add(P_List[i].Name, P_List[i].SellingPrice, P_List[i].ShopQuantity, P_List[i].InvQuantity);
            }
            dataGridView1.DataSource = table;

            
        }

        private void metroTabPage1_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left = (this.Width = metroTabControl1.Width) / 2;
            metroTabControl1.Top = (this.Height = metroTabControl1.Height) / 2;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            rowIndex = dataGridView1.CurrentRow.Index;
            p.DeleteProduct(P_List[rowIndex].Id);
            MessageBox.Show("تمت ازالة المنتج بنجاح");
            DisplayBtn.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                NameTxt.Text = P_List[rowIndex].Name;
                SPriceTxt.Text = P_List[rowIndex].SellingPrice.ToString();
                SQtTxt.Text = P_List[rowIndex].ShopQuantity.ToString();
                IQtTxt.Text = P_List[rowIndex].InvQuantity.ToString();
                metroComboBox1.DisplayMember = "Name";
                metroComboBox1.ValueMember = "Id";
                metroComboBox1.DataSource = cs_Category.GetCategoryList();
                if (metroComboBox1.Items.Count > 0)
                    metroComboBox1.SelectedIndex = 0;
                metroComboBox1.Text = cs_Category.GetCategorys(P_List[rowIndex].Name);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Product.Id = P_List[rowIndex].Id;
            Product.Name = NameTxt.Text;
            Product.SellingPrice = Convert.ToDouble(SPriceTxt.Text);
            Product.ShopQuantity = Convert.ToInt32(SQtTxt.Text);
            Product.InvQuantity=Convert.ToInt32(IQtTxt.Text);
            Product.CategoryId = Convert.ToInt32(metroComboBox1.SelectedValue);
           // Product.Category.Name = metroComboBox1.SelectedText;
            p.AddOrUpdateProduct(Product);
            MessageBox.Show("تم تعديل المنتج بنجاح");
            DisplayBtn.PerformClick();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(MoveTxt.Text) < 1)
                MessageBox.Show("برجاء ادخال رقم أكبر من الصفر");
            else
            {
                if (!p.MoveToShop(P_List[rowIndex].Id, Convert.ToInt32(MoveTxt.Text)))
                {
                    MessageBox.Show("لا يوجد كمية كافية فى المخزن");
                }
                else
                {
                    MessageBox.Show("تم نقل المنتج بنجاح");
                    DisplayBtn.PerformClick();
                }
            }
        }

        private void NameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void SPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void SQtTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void IQtTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DiscTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void Supervisor()
        {
            EditBtn.Hide();
            DeleteBtn.Hide();
            Btn_Save.Hide();
            CancelBtn.Hide();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = SearchTxt.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            DisplayBtn.PerformClick();
        }
    }
}
