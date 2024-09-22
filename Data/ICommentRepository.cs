using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPostsApi.Models;

namespace UniversityPostsApi.Data
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId);
        Task AddCommentAsync(Comment comment);
    }
}
