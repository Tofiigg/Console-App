using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Tip;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    class UserService : ICrudService<user>
    {
        private List<user> Users = new List<user>();

        public user Create(user model)
        {
            Users.Add(model);
            return model;
        }

        public bool Delete(int id)
        {
            user user = Users.Find(u => u.Id == id);
            if (user == null)
            {
                return false;
            }

            Users.Remove(user);
            return true;
        }

        public user Get(int id)
        {
            return Users.Find(u => u.Id == id);
        }

        public List<user> GetAll()
        {
            return Users;
        }

        public user GetById(int id)
        {
            return Search(id);
        }

        public user Update(int id, user model)
        {
            user user = Users.Find(u => u.Id == id);
            user = model;
            return model;
        }

        user ICrudService<user>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        bool ICrudService<user>.Update(int id, user model)
        {
            throw new NotImplementedException();
        }
        public user Search(int id)
        {
            foreach (user user in Users)
            {
                if (user.Id==id)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
