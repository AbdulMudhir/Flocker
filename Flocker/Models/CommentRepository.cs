using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class CommentRepository : ICommentRepository
    {
        DatabaseContext _databaseContext;

        public CommentRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void PostComment(Comment comment)
        {
            comment.DatePosted = DateTime.Now;

            _databaseContext.Comments.Add(comment);

            _databaseContext.SaveChanges();
        }
    }
}
