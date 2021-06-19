using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.Business.Abstract
{
    public interface IIcraManager
    {
        void DeleteIcra(int id);
        void SaveIcra(Icra icra);
        void ClosedIcra(Icra icra);
        List<Icra> GetIcra(string customerTc);
    }
}
