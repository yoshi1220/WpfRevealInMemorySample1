using InputControlSample.Data.Models;
using InputControlSample.Repositories;
using System;
using System.Collections.Generic;

namespace InputControlSample.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;

        public CustomerService(ICustomerRepository CustomerRepository)
        {
            _CustomerRepository = CustomerRepository;
        }

        public void Add(Customer entity)
        {
            _CustomerRepository.Add(entity);
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(string id)
        {
            return _CustomerRepository.Get(id);
        }

        /// <summary>
        /// ユーザーデータを全件取得
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAll()
        {
            return _CustomerRepository.GetAll();
        }

        public void Remove(int id)
        {
            _CustomerRepository.Remove(id);
        }

        public void Update(Customer entity, int id)
        {
            _CustomerRepository.Update(entity, id);
        }

    }
}
