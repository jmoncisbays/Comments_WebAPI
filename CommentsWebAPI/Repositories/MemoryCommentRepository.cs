using System.Collections.Generic;
using CommentsWebAPI.Models;

namespace CommentsWebAPI.Repositories
{
    public class MemoryCommentRepository : ICommentRepository
    {
        private List<Comment> _comments;

        public MemoryCommentRepository() => _comments = new List<Comment>();

        public IEnumerable<Comment> GetAll => _comments;

        public void Add(Comment comment)
        {
            _comments.Add(comment);
        }
    }
}
