using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.Business.Abstract
{
    public interface IBankManager
    {
        void DeleteKredi(int id);
        void SaveKredi(BankKredi bankKredi);
        void ClosedKredi(BankKredi bankKredi);
        List<BankKredi> GetKredi(string customerTc);
    }
}
