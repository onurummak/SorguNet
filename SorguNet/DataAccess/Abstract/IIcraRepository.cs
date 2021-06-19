using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.DataAccess.Abstract
{
    public interface IIcraRepository
    {
        void DeleteIcra(int id);
        void SaveIcra(Icra icra);
        List<Icra> GetIcra(string customerTc);
    }
}
