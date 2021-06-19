using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.DataAccess.Abstract
{
    public interface ICustomerRepository
    {
        void SaveCustomer(Customer customer);
        void DeleteCustomer(string customerTc);
        List<Customer> GetList();
        Customer CustomerPoint(string customerTc,int secenek=0);
        void UpdatePoint(string customerTc, int point);
    }
}
