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
            c = new List<Category>();
            display();
        }
        public void display()
        {
            c.Clear();
            cat = new Cs_Category();
            c = cat.GetCategoryList();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < c.Count(); i++)
            {
                dataGridView1.Rows.Add(i+1, c[i].Name);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            using(CategoryName frm = new CategoryName())
            {
                frm.ShowDialog();
            }
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String CName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (CName == "Edit")
            {
                using (CategoryName frm = new CategoryName(e.RowIndex))
                {
                    frm.ShowDialog();
                }
                display();
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
            
        }
    }
}
