using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class WatchListRepository : IWatchListRepository
    {
        DatabaseContext _databaseContext;

        public WatchListRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<WatchList> GetWatchListsByUserId(string userId)
        {
            return _databaseContext.WatchLists.Where(w => w.UserID.Equals(userId));
        }
    }
}
