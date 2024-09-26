using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using System.Data.Entity.Migrations.Model;

namespace MakeMeUpzz.Repository
{
    public class UserRepository
    {
        Database1Entities db = new Database1Entities();
        UserFactory ufac = new UserFactory();

        public int AutomateUserID()
        {
            if(getUsers().Count == 0)
            {
                return 1;
            }
            else
            {
                return getLast().UserID + 1 ;
            }
        }
        public List<User> getUsers()
        {
            return ( from u in db.Users select u).ToList();
        }

        public User fromID (int id)
        {
            return (from u in db.Users where u.UserID == id select u).FirstOrDefault();
        }

        public User getLast()
        {
            return getUsers().LastOrDefault();
        }

        public User getUserByName (string username) 
        {
            return (from u in db.Users where u.Username == username select u).FirstOrDefault();
        }

        public User login(string username, string password)
        {
            return (from u in db.Users where u.Username == username && u.UserPassword == password select u).FirstOrDefault();
        }

        public List<User> getCustomers () 
        {
            return (from u in db.Users where u.UserRole.Equals("customer") select u).ToList();
        }

        public void insertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void updateUser(int id, string username, string email, DateTime date, string gender)
        {
            User update = db.Users.Find(id);
            update.Username = username;
            update.UserEmail = email;
            update.UserDOB = date;
            update.UserGender = gender;
            db.SaveChanges();
        }

        public void updatePassword(int id, string password)
        {
            User update = db.Users.Find(id);
            update.UserPassword = password;
            db.SaveChanges();
        }
    }
}