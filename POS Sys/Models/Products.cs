using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PurchasingPrice { get; set; }
        public double SellingPrice { get; set; }
        
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ShopQuantity { get; set; }
        public int InvQuantity { get; set; }





    }

}
