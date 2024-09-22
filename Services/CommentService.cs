using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPostsApi.Data;
using UniversityPostsApi.Models;

namespace UniversityPostsApi.Services
{
    public class CommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
        {
            return _commentRepository.GetCommentsByPostIdAsync(postId);
        }

        public Task AddCommentAsync(Comment comment)
        {
            return _commentRepository.AddCommentAsync(comment);
        }
    }
}
