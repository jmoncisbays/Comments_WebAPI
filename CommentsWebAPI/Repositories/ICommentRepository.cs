using System.Collections.Generic;
using CommentsWebAPI.Models;

namespace CommentsWebAPI.Repositories
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAll { get; }
        void Add(Comment comment);
    }
}
