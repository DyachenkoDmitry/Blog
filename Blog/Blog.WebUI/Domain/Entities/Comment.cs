using System;

namespace Blog.WebUI.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public string Content { get; set; }
    }
}