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
        public int Id;
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
            using (DatabaseContext db = new DatabaseContext())
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
        public void ReadUser(string user_Text, string user_Pass)
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
        public void ReadUserS(int user_ID)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var ro = from U in db.User
                         from R in db.Role
                         where U.Role.Id == R.Id && U.Id == user_ID
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
        public void ReadUser(int userId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var ro = from U in db.User

                         where U.Id == userId
                         select new
                         {
                             n = U.Name,

                         };
                foreach (var obj in ro)
                {
                    Name = obj.n;

                }
            }
        }
        public void ReadUserT(string userId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var ro = from U in db.User

                         where U.Name == userId
                         select new
                         {
                             n = U.Name,
                             i = U.Id
                         };
                foreach (var obj in ro)
                {
                    Name = obj.n;
                    Id = obj.i;
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
                                 i = U.Id,
                                 r = R.Name
                             };
                    foreach (var obj in ro)
                    {
                        Name = obj.n;
                        Role = obj.r;
                        Id = obj.i;
                    }
                    return true;
                }
            }
            return false;
        }
        public int UpdateUser(int ID, string name, string username, string password, string role)
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
                    if (db.User.Where(x => x.UserName == username).Count() > 0 && !check)
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
            using (DatabaseContext db = new DatabaseContext())
            {
                var Users = db.User.ToList();
                return Users;
            }
        }
        public void ReadUsers()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var Users = db.User.ToList();
            }
        }
        public void AddNewLog(int userID)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var latestEntry = db.Log.Where(x => x.UserId == userID).OrderByDescending(x => x.Id).FirstOrDefault();
                if (latestEntry == null)
                {
                    db.Log.Add(new Logs() { UserId = userID, Login = DateTime.Now ,Logout= new DateTime(2019, 05, 09, 09, 15, 00)});
                    db.SaveChanges();
                }
                else
                {
                    if(latestEntry.Login.Date==DateTime.Today&&latestEntry.Logout == new DateTime(2019, 05, 09, 09, 15, 00))
                        return;
                    db.Log.Add(new Logs() { UserId = userID, Login = DateTime.Now, Logout=new DateTime(2019, 05, 09, 09, 15, 00) });
                    db.SaveChanges();
                }
                return;
                
                
            }
        }
        public void AddLogout(int userId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var latestEntry=db.Log.Where(x => x.UserId == userId).OrderByDescending(x=>x.Id).FirstOrDefault();
                if (latestEntry.Logout == new DateTime(2019, 05, 09, 09, 15, 00))
                {
                    latestEntry.Logout = DateTime.Now;
                    db.SaveChanges();
                }
            }
        }
        public List<Logs> GetLogsOfTheDay()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var List=db.Log.ToList().Where(x=>x.Login.Date>=DateTime.Today).ToList();
                return List;
            }
        }
        public List<Logs> GetLogsOfTheMonth()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var List = db.Log.ToList().Where(x => x.Login.Month == DateTime.Now.Month).ToList();
                return List;
            }
        }
    }
}
