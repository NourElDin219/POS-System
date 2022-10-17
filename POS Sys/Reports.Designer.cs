
namespace POS_Sys
{
    partial class Reports
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
            this.InvoiceDGV = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DisplayDayBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceDGV
            // 
            this.InvoiceDGV.AllowUserToAddRows = false;
            this.InvoiceDGV.AllowUserToDeleteRows = false;
            this.InvoiceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceDGV.BackgroundColor = System.Drawing.Color.White;
            this.InvoiceDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoiceDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.InvoiceDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InvoiceDGV.GridColor = System.Drawing.Color.White;
            this.InvoiceDGV.Location = new System.Drawing.Point(0, 84);
            this.InvoiceDGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InvoiceDGV.MultiSelect = false;
            this.InvoiceDGV.Name = "InvoiceDGV";
            this.InvoiceDGV.ReadOnly = true;
            this.InvoiceDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InvoiceDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceDGV.RowHeadersVisible = false;
            this.InvoiceDGV.RowHeadersWidth = 51;
            this.InvoiceDGV.RowTemplate.Height = 24;
            this.InvoiceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceDGV.Size = new System.Drawing.Size(1015, 622);
            this.InvoiceDGV.TabIndex = 4;
            this.InvoiceDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceDGV_CellContentClick);
            this.InvoiceDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceDGV_CellDoubleClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(588, 6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchBtn.Size = new System.Drawing.Size(75, 32);
            this.SearchBtn.TabIndex = 16;
            this.SearchBtn.Text = "عرض";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(669, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(231, 30);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 30);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // DisplayDayBtn
            // 
            this.DisplayDayBtn.Location = new System.Drawing.Point(12, 10);
            this.DisplayDayBtn.Name = "DisplayDayBtn";
            this.DisplayDayBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DisplayDayBtn.Size = new System.Drawing.Size(125, 32);
            this.DisplayDayBtn.TabIndex = 18;
            this.DisplayDayBtn.Text = "عرض";
            this.DisplayDayBtn.UseVisualStyleBackColor = true;
            this.DisplayDayBtn.Click += new System.EventHandler(this.DisplayDayBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(803, 46);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(196, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "عرض اخر 20 فاتورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1015, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisplayDayBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InvoiceDGV);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InvoiceDGV;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button DisplayDayBtn;
        private System.Windows.Forms.Button button1;
    }
}