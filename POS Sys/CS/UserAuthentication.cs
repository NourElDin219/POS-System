using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Sys.Models;
namespace POS_Sys.CS
{
    public class UserAuthentication
    {
        private string name;
        private string role;
        public UserAuthentication()
        {
            name = "";
            role = "";
        }
        public string getName()
        {
            return name;
        }
        public string getRole()
        {
            return role;
        }
        public bool Authorized(string user_Text, string user_Pass)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                if (db.User.Where(x => x.UserName == user_Text && x.Password == user_Pass).Count() > 0)
                {
                    var ro = from U in db.User
                             from R in db.Role
                             where U.Role.Id == R.Id && U.UserName == user_Text
                             select new
                             {
                                 n = U.Name,
                                 r = R.Name
                             };
                    foreach (var obj in ro)
                    {
                        name = obj.n;
                        role = obj.r;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
