using POS_Sys.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.CS
{
    public class Cs_Products
    {
        public DatabaseContext db;
        public Cs_Products()
        {
            db = new DatabaseContext();
        }
        public Products GetProduct(int productId)
        {
            var product=db.Product.Find(productId);
            return product;
        }
        public void AddOrUpdateProduct(Products product)
        {
            product.Category=db.Category.FirstOrDefault(s => s.Id == product.Category.Id);
            db.Product.AddOrUpdate(product);
            db.SaveChanges();
        }

        public void DeleteProduct(int ProductId)
        {
            var Product = db.Product.Find(ProductId);
            db.Product.Remove(Product);
            db.SaveChanges();
        }
        public List<Products> GetProducts()
        {
            var Products = db.Product.ToList();
            return Products;
        }
        public bool Exists(string product_Name)
        {
            if (db.Product.Any(o => o.Name == product_Name)) return true;
            else
                return false;
        }
    }

}
