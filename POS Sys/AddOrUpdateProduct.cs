using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Sys.Models;
using POS_Sys.CS;

namespace POS_Sys
{
    public partial class AddOrUpdateProduct : Form
    {
        public Products Product;
        public AddOrUpdateProduct(int ProductId)
        {
            InitializeComponent();
            if (ProductId != 0)
            {
                Cs_Products cs_Products = new Cs_Products();
                Product = cs_Products.GetProduct(ProductId);
                FillForm();
            }
            else
            {
                Product = new Products();
            }
            FillCategoryList();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ValidateSaveProduct();
            Product.Name = NameText.Text;
            Product.PurchasingPrice = Convert.ToInt32(PurchasingPriceText.Text);
            Product.Discount = Convert.ToInt32(DiscountText.Text);
            Product.SellingPrice = Convert.ToInt32(SellingPriceText.Text);
            Product.Discount = Convert.ToInt32(DiscountText.Text);
            Product.InvQuantity = Convert.ToInt32(QuantityText.Text);
            Cs_Category cs_Category = new Cs_Category();
            Product.Category= cs_Category.GetCategory(CategoryList.Text);
            Cs_Products cs_Products =new Cs_Products();    
            cs_Products.AddOrUpdateProduct(Product);
        }
        public void FillForm()
        {
             NameText.Text= Product.Name;
            PurchasingPriceText.Text=Product.PurchasingPrice.ToString() ;
            DiscountText.Text=Product.Discount.ToString() ;
            SellingPriceText.Text=Product.SellingPrice.ToString() ;
            DiscountText.Text=Product.Discount.ToString();
            QuantityText.Text=Product.InvQuantity.ToString() ;
        }
        private void AddOrUpdateProduct_Load(object sender, EventArgs e)
        {

        }
        public bool ValidateSaveProduct()
        {
            if (textBox1.Text == "" || NameText.Text == "" || PurchasingPriceText.Text == ""|| SellingPriceText.Text == ""|| DiscountText.Text == ""|| QuantityText.Text == "")
            {
                return false;   
            }
            return true;
        }
        public void FillCategoryList()
        {
            
            Cs_Category cs_Category = new Cs_Category();
            CategoryList.DisplayMember = "Name";
            CategoryList.ValueMember = "Id";
            CategoryList.DataSource = cs_Category.GetCategoryList();
            CategoryList.SelectedIndex = 0;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
