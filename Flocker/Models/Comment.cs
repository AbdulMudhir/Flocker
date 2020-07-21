using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class Comment
    {
        public int CommentId { get; set; }


        [MaxLength(500)]
        [Required]
        public string content { get; set; }
        public int ProductId { get; set; }


        public int UserId { get; set; }

        public User User { get; set; }

    }
}
