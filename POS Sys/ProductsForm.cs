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
        public ProductsForm()
        {
            InitializeComponent();
            p = new Cs_Products();
            cs_Category = new Cs_Category();
            P_List = new List<Products>();
            FillCategoryList();
        }
        private void Clear()
        {
            TxtName.Clear();
            TxtPPrice.Clear();
            TxtSPrice.Clear();
            TxtSQuantity.Clear();
            TxtIQuantity.Clear();
            TxtDiscount.Clear();
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
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Product = new Products();
            if (p.Exists(TxtName.Text))
            {
                MessageBox.Show("المنتج موجود مسبقا");
                Clear();
            }
            else
            {
                Product.Name = TxtName.Text;
                Product.PurchasingPrice = Convert.ToInt32(TxtPPrice.Text);
                Product.Discount = Convert.ToInt32(TxtDiscount.Text);
                Product.SellingPrice = Convert.ToInt32(TxtSPrice.Text);
                Product.ShopQuantity = Convert.ToInt32(TxtSQuantity.Text);
                Product.InvQuantity = Convert.ToInt32(TxtIQuantity.Text);
                Product.Category = cs_Category.GetCategory(ComboCat.Text);
                p.AddOrUpdateProduct(Product);
                MessageBox.Show("تمت اضافة المنتج بنجاح");
                Clear();
            }
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            P_List = p.GetProducts();
            dataGridView1.DataSource = P_List;
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
            rowIndex = e.RowIndex;
            NameTxt.Text = P_List[rowIndex].Name;
            PPriceTxt.Text = P_List[rowIndex].PurchasingPrice.ToString();
            SPriceTxt.Text = P_List[rowIndex].SellingPrice.ToString();
            SQtTxt.Text = P_List[rowIndex].ShopQuantity.ToString();
            IQtTxt.Text = P_List[rowIndex].InvQuantity.ToString();
            DiscTxt.Text = P_List[rowIndex].Discount.ToString();
            metroComboBox1.Text = cs_Category.GetCategorys(P_List[rowIndex].Name);
            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "Id";
            metroComboBox1.DataSource = cs_Category.GetCategoryList();
            if (ComboCat.Items.Count > 0)
                ComboCat.SelectedIndex = 0;

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Product.Name = NameTxt.Text;
            Product.PurchasingPrice = Convert.ToDouble(PPriceTxt.Text);
            Product.SellingPrice = Convert.ToDouble(SPriceTxt.Text);
            Product.ShopQuantity = Convert.ToInt32(SQtTxt.Text);
            Product.InvQuantity=Convert.ToInt32(IQtTxt.Text);
            Product.Discount= Convert.ToInt32(DiscTxt.Text);
            Product.Category.Id = Convert.ToInt32(metroComboBox1.SelectedValue);
            Product.Category.Name = metroComboBox1.SelectedText;
            p.AddOrUpdateProduct(Product);
            MessageBox.Show("تم تعديل المستخدم بنجاح");
            DisplayBtn.PerformClick();
        }
    }
}
