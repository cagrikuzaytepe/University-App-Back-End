using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityPostsApi.Models;
using UniversityPostsApi.Services;

namespace UniversityPostsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly CommentService _commentService;

        public CommentsController(CommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("post/{postId}")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetComments(int postId)
        {
            var comments = await _commentService.GetCommentsByPostIdAsync(postId);
            return Ok(comments);
        }

        [HttpPost]
        public async Task<ActionResult> CreateComment([FromBody] Comment comment)
        {
            await _commentService.AddCommentAsync(comment);
            return CreatedAtAction(nameof(GetComments), new { postId = comment.PostId }, comment);
        }
    }
}
