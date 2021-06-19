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
    public class UserRepository : IUserRepository
    {
        private readonly DbContext context;
        public User UserLogin(string userName, string password)
        {
            User user = null;
            using (var context = new SorguNetDbContext())
            {
                user=context.Users.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            }
            return user;

        }
    }
}
