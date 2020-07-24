using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class WatchListViewModel
    {
        public IEnumerable<WatchList> WatchLists { get;set;}

        public WatchList watchList { get; set; }
    }
}
