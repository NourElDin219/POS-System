
namespace POS_Sys
{
    partial class Password
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
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuantityText
            // 
            this.QuantityText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location = new System.Drawing.Point(133, 63);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.PasswordChar = '*';
            this.QuantityText.Size = new System.Drawing.Size(290, 30);
            this.QuantityText.TabIndex = 1;
            this.QuantityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityText_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "تم";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(133, 12);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(290, 30);
            this.UsernameTxt.TabIndex = 3;
            this.UsernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "كلمة السر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "اسم المستخدم";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuantityText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Password";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "أدخل اسم المستخدم و كلمة السر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}