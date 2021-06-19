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
    public class IcraRepository : IIcraRepository
    {
        public void DeleteIcra(int id)
        {
            using (var context = new SorguNetDbContext())
            {
                Icra icra = context.Icras.FirstOrDefault(x => x.Id == id);
                context.Icras.Remove(icra);
                context.SaveChanges();
            }
        }
        public void SaveIcra(Icra icra)
        {
            using (var context = new SorguNetDbContext())
            {
                if (icra.Id != 0)
                {
                    context.Entry(icra).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                else { 
                context.Icras.Add(icra);
                context.SaveChanges();
                }
            }
        }


        public List<Icra> GetIcra(string customerTc)
        {
            List<Icra> result = null;
            using (var context = new SorguNetDbContext())
            {
                result=context.Icras.Include(x=>x.Customer).Where(x => x.CustomerTC == customerTc).ToList();
            }
            return result;
        }
    }
}
