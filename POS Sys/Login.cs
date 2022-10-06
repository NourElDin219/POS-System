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
using POS_Sys.Models;

namespace POS_Sys
{
    public partial class Login : Form
    {
        UserCrudOps user;
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txt_Username;
            user = new UserCrudOps();
            user.ReadUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            if (user.Authorized(txt_Username.Text, txt_Password.Text))
            {
                if (user.getRole() == "Admin"|| user.getRole() == "Supervisor")
                {
                    admin admin = new admin(user.getName(), user.Id, user.getRole());
                    this.Hide();
                    admin.ShowDialog();
                    this.Close();
                }
                else if(user.getRole() == "Cashier")
                {
                    Sales sales = new Sales(user.getName(),user.Id);
                    this.Hide();
                    sales.ShowDialog();
                    this.Close();
                }

            }
            else
                MessageBox.Show("Invalid Username or Password.");
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
