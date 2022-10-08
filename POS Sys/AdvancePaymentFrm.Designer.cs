
namespace POS_Sys
{
    partial class AdvancePaymentFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.UsersDgv = new System.Windows.Forms.DataGridView();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_Name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.EditBtn = new MetroFramework.Controls.MetroButton();
            this.APDgv = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1032, 68);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "المسحوبات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 68);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1032, 685);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.UsersDgv);
            this.metroTabPage2.Controls.Add(this.metroTextBox1);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.txt_Name);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.DeleteBtn);
            this.metroTabPage2.Controls.Add(this.EditBtn);
            this.metroTabPage2.Controls.Add(this.APDgv);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1024, 642);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "عرض و اضافة المسحوبات";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // UsersDgv
            // 
            this.UsersDgv.AllowUserToAddRows = false;
            this.UsersDgv.AllowUserToDeleteRows = false;
            this.UsersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDgv.BackgroundColor = System.Drawing.Color.White;
            this.UsersDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDgv.GridColor = System.Drawing.Color.White;
            this.UsersDgv.Location = new System.Drawing.Point(521, 3);
            this.UsersDgv.MultiSelect = false;
            this.UsersDgv.Name = "UsersDgv";
            this.UsersDgv.ReadOnly = true;
            this.UsersDgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UsersDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersDgv.RowHeadersVisible = false;
            this.UsersDgv.RowHeadersWidth = 51;
            this.UsersDgv.RowTemplate.Height = 24;
            this.UsersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDgv.Size = new System.Drawing.Size(503, 577);
            this.UsersDgv.TabIndex = 20;
            this.UsersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDgv_CellContentClick);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(227, 598);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(220, 23);
            this.metroTextBox1.TabIndex = 19;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(453, 601);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 20);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "المبلغ المقترض";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(567, 598);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Name.Size = new System.Drawing.Size(220, 23);
            this.txt_Name.TabIndex = 17;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(793, 601);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 20);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "الاسم";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(5, 582);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(132, 60);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "ازالة المبلغ المقترض";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(884, 582);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(132, 60);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "اضافة ";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // APDgv
            // 
            this.APDgv.AllowUserToAddRows = false;
            this.APDgv.AllowUserToDeleteRows = false;
            this.APDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.APDgv.BackgroundColor = System.Drawing.Color.White;
            this.APDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.APDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.APDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.APDgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.APDgv.GridColor = System.Drawing.Color.White;
            this.APDgv.Location = new System.Drawing.Point(0, 3);
            this.APDgv.MultiSelect = false;
            this.APDgv.Name = "APDgv";
            this.APDgv.ReadOnly = true;
            this.APDgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.APDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.APDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.APDgv.RowHeadersVisible = false;
            this.APDgv.RowHeadersWidth = 51;
            this.APDgv.RowTemplate.Height = 24;
            this.APDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.APDgv.Size = new System.Drawing.Size(515, 577);
            this.APDgv.TabIndex = 2;
            this.APDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.APDgv_CellContentClick);
            // 
            // AdvancePaymentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 753);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancePaymentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdvancePaymentFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdvancePaymentFrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox txt_Name;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton EditBtn;
        private System.Windows.Forms.DataGridView APDgv;
        private System.Windows.Forms.DataGridView UsersDgv;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}