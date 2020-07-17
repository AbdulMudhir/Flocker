using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Model
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string content { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
