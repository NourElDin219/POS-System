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
    public partial class ViewProducts : Form
    {
        private List<Products> P_List;
        private Cs_Products p;
        public ViewProducts()
        {
            InitializeComponent();
            P_List = new List<Products>();
            p = new Cs_Products();
            DisplayProducts();
        }
        private void DisplayProducts()
        {
            dataGridView1.Rows.Clear();
            P_List = p.GetProducts();
            for (int i = 0; i < P_List.Count(); i++)
            {
                dataGridView1.Rows.Add(i + 1, P_List[i].Name, P_List[i].SellingPrice, P_List[i].ShopQuantity);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = SearchTxt.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
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
    }
}
