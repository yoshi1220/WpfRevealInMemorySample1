using Dapper;
using InputControlSample.Data.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace InputControlSample.Repositories
{
    public class CustomerRepositoryDapper : ICustomerRepository
    {
        private string _connectionString;

        public CustomerRepositoryDapper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(string id)
        {
            using (IDbConnection db = new SQLiteConnection("Data Source=" + _connectionString))
            {
                db.Open();
                var customers = db.Query<Customer>("SELECT * FROM Customer WHERE ID = '" + id + "' ", commandType: CommandType.Text);

                if (customers.Count() != 0)
                {
                    return customers.First();
                }

                return null;
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using (IDbConnection db = new SQLiteConnection("Data Source=" + _connectionString))
            {
                db.Open();
                return db.Query<Customer>("SELECT * FROM Customer", commandType: CommandType.Text);
            }
        }

        public void Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }


        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
