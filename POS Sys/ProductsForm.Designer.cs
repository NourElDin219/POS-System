
namespace POS_Sys
{
    partial class ProductsForm
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
            this.CancelBtn = new MetroFramework.Controls.MetroButton();
            this.Btn_Save = new MetroFramework.Controls.MetroButton();
            this.ComboCat = new MetroFramework.Controls.MetroComboBox();
            this.TxtSPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtPPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.DisplayBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.EditBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.TxtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.TxtIQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.TxtSQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(930, 614);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(126, 60);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(696, 614);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(126, 60);
            this.Btn_Save.TabIndex = 11;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // ComboCat
            // 
            this.ComboCat.FormattingEnabled = true;
            this.ComboCat.ItemHeight = 24;
            this.ComboCat.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Cashier"});
            this.ComboCat.Location = new System.Drawing.Point(485, 148);
            this.ComboCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboCat.Name = "ComboCat";
            this.ComboCat.Size = new System.Drawing.Size(247, 30);
            this.ComboCat.TabIndex = 10;
            // 
            // TxtSPrice
            // 
            this.TxtSPrice.Location = new System.Drawing.Point(485, 300);
            this.TxtSPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSPrice.Name = "TxtSPrice";
            this.TxtSPrice.Size = new System.Drawing.Size(248, 33);
            this.TxtSPrice.TabIndex = 9;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(346, 300);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(84, 20);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Selling Price";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(346, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 20);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Category";
            // 
            // TxtPPrice
            // 
            this.TxtPPrice.Location = new System.Drawing.Point(485, 226);
            this.TxtPPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPPrice.Name = "TxtPPrice";
            this.TxtPPrice.PasswordChar = '●';
            this.TxtPPrice.Size = new System.Drawing.Size(248, 33);
            this.TxtPPrice.TabIndex = 5;
            this.TxtPPrice.UseSystemPasswordChar = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(346, 226);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Purchasing Price";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(902, 683);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(148, 59);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "ازالة المنتج";
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(43, 683);
            this.DisplayBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(148, 59);
            this.DisplayBtn.TabIndex = 3;
            this.DisplayBtn.Text = "عرض المنتجات";
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTextBox1);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroTextBox2);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroTextBox3);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroComboBox1);
            this.metroTabPage2.Controls.Add(this.metroTextBox4);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroTextBox5);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.metroTextBox6);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.DeleteBtn);
            this.metroTabPage2.Controls.Add(this.EditBtn);
            this.metroTabPage2.Controls.Add(this.DisplayBtn);
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarSize = 14;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1192, 809);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Edit Products";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarSize = 11;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(892, 451);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(247, 33);
            this.metroTextBox1.TabIndex = 32;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(754, 451);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 20);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Discount";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(892, 385);
            this.metroTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(247, 33);
            this.metroTextBox2.TabIndex = 30;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(754, 385);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 20);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Inventory Quantity";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(892, 318);
            this.metroTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(247, 33);
            this.metroTextBox3.TabIndex = 28;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(754, 318);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 20);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Shop Quantity";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Cashier"});
            this.metroComboBox1.Location = new System.Drawing.Point(892, 101);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(247, 30);
            this.metroComboBox1.TabIndex = 26;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(892, 253);
            this.metroTextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(247, 33);
            this.metroTextBox4.TabIndex = 25;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(754, 253);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 20);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Selling Price";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(754, 101);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(66, 20);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "Category";
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(892, 178);
            this.metroTextBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '●';
            this.metroTextBox5.Size = new System.Drawing.Size(247, 33);
            this.metroTextBox5.TabIndex = 22;
            this.metroTextBox5.UseSystemPasswordChar = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(754, 178);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(112, 20);
            this.metroLabel13.TabIndex = 21;
            this.metroLabel13.Text = "Purchasing Price";
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.Location = new System.Drawing.Point(892, 23);
            this.metroTextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(247, 33);
            this.metroTextBox6.TabIndex = 20;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(754, 23);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(99, 20);
            this.metroLabel14.TabIndex = 19;
            this.metroLabel14.Text = "Product Name";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(902, 540);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(148, 64);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "تعديل المنتج ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(747, 515);
            this.dataGridView1.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(485, 70);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(248, 33);
            this.TxtName.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(346, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Product Name";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.TxtDiscount);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.TxtIQuantity);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.TxtSQuantity);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.CancelBtn);
            this.metroTabPage1.Controls.Add(this.Btn_Save);
            this.metroTabPage1.Controls.Add(this.ComboCat);
            this.metroTabPage1.Controls.Add(this.TxtSPrice);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.TxtPPrice);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.TxtName);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarSize = 14;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1192, 809);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add New Product";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarSize = 11;
            this.metroTabPage1.Resize += new System.EventHandler(this.metroTabPage1_Resize);
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Location = new System.Drawing.Point(485, 499);
            this.TxtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(248, 33);
            this.TxtDiscount.TabIndex = 18;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(346, 499);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(63, 20);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Discount";
            // 
            // TxtIQuantity
            // 
            this.TxtIQuantity.Location = new System.Drawing.Point(485, 433);
            this.TxtIQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtIQuantity.Name = "TxtIQuantity";
            this.TxtIQuantity.Size = new System.Drawing.Size(248, 33);
            this.TxtIQuantity.TabIndex = 16;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(346, 433);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(124, 20);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Inventory Quantity";
            // 
            // TxtSQuantity
            // 
            this.TxtSQuantity.Location = new System.Drawing.Point(485, 365);
            this.TxtSQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSQuantity.Name = "TxtSQuantity";
            this.TxtSQuantity.Size = new System.Drawing.Size(248, 33);
            this.TxtSQuantity.TabIndex = 14;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(346, 365);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(96, 20);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Shop Quantity";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 98);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1200, 852);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 98);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 950);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton CancelBtn;
        private MetroFramework.Controls.MetroButton Btn_Save;
        private MetroFramework.Controls.MetroComboBox ComboCat;
        private MetroFramework.Controls.MetroTextBox TxtSPrice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtPPrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton DisplayBtn;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton EditBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox TxtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox TxtDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox TxtIQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox TxtSQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroLabel metroLabel14;
    }
}