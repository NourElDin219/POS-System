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
        public DatabaseContext() : base("Data Source=.; Integrated Security=true;Initial Catalog=POS;")
        {
            
        }
        public DbSet<Users> User { get; set; }
        public DbSet<Roles> Role { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceProduct> InvoiceProduct { get; set; }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }


}
