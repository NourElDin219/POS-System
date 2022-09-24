
namespace POS_Sys
{
    partial class Qform
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
            this.SuspendLayout();
            // 
            // QuantityText
            // 
            this.QuantityText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityText.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location = new System.Drawing.Point(0, 0);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(353, 87);
            this.QuantityText.TabIndex = 0;
            this.QuantityText.Text = "1";
            this.QuantityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            this.QuantityText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityText_KeyDown);
            this.QuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityText_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "تم";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Qform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 121);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuantityText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Qform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الكمية";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Qform_FormClosing);
            this.Load += new System.EventHandler(this.Qform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Button button1;
    }
}