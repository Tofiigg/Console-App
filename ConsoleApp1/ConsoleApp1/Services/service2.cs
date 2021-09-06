using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Models;


namespace ConsoleApp1.Services
{
    class service2
    {
        static user LoggedInUser;
        private UserService userService = new UserService();
        public user Login (string email,string password)
        {
            List<user> users = userService.GetAll();
            foreach (user user in users)
            {
                if (user.Email==email&&user.Password==password)
                {
                    LoggedInUser = user;
                    return user;
                }
            }
            return null;
        }
        public user Register(user _user)
        {
            return userService.Create(_user);
        }
    }
}
