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
    public partial class Users_Form : Form
    {
        public Users_Form()
        {
            InitializeComponent();
        }

        private void metroTabPage1_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left = (this.Width = metroTabControl1.Width) / 2;
            metroTabControl1.Top = (this.Height = metroTabControl1.Height) / 2;
        }
        private void Clear()
        {
            Nametxt.Clear();
            Passtxt.Clear();
            RoleCombo.Text="";
            Usrtxt.Clear();
            Usrtxt.Focus();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            UserCrudOps us = new UserCrudOps();
            int success = us.CreateUser(Nametxt.Text, Usrtxt.Text, Passtxt.Text, RoleCombo.Text);
            if (success==1)
            {
                MessageBox.Show("تمت اضافة المستخدم بنجاح");
            }
            else
                MessageBox.Show("المستخدم موجود مسبقا");
            Clear();
        }
    }
}
