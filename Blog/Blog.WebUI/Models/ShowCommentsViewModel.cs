using System.Collections.Generic;
using Blog.WebUI.Domain.Entities;

namespace Blog.WebUI.Models
{
    public class ShowCommentsViewModel
    {
        public IEnumerable<Comment> Comments { get; set; }
    }
}