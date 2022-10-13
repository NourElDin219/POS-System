
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CancelBtn = new MetroFramework.Controls.MetroButton();
            this.Btn_Save = new MetroFramework.Controls.MetroButton();
            this.ComboCat = new MetroFramework.Controls.MetroComboBox();
            this.TxtSPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.DisplayBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.MoveTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.MoveBtn = new MetroFramework.Controls.MetroButton();
            this.IQtTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SQtTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SPriceTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.NameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.EditBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.TxtIQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.TxtSQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ResetFilterBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(725, 430);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(98, 44);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(541, 430);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(98, 44);
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
            "Cashier",
            "Supervisor"});
            this.ComboCat.Location = new System.Drawing.Point(415, 109);
            this.ComboCat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboCat.Name = "ComboCat";
            this.ComboCat.Size = new System.Drawing.Size(193, 30);
            this.ComboCat.TabIndex = 10;
            // 
            // TxtSPrice
            // 
            this.TxtSPrice.Location = new System.Drawing.Point(415, 168);
            this.TxtSPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtSPrice.Name = "TxtSPrice";
            this.TxtSPrice.Size = new System.Drawing.Size(193, 24);
            this.TxtSPrice.TabIndex = 9;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(269, 168);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(84, 20);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Selling Price";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(269, 109);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 20);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Category";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(466, 505);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(115, 44);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "ازالة المنتج";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(33, 505);
            this.DisplayBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(115, 44);
            this.DisplayBtn.TabIndex = 3;
            this.DisplayBtn.Text = "عرض المنتجات";
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.comboBox2);
            this.metroTabPage2.Controls.Add(this.ResetFilterBtn);
            this.metroTabPage2.Controls.Add(this.SearchTxt);
            this.metroTabPage2.Controls.Add(this.MoveTxt);
            this.metroTabPage2.Controls.Add(this.metroLabel15);
            this.metroTabPage2.Controls.Add(this.MoveBtn);
            this.metroTabPage2.Controls.Add(this.IQtTxt);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.SQtTxt);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroComboBox1);
            this.metroTabPage2.Controls.Add(this.SPriceTxt);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.NameTxt);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.DeleteBtn);
            this.metroTabPage2.Controls.Add(this.EditBtn);
            this.metroTabPage2.Controls.Add(this.DisplayBtn);
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(925, 604);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Edit Products";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarSize = 9;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt.Location = new System.Drawing.Point(588, 6);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(334, 27);
            this.SearchTxt.TabIndex = 37;
            this.SearchTxt.Text = "ابحث عن منتج";
            this.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SearchTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchTxt_MouseClick);
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // MoveTxt
            // 
            this.MoveTxt.Location = new System.Drawing.Point(601, 492);
            this.MoveTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MoveTxt.Name = "MoveTxt";
            this.MoveTxt.Size = new System.Drawing.Size(192, 24);
            this.MoveTxt.TabIndex = 36;
            this.MoveTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(833, 492);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(90, 20);
            this.metroLabel15.TabIndex = 35;
            this.metroLabel15.Text = "نقل الى المحل";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveBtn
            // 
            this.MoveBtn.Location = new System.Drawing.Point(702, 542);
            this.MoveBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MoveBtn.Name = "MoveBtn";
            this.MoveBtn.Size = new System.Drawing.Size(115, 47);
            this.MoveBtn.TabIndex = 34;
            this.MoveBtn.Text = "نقل";
            this.MoveBtn.Click += new System.EventHandler(this.MoveBtn_Click);
            // 
            // IQtTxt
            // 
            this.IQtTxt.Location = new System.Drawing.Point(725, 298);
            this.IQtTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IQtTxt.Name = "IQtTxt";
            this.IQtTxt.Size = new System.Drawing.Size(192, 24);
            this.IQtTxt.TabIndex = 30;
            this.IQtTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IQtTxt_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(594, 298);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 20);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Inventory Quantity";
            // 
            // SQtTxt
            // 
            this.SQtTxt.Location = new System.Drawing.Point(725, 248);
            this.SQtTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SQtTxt.Name = "SQtTxt";
            this.SQtTxt.Size = new System.Drawing.Size(192, 24);
            this.SQtTxt.TabIndex = 28;
            this.SQtTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SQtTxt_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(594, 248);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.metroComboBox1.Location = new System.Drawing.Point(725, 148);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(193, 30);
            this.metroComboBox1.TabIndex = 26;
            // 
            // SPriceTxt
            // 
            this.SPriceTxt.Location = new System.Drawing.Point(725, 200);
            this.SPriceTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SPriceTxt.Name = "SPriceTxt";
            this.SPriceTxt.Size = new System.Drawing.Size(192, 24);
            this.SPriceTxt.TabIndex = 25;
            this.SPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SPriceTxt_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(594, 200);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 20);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Selling Price";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(594, 148);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(66, 20);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "Category";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(726, 99);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(192, 24);
            this.NameTxt.TabIndex = 20;
            this.NameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPress);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(595, 99);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(99, 20);
            this.metroLabel14.TabIndex = 19;
            this.metroLabel14.Text = "Product Name";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(702, 351);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(115, 47);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "تعديل المنتج ";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 482);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(415, 52);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(193, 24);
            this.TxtName.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(269, 52);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Product Name";
            // 
            // metroTabPage1
            // 
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
            this.metroTabPage1.Controls.Add(this.TxtName);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(925, 604);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add New Product";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarSize = 9;
            this.metroTabPage1.Resize += new System.EventHandler(this.metroTabPage1_Resize);
            // 
            // TxtIQuantity
            // 
            this.TxtIQuantity.Location = new System.Drawing.Point(415, 266);
            this.TxtIQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtIQuantity.Name = "TxtIQuantity";
            this.TxtIQuantity.Size = new System.Drawing.Size(193, 24);
            this.TxtIQuantity.TabIndex = 16;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(269, 266);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(124, 20);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Inventory Quantity";
            // 
            // TxtSQuantity
            // 
            this.TxtSQuantity.Location = new System.Drawing.Point(415, 216);
            this.TxtSQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtSQuantity.Name = "TxtSQuantity";
            this.TxtSQuantity.Size = new System.Drawing.Size(193, 24);
            this.TxtSQuantity.TabIndex = 14;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(269, 216);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.metroTabControl1.Location = new System.Drawing.Point(0, 55);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(933, 647);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.metroTabControl1_Selected);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(933, 55);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ResetFilterBtn
            // 
            this.ResetFilterBtn.Location = new System.Drawing.Point(613, 39);
            this.ResetFilterBtn.Name = "ResetFilterBtn";
            this.ResetFilterBtn.Size = new System.Drawing.Size(105, 30);
            this.ResetFilterBtn.TabIndex = 39;
            this.ResetFilterBtn.Text = "ازالة الفلتر";
            this.ResetFilterBtn.UseVisualStyleBackColor = true;
            this.ResetFilterBtn.Click += new System.EventHandler(this.ResetFilterBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(742, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(175, 25);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 702);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductsForm_Load);
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
        private MetroFramework.Controls.MetroTextBox TxtIQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox TxtSQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox IQtTxt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox SQtTxt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox SPriceTxt;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox NameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox MoveTxt;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton MoveBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button ResetFilterBtn;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}