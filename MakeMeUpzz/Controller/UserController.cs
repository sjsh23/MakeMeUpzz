using MakeMeUpzz.Repository;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations.Model;

namespace MakeMeUpzz.Controller
{
    public class UserController
    {
        
        public static string register(string username, string email, DateTime DOB, string gender, string password, string confirmation)
        {
            UserRepository repo = new UserRepository();

            if (username == null || username.Length == 0)
            {
                return "please input username";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                return "username must be between 5 and 15 alphabet long";

            }
            else if (repo.getUserByName(username) != null)
            {
                return "username already taken, please change";
            }

            else if (email == null || email.Length == 0)
            {
                return "please input email";

            }
            else if (!email.EndsWith(".com"))
            {
                return "email must ends with '.com'";

            }
            else if (gender == "")
            {
                return "please choose a gender";
            }
            else if (password == null || password.Length == 0)
            {
                return "please input password";

            }
            else if (!password.All(char.IsLetterOrDigit))
            {
                return "password must be alphanumeric";

            }
            else if (confirmation == null || confirmation.Length == 0)
            {
                return "please input confirmation password";
            }
            else if (!confirmation.Equals(password))
            {
                return "confirmation password must be the same with password";
            }
            else if (DOB == DateTime.MinValue)
            {
                return "please choose a DOB";
            }
            else
            {
                return UserHandler.register(username, email, DOB, gender, password);
            }
        }

        public static string login(string username, string password)
        {
            if (username == null || username.Length == 0)
            {
                return "username must be filled";
                
            }
            else if (password == null || username.Length == 0)
            {
                return "password must be filled";
                
            }
            else
            {
                return UserHandler.login(username, password);
            }
        }

        public static List<User> getCustomer()
        {
            return UserHandler.getCustomers();
        }

        public static User GetUserById(int id)
        {
            UserHandler userHandler = new UserHandler();
            return userHandler.findbyId(id);
        }

        public static string updateProfile(int id, string username, string email, DateTime DOB, string gender)
        {
            UserRepository repo = new UserRepository();
            if (username == null || username.Length == 0)
            {
                return "please input username";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                return "username must be between 5 and 15 alphabet long";

            }
            else if (repo.getUserByName(username) != null)
            {
                return "username already taken, please change";
            }

            else if (email == null || email.Length == 0)
            {
                return "please input email";

            }
            else if (!email.EndsWith(".com"))
            {
                return "email must ends with '.com'";

            }
            else if (gender == "")
            {
                return "please choose a gender";
            }
            else if (DOB == DateTime.MinValue)
            {
                return "please choose a DOB";
            }
            else
            {
                return UserHandler.updateProfile(id, username, email, DOB, gender);
            }
        }

        public static string updatePassword(string username, string oldpassword, string newpassword, string confirmation)
        {
            if(oldpassword == null || oldpassword.Length == 0)
            {
                return "please input old password";
            }
            else if (newpassword == null || newpassword.Length == 0)
            {
                return "please input new password";
            }
            else if (confirmation == null || confirmation.Length == 0)
            {
                return "please input confirmation password";
            }
            else if (newpassword.Equals(oldpassword))
            {
                return "old password and new password must be different";
            }
            else if (!confirmation.Equals(newpassword))
            {
                return "confirmation password must be the same with new password";
            }
            else
            {
                return UserHandler.updatePassword(username, oldpassword, newpassword);
            }

        }
    }
}