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
        private int Role_ID;
        private Users user;
        public UserCrudOps()
        {
            Name = "";
            Username = "";
            Password = "";
            Role = "";
            Role_ID = 0;
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
        public int CreateUser(string name, string username, string password, string role)
        {
            
            user.Name = name;
            user.UserName = username;
            user.Password = password;
            if (role == "Admin")
            {
                Role_ID = 1;
            }
            else if (role == "Supervisor")
            {
                Role_ID = 2;
            }
            else
            {
                Role_ID = 3;
            }
            using(DatabaseContext db=new DatabaseContext())
            {
                if (db.User.Where(x => x.UserName == username).Count() == 0)
                {
                    user.Role = db.Role.FirstOrDefault(s => s.Id == Role_ID);
                    db.User.Add(user);
                    db.SaveChanges();
                    return 1;
                }
            }
            return 0;
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
        public void ReadUser(string user_Text)
        {
            using (DatabaseContext db = new DatabaseContext())
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
                        Name = obj.n;
                        Role = obj.r;
                    }
                    return true;
                }
            }
            return false;
        }
        public int UpdateUser(int ID,string name,string username,string password,string role)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var result = db.User.SingleOrDefault(b => b.Id == ID);
                if (result != null)
                {
                    bool check = false;
                    if (result.UserName == username)
                        check = true;
                    result.Name = name;
                    result.UserName = username;
                    result.Password = password;
                    if (role == "Admin")
                    {
                        Role_ID = 1;
                    }
                    else if (role == "Supervisor")
                    {
                        Role_ID = 2;
                    }
                    else
                    {
                        Role_ID = 3;
                    }
                    result.Role = db.Role.FirstOrDefault(s => s.Id == Role_ID);
                    if(db.User.Where(x=>x.UserName==username).Count()>0 && !check )
                    {
                        return 0;
                    }
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }
        }
        public void DeleteUser(int ID)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var us = new Users { Id = ID };
                db.User.Attach(us);
                db.User.Remove(us);
                db.SaveChanges();
            }
        }
        public List<Users> ReadAllUsers()
        {
            using (DatabaseContext db=new DatabaseContext()) {
                var Users = db.User.ToList();
                return Users;
            }
        }
    }
}
