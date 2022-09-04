using POS_Sys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.CS
{
    public class Cs_Category
    {
        public DatabaseContext db;
        public Cs_Category()
        {
            db = new DatabaseContext();
        }
        public List<Category> GetCategoryList()
        {
            var Categories = db.Category.ToList();
            return Categories;
        }
        public int GetCategoryId(string name)
        {
            var category = db.Category.Where(x=>x.Name==name).FirstOrDefault();
            return category.Id;
        }
        public Category GetCategory(string name)
        {
            var category = db.Category.Where(x => x.Name == name).FirstOrDefault();
            return category;
        }
    }
}
