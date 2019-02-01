using System.Web.Mvc;
using Blog.WebUI.Domain;
using Blog.WebUI.ViewModel.Comments;

namespace Blog.WebUI.Controllers
{
    public class CommentsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ViewResult ShowComments()
        {
            var comments = new CommentsToDisplayViewModel
            {
                Comments = _unitOfWork.Comments.GetAll()
            };
            return View(comments);
        }
    }
}