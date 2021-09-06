using ConsoleApp1.Models;
using ConsoleApp1.Tip;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    class Customer_Service : ICrudService<Customer>
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer("Ilham Eliyev", 123321, 123321)
        };
        public bool Create(Customer model)
        {
            customers.Add(model);
            return true;
        }

        public bool Delete(int id)
        {
            Customer c = customers.Find(c => c.ID == id);
            customers.Remove(c);
            return true;
        }

        public List<Customer> GetAll()
        {
            return customers;
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Customer model)
        {
            throw new NotImplementedException();
        }
    }
}
