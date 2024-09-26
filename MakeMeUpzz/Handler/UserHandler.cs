using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Repository;

namespace MakeMeUpzz.Handler
{
    public class UserHandler
    {
        private readonly UserRepository _userRep;
        public UserHandler()
        {
            _userRep = new UserRepository();
        }

        public static string register(string username, string email, DateTime DOB, string gender, string password)
        {
            UserRepository repo = new UserRepository();
            UserFactory factory = new UserFactory();
            User user = factory.createUser(repo.AutomateUserID(), username, email, DOB, gender,"customer", password);
            repo.insertUser(user);
            return "success";
        }

        public static string login(string username, string password) 
        {
            UserRepository repo = new UserRepository();

            User user = repo.login(username, password);

            if (user == null)
            {
                return "user not found";
            }
            else
            {
                return "success";
            }
        }

        public static List<User> getCustomers()
        {
            UserRepository repo = new UserRepository();

            return repo.getCustomers(); 
        }

        public static string updateProfile(int id, string username, string email, DateTime DOB, string gender) 
        {
            UserRepository repo = new UserRepository();
            repo.updateUser(id, username, email, DOB, gender);
            return "success";
        }

        public static string updatePassword(string username, string oldpassword, string newpassword)
        {
            UserRepository repo = new UserRepository();
            User user = repo.login(username, oldpassword);
            if(user == null) 
            {
                return "old password is wrong, please check again";
            }
            else
            {
                repo.updatePassword(user.UserID, newpassword);
                return "success";
            }
        }

        public User findbyId(int id)
        {
            return _userRep.fromID(id);
        }
    }
}