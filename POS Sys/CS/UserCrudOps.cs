using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Sys.Models;
namespace POS_Sys.CS
{
    public class UserCrudOps
    {
        private string Name;
        private string Username;
        private string Password;
        private string Role;
        private Users user;
        public UserCrudOps()
        {
            Name = "";
            Username = "";
            Password = "";
            Role = "";
            user = new Users();
        }

        public string getName()
        {
            return Name;
        }
        public string getUsername()
        {
            return Username;
        }
        public string getPassword()
        {
            return Password;
        }
        public string getRole()
        {
            return Role;
        }
        public void setName(string v)
        {
            Name = v;
        }
        public void setUsername(string v)
        {
            Username = v;
        }
        public void setPassword(string v)
        {
            Password = v;
        }
        public void setRole(string v)
        {
            Role = v;
        }
        public void CreateUser(string name, string username, string password, string role)
        {
            user.Name = name;
            user.UserName = username;
            user.Password = password;
        }
        public void ReadUser(string user_Text,string user_Pass)
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
                        Name = obj.n;
                        Role = obj.r;
                    }
                }
            }
        }
        public void UpdateUser(int ID)
        {

        }
        public void DeleteUser(int ID)
        {

        }
    }
}
