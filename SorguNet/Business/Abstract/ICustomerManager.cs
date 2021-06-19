using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.Business.Abstract
{
    public interface ICustomerManager
    {
        List<Customer> GetList();
        void SaveCustomer(Customer customer);
        void DeleteCustomer(string tc);
        Customer GetCustomer(string tc,int secenek=0);
        void UpdatePoint(string customerTc, int point);
    }
}
