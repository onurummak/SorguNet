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
    public class BankManager : IBankManager
    {
        IBankRepository _bankRepository;
        public BankManager(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }
        public void DeleteKredi(int id)
        {
            _bankRepository.DeleteKredi(id);
        }
        public void SaveKredi(BankKredi bankKredi)
        {
            bankKredi.Status = 1;
            _bankRepository.SaveKredi(bankKredi);
        }

        public void ClosedKredi(BankKredi bankKredi)
        {
            bankKredi.Status = 0;
            _bankRepository.SaveKredi(bankKredi);
        }

        public List<BankKredi> GetKredi(string customerTc)
        {
           return  _bankRepository.GetKredi(customerTc);
        }
    }
}
