using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class MockCommentRepository : ICommentRepository
    {
        public IEnumerable<Comment> AllComments => throw new NotImplementedException();

        public IEnumerable<Comment> AllCommentsByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
