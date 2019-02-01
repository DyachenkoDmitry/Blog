using System.Collections.Generic;
using Blog.WebUI.Domain.Entities;

namespace Blog.WebUI.ViewModel.Comments
{
    public class CommentsToDisplayViewModel
    {
        public IEnumerable<Comment> Comments { get; set; }
    }
}