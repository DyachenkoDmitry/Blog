using Blog.WebUI.Domain.Entities;

namespace Blog.WebUI.Domain.Interfaces
{
    public interface ICommentRepository: IRepository<Comment>
    {
        // Some addition logic
    }
}
