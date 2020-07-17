using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers => new List<User>
        {
            new User
            {
                UserId= 1,
                Username = "Test Dummy",
                Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg"
               
            }
            ,
             new User
            {
                UserId= 2,
                Username = "Bob Marley",
                Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg"

            },
              new User
            {
                UserId= 3,
                Username = "Jack Danny",
                Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg"

            }
        };


        public User GetUserById(int userId)
        {
            return AllUsers.FirstOrDefault(user => user.UserId == userId);
        }
    }
}
