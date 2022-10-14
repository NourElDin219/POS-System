
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersDgv = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Reason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).BeginInit();
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
            this.UsersDgv.Location = new System.Drawing.Point(0, 69);
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
            this.UsersDgv.Size = new System.Drawing.Size(1032, 572);
            this.UsersDgv.TabIndex = 21;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(33, 657);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddBtn.Size = new System.Drawing.Size(89, 33);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(951, 662);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "الاسم";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(813, 659);
            this.text_Name.Name = "text_Name";
            this.text_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_Name.Size = new System.Drawing.Size(132, 30);
            this.text_Name.TabIndex = 24;
            this.text_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_Amount
            // 
            this.text_Amount.Location = new System.Drawing.Point(623, 659);
            this.text_Amount.Name = "text_Amount";
            this.text_Amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_Amount.Size = new System.Drawing.Size(126, 30);
            this.text_Amount.TabIndex = 26;
            this.text_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Amount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 662);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "المبلغ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_Reason
            // 
            this.text_Reason.Location = new System.Drawing.Point(143, 659);
            this.text_Reason.Name = "text_Reason";
            this.text_Reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_Reason.Size = new System.Drawing.Size(412, 30);
            this.text_Reason.TabIndex = 28;
            this.text_Reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 662);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "السبب";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(33, 708);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RemoveBtn.Size = new System.Drawing.Size(89, 33);
            this.RemoveBtn.TabIndex = 29;
            this.RemoveBtn.Text = "ازالة";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AdvancePaymentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 753);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.text_Reason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.UsersDgv);
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
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UsersDgv;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Reason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveBtn;
    }
}