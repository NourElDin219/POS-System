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
    public partial class CategoryName : Form
    {
        Cs_Category cat;
        List<Category> c;
        Category category;
        int index;
        public CategoryName()
        {
            InitializeComponent();
            cat = new Cs_Category();
            c = new List<Category>();
            category = new Category();
            index = -1;

        }
        public CategoryName(int index)
        {
            InitializeComponent();
            cat = new Cs_Category();
            c = new List<Category>();
            category = new Category();
            this.index = index;
        }

        private void CategoryName_Load(object sender, EventArgs e)
        {
            c = cat.GetCategoryList();
            if (index != -1)
                QuantityText.Text = c[index].Name;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                if (QuantityText.Text != "")
                {
                    for (int i = 0; i < c.Count; i++)
                    {
                        if (c[i].Name == QuantityText.Text)
                        {
                            MessageBox.Show("النوع موجود بالفعل");
                            return;
                        }
                    }
                        category.Name = QuantityText.Text;
                        cat.AddOrUpdateCategory(category);
                        category = new Category();
                        this.Dispose();
                    
                }
                else
                {
                    MessageBox.Show("برجاء كتابة نوع");
                }
            }
            else
            {
                if (QuantityText.Text != "")
                {
                    for (int i = 0; i < c.Count; i++)
                    {
                        if (c[i].Name == QuantityText.Text)
                        {
                            MessageBox.Show("النوع موجود بالفعل");
                            return;
                        }
                    }
                        c[index].Name = QuantityText.Text;
                        cat.AddOrUpdateCategory(c[index]);
                        this.Dispose();
                    
                }
                else
                {
                    MessageBox.Show("برجاء كتابة نوع");
                }
            }
        }

        private void QuantityText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
