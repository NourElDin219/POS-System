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
    public partial class admin : Form
    {
        ProductsForm pfrm;
        Users_Form ufrm;
        CategoryForm cfrm;
        public admin()
        {
            InitializeComponent();
            pfrm = new ProductsForm();
            ufrm = new Users_Form();
            cfrm = new CategoryForm();
            pfrm.TopLevel = false;
            ufrm.TopLevel = false;
            cfrm.TopLevel = false;
            panel4.Controls.Add(pfrm);
            panel4.Controls.Add(ufrm);
            panel4.Controls.Add(cfrm);
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pfrm.BringToFront();
            pfrm.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ufrm.BringToFront();
            ufrm.Show();
        }

        private void userSettings1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            ufrm.Dispose();
            cfrm.Dispose();
            pfrm.Dispose();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            cfrm.BringToFront();
            cfrm.Show();
        }
    }
}
