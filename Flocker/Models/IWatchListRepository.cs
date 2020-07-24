using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public interface IWatchListRepository
    {

        public IEnumerable<WatchList> GetWatchListsByUserId(string userId);

        public WatchList GetWatchListForUserForProduct(string userID, int ProductId);

        public void RemoveWatchlist(WatchList watchList);

        public void AddWatchlist(WatchList watchList);
    }
}
