using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.Models
{
    public class Invoice: BaseEntity
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public double TotalProfit { get; set; }
        public double Pay { get; set; }

        public double Discount { get; set; }
        public string PaymentMethod { get; set; }

        // forieng key
        [ForeignKey("User")]
        public int UserId { get; set; }
        public Users User { get; set; }


    }
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
