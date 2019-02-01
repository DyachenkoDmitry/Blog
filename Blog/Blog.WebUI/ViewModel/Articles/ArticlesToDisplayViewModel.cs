using System.Collections.Generic;
using Blog.WebUI.Domain.Entities;

namespace Blog.WebUI.ViewModel.Articles
{
    public class ArticlesToDisplayViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
    }
}