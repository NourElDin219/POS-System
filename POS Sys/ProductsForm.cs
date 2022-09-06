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
        public ProductsForm()
        {
            InitializeComponent();
            FillCategoryList();
            p = new Cs_Products();
            cs_Category = new Cs_Category();
            P_List = new List<Products>();
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

            Cs_Category cs_Category = new Cs_Category();
            ComboCat.DisplayMember = "Name";
            ComboCat.ValueMember = "Id";
            ComboCat.DataSource = cs_Category.GetCategoryList();

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
                Product.Discount = Convert.ToInt32(TxtDiscount.Text);
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
    }
}
