using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public interface ICommentRepository
    {

        public IEnumerable<Comment> AllComments { get; }


        public IEnumerable<Comment> AllCommentsByUserId(int id);


    }
}
