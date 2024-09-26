using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Model;

namespace MakeMeUpzz.Factory
{
    public class UserFactory
    {
        public User createUser(int id, string username, string email, DateTime date, string gender, string role, string password)
        {
            User user = new User();
            user.UserID = id;
            user.Username = username;
            user.UserEmail = email;
            user.UserDOB = date;
            user.UserGender = gender;
            user.UserRole = role;
            user.UserPassword = password;

            return user; 
        }
    }
}