using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.Models
{
    public class AdvancePayment
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public Users User { get; set; }
        public double Amount { get; set; }
    }
}
