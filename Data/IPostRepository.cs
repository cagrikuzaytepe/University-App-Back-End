using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPostsApi.Models;

namespace UniversityPostsApi.Data
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPostsAsync();
        Task<Post> GetPostByIdAsync(int postId);
        Task AddPostAsync(Post post);
    }
}
