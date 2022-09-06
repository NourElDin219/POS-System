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
        private string c;
        public Cs_Category()
        {
            db = new DatabaseContext();

        }
        public string GetCategorys(string P_Name)
        {
            var ro = from P in db.Product
                     from C in db.Category
                     where P.Category.Id==C.Id && P.Name == P_Name
                     select new
                     {
                         r = C.Name
                     };
            foreach (var obj in ro)
            {
                c = obj.r;
            }
            return c;
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
