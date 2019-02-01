using Blog.WebUI.Domain;
using Blog.WebUI.Domain.Interfaces;
using Blog.WebUI.Infrastructure.Implementation;

namespace Blog.WebUI.Infrastructure
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DataSource _db;
        private IArticleRepository _articleRepository;
        private ICommentRepository _commentRepository;

        public UnitOfWork(DataSource data)
        {
            this._db = data;
        }

        public IArticleRepository Articles
            => _articleRepository ?? (_articleRepository = new ArticleRepository(_db));
        public ICommentRepository Comments 
            => _commentRepository ?? (_commentRepository = new CommentRepository(_db));
    }
}