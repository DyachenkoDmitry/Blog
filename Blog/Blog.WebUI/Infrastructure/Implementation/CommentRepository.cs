using Blog.WebUI.Domain.Entities;
using Blog.WebUI.Domain.Interfaces;

namespace Blog.WebUI.Infrastructure.Implementation
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(DataSource source)
            : base(source.Comments)
        {
        }
    }
}