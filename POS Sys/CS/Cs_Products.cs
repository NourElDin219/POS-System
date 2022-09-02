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
        public void AddOrUpdateProduct(Products product)
        {
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

    }

}
