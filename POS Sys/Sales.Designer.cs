
namespace POS_Sys
{
    partial class Sales
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DiscountL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalAmountL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TransactionL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NTransaction = new System.Windows.Forms.Button();
            this.CashierLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalPText = new System.Windows.Forms.TextBox();
            this.UnitPText = new System.Windows.Forms.TextBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.PNameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DiscountBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.TimeL = new System.Windows.Forms.Label();
            this.DateL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Controls.Add(this.DateL);
            this.panel1.Controls.Add(this.TimeL);
            this.panel1.Controls.Add(this.PaymentBtn);
            this.panel1.Controls.Add(this.DiscountBtn);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.ReturnBtn);
            this.panel1.Controls.Add(this.DiscountL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TotalAmountL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.NTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(395, 800);
            this.panel1.TabIndex = 6;
            // 
            // DiscountL
            // 
            this.DiscountL.ForeColor = System.Drawing.Color.White;
            this.DiscountL.Location = new System.Drawing.Point(47, 117);
            this.DiscountL.Name = "DiscountL";
            this.DiscountL.Size = new System.Drawing.Size(94, 32);
            this.DiscountL.TabIndex = 13;
            this.DiscountL.Text = "0000000000";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(292, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "الخصم";
            // 
            // TotalAmountL
            // 
            this.TotalAmountL.ForeColor = System.Drawing.Color.White;
            this.TotalAmountL.Location = new System.Drawing.Point(47, 50);
            this.TotalAmountL.Name = "TotalAmountL";
            this.TotalAmountL.Size = new System.Drawing.Size(94, 32);
            this.TotalAmountL.TabIndex = 11;
            this.TotalAmountL.Text = "0000000000";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(254, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "المبلغ الكلى";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TransactionL);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 113);
            this.panel4.TabIndex = 9;
            // 
            // TransactionL
            // 
            this.TransactionL.ForeColor = System.Drawing.Color.White;
            this.TransactionL.Location = new System.Drawing.Point(145, 63);
            this.TransactionL.Name = "TransactionL";
            this.TransactionL.Size = new System.Drawing.Size(94, 32);
            this.TransactionL.TabIndex = 1;
            this.TransactionL.Text = "0000000000";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم العملية";
            // 
            // NTransaction
            // 
            this.NTransaction.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.NTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.NTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NTransaction.ForeColor = System.Drawing.Color.White;
            this.NTransaction.Location = new System.Drawing.Point(12, 360);
            this.NTransaction.Name = "NTransaction";
            this.NTransaction.Size = new System.Drawing.Size(366, 45);
            this.NTransaction.TabIndex = 4;
            this.NTransaction.Text = "عملية شراء جديدة";
            this.NTransaction.UseVisualStyleBackColor = false;
            // 
            // CashierLabel
            // 
            this.CashierLabel.ForeColor = System.Drawing.Color.White;
            this.CashierLabel.Location = new System.Drawing.Point(810, 10);
            this.CashierLabel.Name = "CashierLabel";
            this.CashierLabel.Size = new System.Drawing.Size(229, 23);
            this.CashierLabel.TabIndex = 2;
            this.CashierLabel.Text = "Cashier Name";
            this.CashierLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.CashierLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(395, 758);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 42);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TotalPText);
            this.panel3.Controls.Add(this.UnitPText);
            this.panel3.Controls.Add(this.QuantityTxt);
            this.panel3.Controls.Add(this.PNameTxt);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(395, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 213);
            this.panel3.TabIndex = 8;
            // 
            // TotalPText
            // 
            this.TotalPText.Location = new System.Drawing.Point(22, 105);
            this.TotalPText.Name = "TotalPText";
            this.TotalPText.Size = new System.Drawing.Size(347, 30);
            this.TotalPText.TabIndex = 18;
            // 
            // UnitPText
            // 
            this.UnitPText.Location = new System.Drawing.Point(22, 27);
            this.UnitPText.Name = "UnitPText";
            this.UnitPText.Size = new System.Drawing.Size(347, 30);
            this.UnitPText.TabIndex = 17;
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(554, 105);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(347, 30);
            this.QuantityTxt.TabIndex = 16;
            this.QuantityTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PNameTxt
            // 
            this.PNameTxt.Location = new System.Drawing.Point(554, 27);
            this.PNameTxt.Name = "PNameTxt";
            this.PNameTxt.Size = new System.Drawing.Size(347, 30);
            this.PNameTxt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(388, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "المبلغ الكلى";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(388, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "سعر القطعة";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(954, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "الكمية";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(922, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "اسم المنتج";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.UnitP,
            this.Quantity,
            this.Discount,
            this.SubTotal,
            this.Remove});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(395, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 545);
            this.dataGridView1.TabIndex = 9;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ReturnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnBtn.ForeColor = System.Drawing.Color.White;
            this.ReturnBtn.Location = new System.Drawing.Point(14, 637);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(366, 45);
            this.ReturnBtn.TabIndex = 14;
            this.ReturnBtn.Text = "ارجاع منتج";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(12, 429);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(366, 45);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "البحث عن منتج";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // DiscountBtn
            // 
            this.DiscountBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.DiscountBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DiscountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiscountBtn.ForeColor = System.Drawing.Color.White;
            this.DiscountBtn.Location = new System.Drawing.Point(14, 500);
            this.DiscountBtn.Name = "DiscountBtn";
            this.DiscountBtn.Size = new System.Drawing.Size(366, 45);
            this.DiscountBtn.TabIndex = 16;
            this.DiscountBtn.Text = "اضافة خصم";
            this.DiscountBtn.UseVisualStyleBackColor = false;
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.PaymentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaymentBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentBtn.Location = new System.Drawing.Point(14, 569);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(366, 45);
            this.PaymentBtn.TabIndex = 17;
            this.PaymentBtn.Text = "دفع";
            this.PaymentBtn.UseVisualStyleBackColor = false;
            // 
            // TimeL
            // 
            this.TimeL.ForeColor = System.Drawing.Color.White;
            this.TimeL.Location = new System.Drawing.Point(10, 768);
            this.TimeL.Name = "TimeL";
            this.TimeL.Size = new System.Drawing.Size(161, 23);
            this.TimeL.TabIndex = 3;
            this.TimeL.Text = "Time";
            this.TimeL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateL
            // 
            this.DateL.ForeColor = System.Drawing.Color.White;
            this.DateL.Location = new System.Drawing.Point(234, 768);
            this.DateL.Name = "DateL";
            this.DateL.Size = new System.Drawing.Size(161, 23);
            this.DateL.TabIndex = 18;
            this.DateL.Text = "Date";
            this.DateL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(14, 713);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(366, 45);
            this.LogoutBtn.TabIndex = 19;
            this.LogoutBtn.Text = "تسجيل الخروج";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "#";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 49;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "اسم المنتج";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // UnitP
            // 
            this.UnitP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitP.HeaderText = "سعر القطعة";
            this.UnitP.MinimumWidth = 6;
            this.UnitP.Name = "UnitP";
            this.UnitP.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.HeaderText = "الخصم";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.HeaderText = "السعر الكلى";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Remove.HeaderText = "";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Width = 6;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 800);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CashierLabel;
        private System.Windows.Forms.Button NTransaction;
        private System.Windows.Forms.Label DiscountL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalAmountL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TransactionL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TotalPText;
        private System.Windows.Forms.TextBox UnitPText;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.TextBox PNameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button DiscountBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label DateL;
        private System.Windows.Forms.Label TimeL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
    }
}