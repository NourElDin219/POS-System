using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Sys.CS;
using POS_Sys.Models;
namespace POS_Sys
{
    public partial class CategoryForm : Form
    {
        private Cs_Category cat;
        private List<Category> c;
        private Category category;
        public CategoryForm()
        {
            InitializeComponent();
            cat = new Cs_Category();
            category = new Category();
            display();
        }
        public void display()
        {
            c = cat.GetCategoryList();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < c.Count(); i++)
            {
                dataGridView1.Rows.Add(c[i].Id, c[i].Name);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CatTxt.Text != "")
            {
                category.Name = CatTxt.Text;
                cat.AddOrUpdateCategory(category);
                display();
                category = new Category();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String CName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (CName == "Edit")
            {
                CatTxt.Text = c[e.RowIndex].Name;
                category = c[e.RowIndex];
                //AddBtn.Visible = false;
                //Edit.Visible = true;
            }
            else if (CName == "Delete")
            {
                cat.DeleteCategory(c[e.RowIndex].Id);
                MessageBox.Show("تمت ازالة النوع بنجاح");
                display();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CatTxt.Text != "")
            {
                category.Name = CatTxt.Text;
                cat.AddOrUpdateCategory(category);
                MessageBox.Show("تمت التعديل بنجاح");
                display();
            }
        }
    }
}
