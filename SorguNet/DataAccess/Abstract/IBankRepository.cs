using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.DataAccess.Abstract
{
    public interface IBankRepository
    {
        void DeleteKredi(int id);
        void SaveKredi(BankKredi bankKredi);
        List<BankKredi> GetKredi(string customerTc);
    }
}
