
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
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.DisplayBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PPriceText = new MetroFramework.Controls.MetroTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ResetFilterBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.MoveTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.MoveBtn = new MetroFramework.Controls.MetroButton();
            this.IQtTxt = new MetroFramework.Controls.MetroTextBox();
            this.SQtTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SPriceTxt = new MetroFramework.Controls.MetroTextBox();
            this.NameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.EditBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.TxtPPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtIQuantity = new MetroFramework.Controls.MetroTextBox();
            this.TxtSQuantity = new MetroFramework.Controls.MetroTextBox();
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
            this.CancelBtn.Location = new System.Drawing.Point(489, 419);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(98, 44);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "الغاء";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(305, 419);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(98, 44);
            this.Btn_Save.TabIndex = 11;
            this.Btn_Save.Text = "اضافة";
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
            this.ComboCat.Location = new System.Drawing.Point(285, 102);
            this.ComboCat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboCat.Name = "ComboCat";
            this.ComboCat.Size = new System.Drawing.Size(193, 30);
            this.ComboCat.TabIndex = 10;
            // 
            // TxtSPrice
            // 
            this.TxtSPrice.Location = new System.Drawing.Point(285, 202);
            this.TxtSPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtSPrice.Name = "TxtSPrice";
            this.TxtSPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtSPrice.Size = new System.Drawing.Size(193, 24);
            this.TxtSPrice.TabIndex = 9;
            this.TxtSPrice.Click += new System.EventHandler(this.TxtSPrice_Click);
            this.TxtSPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSPrice_KeyPress);
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
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.PPriceText);
            this.metroTabPage2.Controls.Add(this.comboBox2);
            this.metroTabPage2.Controls.Add(this.ResetFilterBtn);
            this.metroTabPage2.Controls.Add(this.SearchTxt);
            this.metroTabPage2.Controls.Add(this.MoveTxt);
            this.metroTabPage2.Controls.Add(this.metroLabel15);
            this.metroTabPage2.Controls.Add(this.MoveBtn);
            this.metroTabPage2.Controls.Add(this.IQtTxt);
            this.metroTabPage2.Controls.Add(this.SQtTxt);
            this.metroTabPage2.Controls.Add(this.metroComboBox1);
            this.metroTabPage2.Controls.Add(this.SPriceTxt);
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
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(854, 352);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 20);
            this.metroLabel8.TabIndex = 47;
            this.metroLabel8.Text = "المخزن";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(816, 298);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(86, 20);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "الكمية المتاحة";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(838, 254);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 20);
            this.metroLabel4.TabIndex = 45;
            this.metroLabel4.Text = "سعر البيع";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(833, 203);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 20);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "سعر الشراء";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(867, 156);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 20);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "النوع";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PPriceText
            // 
            this.PPriceText.Location = new System.Drawing.Point(600, 199);
            this.PPriceText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PPriceText.Name = "PPriceText";
            this.PPriceText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PPriceText.Size = new System.Drawing.Size(192, 24);
            this.PPriceText.TabIndex = 42;
            this.PPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PPriceText_KeyPress);
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
            this.IQtTxt.Location = new System.Drawing.Point(600, 348);
            this.IQtTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IQtTxt.Name = "IQtTxt";
            this.IQtTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IQtTxt.Size = new System.Drawing.Size(192, 24);
            this.IQtTxt.TabIndex = 30;
            this.IQtTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IQtTxt_KeyPress);
            // 
            // SQtTxt
            // 
            this.SQtTxt.Location = new System.Drawing.Point(600, 298);
            this.SQtTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SQtTxt.Name = "SQtTxt";
            this.SQtTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SQtTxt.Size = new System.Drawing.Size(192, 24);
            this.SQtTxt.TabIndex = 28;
            this.SQtTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SQtTxt_KeyPress);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Cashier"});
            this.metroComboBox1.Location = new System.Drawing.Point(600, 146);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(193, 30);
            this.metroComboBox1.TabIndex = 26;
            // 
            // SPriceTxt
            // 
            this.SPriceTxt.Location = new System.Drawing.Point(600, 250);
            this.SPriceTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SPriceTxt.Name = "SPriceTxt";
            this.SPriceTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SPriceTxt.Size = new System.Drawing.Size(192, 24);
            this.SPriceTxt.TabIndex = 25;
            this.SPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SPriceTxt_KeyPress);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(601, 97);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameTxt.Size = new System.Drawing.Size(192, 24);
            this.NameTxt.TabIndex = 20;
            this.NameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPress);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(833, 101);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(69, 20);
            this.metroLabel14.TabIndex = 19;
            this.metroLabel14.Text = "اسم المنتج";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(702, 403);
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
            this.TxtName.Location = new System.Drawing.Point(285, 45);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtName.Size = new System.Drawing.Size(193, 24);
            this.TxtName.TabIndex = 3;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.TxtPPrice);
            this.metroTabPage1.Controls.Add(this.TxtIQuantity);
            this.metroTabPage1.Controls.Add(this.TxtSQuantity);
            this.metroTabPage1.Controls.Add(this.CancelBtn);
            this.metroTabPage1.Controls.Add(this.Btn_Save);
            this.metroTabPage1.Controls.Add(this.ComboCat);
            this.metroTabPage1.Controls.Add(this.TxtSPrice);
            this.metroTabPage1.Controls.Add(this.TxtName);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(539, 300);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 20);
            this.metroLabel1.TabIndex = 53;
            this.metroLabel1.Text = "المخزن";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(501, 254);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 20);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = "الكمية المتاحة";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(523, 202);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 20);
            this.metroLabel7.TabIndex = 51;
            this.metroLabel7.Text = "سعر البيع";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(518, 159);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(71, 20);
            this.metroLabel9.TabIndex = 50;
            this.metroLabel9.Text = "سعر الشراء";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(552, 102);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(35, 20);
            this.metroLabel10.TabIndex = 49;
            this.metroLabel10.Text = "النوع";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(518, 45);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(69, 20);
            this.metroLabel11.TabIndex = 48;
            this.metroLabel11.Text = "اسم المنتج";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPPrice
            // 
            this.TxtPPrice.Location = new System.Drawing.Point(285, 155);
            this.TxtPPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtPPrice.Name = "TxtPPrice";
            this.TxtPPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtPPrice.Size = new System.Drawing.Size(192, 24);
            this.TxtPPrice.TabIndex = 43;
            this.TxtPPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPPrice_KeyPress);
            // 
            // TxtIQuantity
            // 
            this.TxtIQuantity.Location = new System.Drawing.Point(285, 300);
            this.TxtIQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtIQuantity.Name = "TxtIQuantity";
            this.TxtIQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtIQuantity.Size = new System.Drawing.Size(193, 24);
            this.TxtIQuantity.TabIndex = 16;
            // 
            // TxtSQuantity
            // 
            this.TxtSQuantity.Location = new System.Drawing.Point(285, 250);
            this.TxtSQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtSQuantity.Name = "TxtSQuantity";
            this.TxtSQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtSQuantity.Size = new System.Drawing.Size(193, 24);
            this.TxtSQuantity.TabIndex = 14;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 55);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(933, 647);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
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
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton DisplayBtn;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton EditBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox TxtName;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox TxtIQuantity;
        private MetroFramework.Controls.MetroTextBox TxtSQuantity;
        private MetroFramework.Controls.MetroTextBox IQtTxt;
        private MetroFramework.Controls.MetroTextBox SQtTxt;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox SPriceTxt;
        private MetroFramework.Controls.MetroTextBox NameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox MoveTxt;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton MoveBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button ResetFilterBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox PPriceText;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox TxtPPrice;
    }
}