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
    public class UserManager : IUserManager
    {
        IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User UserLogin(string userName, string password)
        {
            User user=_userRepository.UserLogin(userName, password);
            return user;
        }
    }
}
