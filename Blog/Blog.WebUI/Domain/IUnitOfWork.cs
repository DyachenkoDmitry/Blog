using Blog.WebUI.Domain.Interfaces;

namespace Blog.WebUI.Domain
{
    public interface IUnitOfWork
    {
        IArticleRepository Articles { get; }
        ICommentRepository Comments { get; }
    }
}
