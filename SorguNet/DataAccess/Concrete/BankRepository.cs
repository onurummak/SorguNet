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
    public class BankRepository : IBankRepository
    {
        public void DeleteKredi(int id)
        {
            using (var context = new SorguNetDbContext())
            {
                BankKredi bankKredi = context.BankKredis.FirstOrDefault(x => x.Id == id);
                context.BankKredis.Remove(bankKredi);
                context.SaveChanges();
            }
        }
        public void SaveKredi(BankKredi bankKredi)
        {
            using (var context = new SorguNetDbContext())
            {
                if (bankKredi.Id != 0)
                {
                    context.Entry(bankKredi).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                else { 
                context.BankKredis.Add(bankKredi);
                context.SaveChanges();
                }
            }
        }


        public List<BankKredi> GetKredi(string customerTc)
        {
            List<BankKredi> result = null;
            using (var context = new SorguNetDbContext())
            {
                result=context.BankKredis.Include(x=>x.Customer).Where(x => x.CustomerTC == customerTc).ToList();
            }
            return result;
        }
    }
}
