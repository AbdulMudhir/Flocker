using Microsoft.EntityFrameworkCore;
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

        public void AddWatchlist(WatchList watchList)
        {
            _databaseContext.WatchLists.Add(watchList);

            _databaseContext.SaveChanges();
        }

        public WatchList GetWatchListForUserForProduct(string userID, int ProductId)
        {
            return _databaseContext.WatchLists.FirstOrDefault(w => w.Product.ProductId == ProductId &&
 
            w.UserID.Equals(userID)

            );
        }

        public IEnumerable<WatchList> GetWatchListsByUserId(string userId)
        {
            return _databaseContext.WatchLists.Where(w => w.UserID.Equals(userId)).Include(w => w.Product).ThenInclude(p => p.Owner).Include(p => p.Product.Sold);
        }

        public void RemoveWatchlist(WatchList watchList)
        {
            _databaseContext.WatchLists.Remove(watchList);

            _databaseContext.SaveChanges();
        }
    }
}
