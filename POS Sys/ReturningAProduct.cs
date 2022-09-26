using POS_Sys.CS;
using POS_Sys.Models;
using POS_Sys.CS;
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
    public partial class ReturningAProduct : Form
    {
        private DatabaseContext db;
        private CS_Invoice CS_Invoice;
        private List<Products> products;
        private Cs_Products cs_Products;
        private List<int> InvoiceProductIds;
        private double newTotal;
        private Products product;
        public ReturningAProduct()
        {
            InitializeComponent();
            CS_Invoice = new CS_Invoice();
            products = new List<Products>();
            cs_Products = new Cs_Products();
            InvoiceProductIds = new List<int>();
            product = new Products();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CS_Invoice.GetInvoice(Convert.ToInt32(textBox1.Text)) != null)
            {
                if (textBox1.Text != "")
                {
                    RemoveAll();
                    MessageBox.Show("تم مسح الفاتورة بنجاح");
                }
            }
            else
            {
                MessageBox.Show("لا توجد فاتورة بهذا الرقم");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            products.Clear();
            InvoiceProductIds.Clear();
            int k = Convert.ToInt32(textBox1.Text);
            using (db = new DatabaseContext())
            {
                if (db.InvoiceProduct.Where(x => x.InvoiceId == k).Count() > 0)
                {
                    var ro = from IP in db.InvoiceProduct
                             from P in db.Product
                             where IP.InvoiceId == k && P.Id == IP.ProductId
                             select new
                             {
                                 ProductName = P.Name,
                                 UnitPrice = P.SellingPrice,
                                 Quantity = IP.Quantity,
                                 ProductId = P.Id,
                                 PPrice = P.PurchasingPrice,
                                 SPrice = P.SellingPrice,
                                 CatId = P.CategoryId,
                                 ShopQty = P.ShopQuantity,
                                 InvQty = P.InvQuantity,
                                 InvoiceProductID = IP.Id
                             };
                    dataGridView1.Rows.Clear();
                    int i = 0;
                    foreach (var obj in ro)
                    {
                        product.Id = obj.ProductId;
                        product.Name = obj.ProductName;
                        product.PurchasingPrice = obj.PPrice;
                        product.SellingPrice = obj.SPrice;
                        product.CategoryId = obj.CatId;
                        product.InvQuantity = obj.InvQty;
                        product.ShopQuantity = obj.ShopQty + obj.Quantity;
                        products.Add(product);
                        InvoiceProductIds.Add(obj.InvoiceProductID);
                        dataGridView1.Rows.Add(++i, obj.ProductName, obj.UnitPrice, obj.Quantity, Convert.ToDouble((obj.UnitPrice) * (obj.Quantity)));
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String CName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (CName == "Remove")
            {
                cs_Products.AddOrUpdateProduct(products[e.RowIndex]);
                CS_Invoice.EditInvoiceProduct(InvoiceProductIds[e.RowIndex]);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                if (dataGridView1.Rows.Count == 0)
                {
                    CS_Invoice.RemoveInvoice(Convert.ToInt32(textBox1.Text));
                }
                else
                {
                    newTotal = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        newTotal += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    }
                    CS_Invoice.UpdateInvoice(Convert.ToInt32(textBox1.Text), newTotal);
                }
            }
        }
        public void RemoveAll()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cs_Products.AddOrUpdateProduct(products[i]);
                dataGridView1.Rows.RemoveAt(i);
            }
            CS_Invoice.Deleteinvoice(Convert.ToInt32(textBox1.Text));
        }
    }
}
