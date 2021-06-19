using SorguNet.Business.Abstract;
using SorguNet.DataAccess.Abstract;
using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.Business.Concrete
{
    public class CustomerManager : ICustomerManager
    {
        ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetList()
        {
            List<Customer> customerList=_customerRepository.GetList();
            return customerList;
        }

        public void SaveCustomer(Customer customer)
        {
            //kredi puanı 1000 ile başlamaktadır.
            customer.KrediNot = 1000;
            _customerRepository.SaveCustomer(customer);
        }

        public void DeleteCustomer(string tc)
        {
            _customerRepository.DeleteCustomer(tc);
        }
        public Customer GetCustomer(string tc, int secenek = 0)
        {
            return _customerRepository.CustomerPoint(tc,secenek);
        }

        public void UpdatePoint(string customerTc, int point)
        {
            _customerRepository.UpdatePoint(customerTc, point);
        }
    }
}
