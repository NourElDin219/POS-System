using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Sys.Models
{
    
        public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

    }

}
