using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Model
{
    public interface IUserRepository
    {

        public User GetUserById(int userId);

        public IEnumerable<User> AllUsers { get;  }

    }
}
