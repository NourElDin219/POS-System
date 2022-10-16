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
        private ProductsForm pfrm;
        private Users_Form ufrm;
        private CategoryForm cfrm;
        private Profit prfrm;
        private Reports rfrm;
        private string CName;
        private int CId;
        private AdvancePaymentFrm afrm;
        public admin()
        {
            InitializeComponent();
            pfrm = new ProductsForm();
            ufrm = new Users_Form();
            cfrm = new CategoryForm();
            prfrm = new Profit();
            rfrm = new Reports();
            pfrm.TopLevel = false;
            ufrm.TopLevel = false;
            cfrm.TopLevel = false;
            prfrm.TopLevel = false;
            rfrm.TopLevel = false;
            panel4.Controls.Add(pfrm);
            panel4.Controls.Add(ufrm);
            panel4.Controls.Add(cfrm);
            panel4.Controls.Add(prfrm);
            panel4.Controls.Add(rfrm);
        }
        public admin(string Name,int id,string role)
        {
            InitializeComponent();
            pfrm = new ProductsForm();
            ufrm = new Users_Form();
            cfrm = new CategoryForm();
            prfrm = new Profit();
            rfrm = new Reports();
            afrm = new AdvancePaymentFrm();
            pfrm.TopLevel = false;
            ufrm.TopLevel = false;
            cfrm.TopLevel = false;
            prfrm.TopLevel = false;
            rfrm.TopLevel = false;
            afrm.TopLevel = false;
            if (role == "Supervisor")
            {
                pfrm.Supervisor();
                this.CategoryBtn.Hide();
                ufrm.Supervisor();
            }
            panel4.Controls.Add(pfrm);
            panel4.Controls.Add(ufrm);
            panel4.Controls.Add(cfrm);
            panel4.Controls.Add(prfrm);
            panel4.Controls.Add(rfrm);
            panel4.Controls.Add(afrm);
            CName = Name;
            CId = id;
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
          //  label4.Text = CName;
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
            prfrm.Dispose();
            rfrm.Dispose();
            afrm.Dispose();
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

        private void ProfitBtn_Click(object sender, EventArgs e)
        {
            prfrm.BringToFront();
            prfrm.Show();
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales(CName, CId);
            this.Hide();
            sale.ShowDialog();
            sale.Dispose();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rfrm.BringToFront();
            rfrm.Show();
        }

        private void AdvacnePayBtn_Click(object sender, EventArgs e)
        {
            afrm.BringToFront();
            afrm.Show();
        }
    }
}
