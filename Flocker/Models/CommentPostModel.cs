using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class CommentPostModel
    {
        
        [Required]
        public int ProductId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DatePosted { get; set; }
        public string UserId { get; set; }

    }
}
