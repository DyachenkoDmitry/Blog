using System.Collections.Generic;
using Blog.WebUI.Domain.Entities;

namespace Blog.WebUI.Models
{
    public class ShowArticlesViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
    }
}