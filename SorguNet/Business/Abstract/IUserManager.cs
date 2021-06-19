using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.Business.Abstract
{
    public interface IUserManager
    {
        User UserLogin(string userName, string password);
    }
}
