using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Sys
{
    public partial class Qform : Form
    {
        public Qform()
        {
            InitializeComponent();
        }
        public int GetQuantity()
        {
            return Convert.ToInt32(QuantityText.Text);
        }
        public void dispose()
        {
            this.Dispose();
        }

        private void Qform_Load(object sender, EventArgs e)
        {

        }

        private void QuantityText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QuantityText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void QuantityText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
