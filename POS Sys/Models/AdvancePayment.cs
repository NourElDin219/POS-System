using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.Models
{
    public class AdvancePayment:BaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }

    }
}
