using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.DataAccess.Abstract
{
    public interface IUserRepository
    {
        User UserLogin(string userName, string password);
    }
}
