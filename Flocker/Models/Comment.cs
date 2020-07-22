using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public int ProductId { get; set; }

        public string UserId { get; set; }

        public CustomUserIdentity User { get; set; }

    }
}
