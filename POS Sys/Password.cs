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
namespace POS_Sys
{
    public partial class Password : Form
    {
        UserCrudOps user;
        public Password()
        {
            InitializeComponent();
            user = new UserCrudOps();
            this.ActiveControl = QuantityText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QuantityText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
        public bool Authorized()
        {
            if (user.Authorized("Password", QuantityText.Text))
            {
                if (user.getRole() == "Admin" || user.getRole() == "Supervisor")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
