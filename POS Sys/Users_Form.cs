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
    public partial class Users_Form : Form
    {
        private UserCrudOps us;
        private List<Users> users;
        private int rowIndex;
        private bool isSupervisor;
        public Users_Form()
        {
            InitializeComponent();
            us = new UserCrudOps();
            isSupervisor = false;
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
            if (String.IsNullOrEmpty(Nametxt.Text)|| String.IsNullOrEmpty(Usrtxt.Text)|| String.IsNullOrEmpty(Passtxt.Text)|| String.IsNullOrEmpty(RoleCombo.Text) )
            {
                MessageBox.Show("برجاء ملئ جميع الخانات");
                return;
            }
            int success = us.CreateUser(Nametxt.Text, Usrtxt.Text, Passtxt.Text, RoleCombo.Text);
            if (success==1)
            {
                MessageBox.Show("تمت اضافة المستخدم بنجاح");
            }
            else
                MessageBox.Show("المستخدم موجود مسبقا");
            Clear();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            users=us.ReadAllUsers();

            table.Columns.Add("الاسم", typeof(string));
            table.Columns.Add("اسم المستخدم", typeof(string));
            table.Columns.Add("كلمة السر", typeof(string));

            for (int i = 0; i < users.Count(); i++)
            {
                table.Rows.Add( users[i].Name, users[i].UserName, users[i].Password);
            }
            dataGridView1.DataSource = table;
            if(isSupervisor)
                dataGridView1.Columns["كلمة السر"].Visible = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            rowIndex = dataGridView1.CurrentRow.Index;
            us.DeleteUser(users[rowIndex].Id);
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            txt_Name.Text = users[rowIndex].Name;
            txt_User.Text = users[rowIndex].UserName;
            txt_Password.Text = users[rowIndex].Password;
            us.ReadUser(users[rowIndex].UserName);
            Combo_Role.Text = us.getRole();
        }
        public void Supervisor()
        {
            EditBtn.Hide();
            DeleteBtn.Hide();
            RoleCombo.Items.Clear();
            RoleCombo.Items.Add("Cashier");
            isSupervisor = true;
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int updated=us.UpdateUser(users[rowIndex].Id, txt_Name.Text, txt_User.Text, txt_Password.Text, Combo_Role.Text);
            if (updated == 1)
            {
                MessageBox.Show("تم تعديل المستخدم بنجاح");
                DisplayBtn.PerformClick();
            }
            else
            {
                MessageBox.Show("اسم المستخدم موجود مسبقا");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nametxt_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Passtxt_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Usrtxt_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Combo_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txt_Password_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txt_User_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void Users_Form_Load(object sender, EventArgs e)
        {
            DisplayBtn.PerformClick();
        }
    }
}
