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
    public class IcraManager : IIcraManager
    {
        IIcraRepository _bankRepository;
        public IcraManager(IIcraRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }
        public void DeleteIcra(int id)
        {
            _bankRepository.DeleteIcra(id);
        }
        public void SaveIcra(Icra icra)
        {
            icra.AçılmaTarihi = DateTime.Now;
            icra.Status = 1;
            _bankRepository.SaveIcra(icra);
        }

        public void ClosedIcra(Icra icra)
        {
            icra.Status = 0;
            icra.KapanmaTarihi = DateTime.Now;
            _bankRepository.SaveIcra(icra);
        }

        public List<Icra> GetIcra(string customerTc)
        {
           return  _bankRepository.GetIcra(customerTc);
        }
    }
}
