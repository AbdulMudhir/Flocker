using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class UserRepository : IUserRepository
    {

        DatabaseContext _databaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<User> AllUsers => _databaseContext.Users;

        public User GetUserById(int userId)
        {
            return _databaseContext.Users.FirstOrDefault(u => u.UserId == userId);
        }
    }
}
