using System.Collections.Generic;
using Blog.WebUI.Domain.Entities;
using Blog.WebUI.Domain.Interfaces;

namespace Blog.WebUI.Infrastructure.Implementation
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(DataSource source)
            : base(source.Articles)
        {
        }
    }
}
