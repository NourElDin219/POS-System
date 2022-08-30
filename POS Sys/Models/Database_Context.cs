using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace POS_Sys.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=DESKTOP-6D2T5N4; Integrated Security=true;Initial Catalog=POS;")
        {

        }
        public DbSet<Users> User { get; set; }
        public DbSet<Roles> Role { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Category> Category { get; set; }

    }

}
