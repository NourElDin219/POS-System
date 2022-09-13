using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using POS_Sys.CS;
namespace POS_Sys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserCrudOps user = new UserCrudOps();
            if (user.Authorized(txt_Username.Text, txt_Password.Text))
            {
                if (user.getRole() == "Admin")
                {
                    admin admin = new admin();
                    this.Hide();
                    admin.ShowDialog();
                    this.Close();
                }
                else if(user.getRole() == "Cashier")
                {
                    Sales sales = new Sales();
                    this.Hide();
                    sales.ShowDialog();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Invalid Username or Password.");
        }
    }
}
