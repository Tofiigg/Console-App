using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Models;

namespace ConsoleApp1.Tip
{
    interface ICrudService<T>
    {
        public bool Create(T model);
        public T GetById(int id);
        public List<T> GetAll();
        public bool Update(int id, T model);
        public bool Delete(int id);
    }
}
