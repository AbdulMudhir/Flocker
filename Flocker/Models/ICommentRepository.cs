using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public interface ICommentRepository
    {

        public void PostComment(Comment comment);
    }
}
