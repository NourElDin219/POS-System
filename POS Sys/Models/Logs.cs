using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.Models
{
    public class Logs
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public Users User { get; set; }
        public DateTime Login { get; set; }
        public DateTime Logout { get; set; }
    }
}
