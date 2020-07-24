using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class WatchList
    {
        public int WatchListId { get; set; }

        public Product Product { get; set; }


        public string UserID { get; set; }

        public CustomUserIdentity User { get; set; }
    }
}
