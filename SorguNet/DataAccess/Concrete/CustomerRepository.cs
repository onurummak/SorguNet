using SorguNet.DataAccess.Abstract;
using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.DataAccess.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {

        public void SaveCustomer(Customer customer)
        {
            using (var context = new SorguNetDbContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void DeleteCustomer(string customerTc)
        {
            using (var context = new SorguNetDbContext())
            {
                Customer customer = context.Customers.FirstOrDefault(x => x.TC == customerTc);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
        public void UpdatePoint(string customerTc,int point)
        {
            using (var context = new SorguNetDbContext())
            {
                Customer customer = context.Customers.FirstOrDefault(x => x.TC == customerTc);
                customer.KrediNot += point;
                context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public List<Customer> GetList()
        {
            List<Customer> customerList = new List<Customer>();

            using (var context = new SorguNetDbContext())
            {
                //istenirse müşteri filtremele yapılabilir.
                customerList = context.Customers.Where(x => 1 == 1).OrderBy(x => x.AdSoyad).ToList();
            }
            return customerList;
        }

        public Customer CustomerPoint(string customerTc, int secenek = 0)
        {
            Customer customer = null;
            using (var context = new SorguNetDbContext())
            {
                if(secenek==1)
                {
                    customer = context.Customers.FirstOrDefault(x => x.TC == customerTc);
                }else if (secenek == 2)
                {
                    customer = context.Customers.FirstOrDefault(x => x.Telefon == customerTc);
                }
                else { 
                customer = context.Customers.FirstOrDefault(x => x.TC == customerTc || x.Telefon == customerTc);
                }
            }
            return customer;
        }

    }
}
