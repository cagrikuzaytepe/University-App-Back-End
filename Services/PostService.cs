using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPostsApi.Data;
using UniversityPostsApi.Models;

namespace UniversityPostsApi.Services
{
    public class PostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public Task<IEnumerable<Post>> GetPostsAsync()
        {
            return _postRepository.GetPostsAsync();
        }

        public Task<Post> GetPostByIdAsync(int postId)
        {
            return _postRepository.GetPostByIdAsync(postId);
        }

        public Task AddPostAsync(Post post)
        {
            return _postRepository.AddPostAsync(post);
        }
    }
}
