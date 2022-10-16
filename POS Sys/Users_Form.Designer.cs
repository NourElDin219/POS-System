
namespace POS_Sys
{
    partial class Users_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.CancelBtn = new MetroFramework.Controls.MetroButton();
            this.Btn_Save = new MetroFramework.Controls.MetroButton();
            this.RoleCombo = new MetroFramework.Controls.MetroComboBox();
            this.Nametxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Passtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.Usrtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.Combo_Role = new MetroFramework.Controls.MetroComboBox();
            this.txt_Name = new MetroFramework.Controls.MetroTextBox();
            this.txt_Password = new MetroFramework.Controls.MetroTextBox();
            this.txt_User = new MetroFramework.Controls.MetroTextBox();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.EditBtn = new MetroFramework.Controls.MetroButton();
            this.DisplayBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1032, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "المستخدمين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 68);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.RightToLeftLayout = true;
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1032, 685);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.CancelBtn);
            this.metroTabPage1.Controls.Add(this.Btn_Save);
            this.metroTabPage1.Controls.Add(this.RoleCombo);
            this.metroTabPage1.Controls.Add(this.Nametxt);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.Passtxt);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroTextBox2);
            this.metroTabPage1.Controls.Add(this.Usrtxt);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1024, 642);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "انشاء مستخدم جديد";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            this.metroTabPage1.Resize += new System.EventHandler(this.metroTabPage1_Resize);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(567, 310);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 42);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "الغاء";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(398, 310);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(112, 42);
            this.Btn_Save.TabIndex = 11;
            this.Btn_Save.Text = "حفظ";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // RoleCombo
            // 
            this.RoleCombo.FormattingEnabled = true;
            this.RoleCombo.ItemHeight = 24;
            this.RoleCombo.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Cashier"});
            this.RoleCombo.Location = new System.Drawing.Point(420, 156);
            this.RoleCombo.Name = "RoleCombo";
            this.RoleCombo.Size = new System.Drawing.Size(220, 30);
            this.RoleCombo.TabIndex = 10;
            this.RoleCombo.SelectedIndexChanged += new System.EventHandler(this.RoleCombo_SelectedIndexChanged);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(420, 209);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(220, 23);
            this.Nametxt.TabIndex = 9;
            this.Nametxt.Click += new System.EventHandler(this.Nametxt_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(720, 209);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 20);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "الاسم";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(724, 156);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 20);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "الدور";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(420, 99);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '●';
            this.Passtxt.Size = new System.Drawing.Size(220, 23);
            this.Passtxt.TabIndex = 5;
            this.Passtxt.UseSystemPasswordChar = true;
            this.Passtxt.Click += new System.EventHandler(this.Passtxt_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(701, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "كلمة السر";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(420, 102);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(220, 23);
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // Usrtxt
            // 
            this.Usrtxt.Location = new System.Drawing.Point(420, 49);
            this.Usrtxt.Name = "Usrtxt";
            this.Usrtxt.Size = new System.Drawing.Size(220, 23);
            this.Usrtxt.TabIndex = 3;
            this.Usrtxt.Click += new System.EventHandler(this.Usrtxt_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(673, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "اسم المستخدم";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.Combo_Role);
            this.metroTabPage2.Controls.Add(this.txt_Name);
            this.metroTabPage2.Controls.Add(this.txt_Password);
            this.metroTabPage2.Controls.Add(this.txt_User);
            this.metroTabPage2.Controls.Add(this.DeleteBtn);
            this.metroTabPage2.Controls.Add(this.EditBtn);
            this.metroTabPage2.Controls.Add(this.DisplayBtn);
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1024, 642);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "تعديل مستخدم";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // Combo_Role
            // 
            this.Combo_Role.FormattingEnabled = true;
            this.Combo_Role.ItemHeight = 24;
            this.Combo_Role.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Cashier"});
            this.Combo_Role.Location = new System.Drawing.Point(679, 145);
            this.Combo_Role.Name = "Combo_Role";
            this.Combo_Role.Size = new System.Drawing.Size(220, 30);
            this.Combo_Role.TabIndex = 18;
            this.Combo_Role.SelectedIndexChanged += new System.EventHandler(this.Combo_Role_SelectedIndexChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(679, 198);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(220, 23);
            this.txt_Name.TabIndex = 17;
            this.txt_Name.Click += new System.EventHandler(this.txt_Name_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(679, 88);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.Size = new System.Drawing.Size(220, 23);
            this.txt_Password.TabIndex = 14;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.Click += new System.EventHandler(this.txt_Password_Click);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(679, 38);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(220, 23);
            this.txt_User.TabIndex = 12;
            this.txt_User.Click += new System.EventHandler(this.txt_User_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(892, 586);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(132, 60);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "ازالة المستخدم";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(796, 292);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(132, 60);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "تعديل المستخدم";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(0, 582);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(132, 60);
            this.DisplayBtn.TabIndex = 3;
            this.DisplayBtn.Text = "عرض المستخدمين";
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(664, 577);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.textBox1);
            this.metroTabPage3.Controls.Add(this.button1);
            this.metroTabPage3.Controls.Add(this.label2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1024, 642);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "تغيير كلمة مرور المسترجعات";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة السر الجديدة";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 30);
            this.textBox1.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(967, 195);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 20);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "الاسم";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(971, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 20);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "الدور";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(948, 88);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 20);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "كلمة السر";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(920, 38);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(101, 20);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "اسم المستخدم";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Users_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 753);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Users_Form";
            this.Text = "Users_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Users_Form_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox RoleCombo;
        private MetroFramework.Controls.MetroTextBox Nametxt;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox Passtxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox Usrtxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton Btn_Save;
        private MetroFramework.Controls.MetroButton CancelBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton DisplayBtn;
        private MetroFramework.Controls.MetroComboBox Combo_Role;
        private MetroFramework.Controls.MetroTextBox txt_Name;
        private MetroFramework.Controls.MetroTextBox txt_Password;
        private MetroFramework.Controls.MetroTextBox txt_User;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton EditBtn;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}