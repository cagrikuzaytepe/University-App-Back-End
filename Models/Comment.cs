using System;

namespace UniversityPostsApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserEmail { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
