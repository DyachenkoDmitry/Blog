using System.Web.Mvc;
using Blog.WebUI.Domain;
using Blog.WebUI.ViewModel.Articles;

namespace Blog.WebUI.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticlesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ViewResult ShowArticles()
        {
            var articles = new ArticlesToDisplayViewModel
            {
                Articles = _unitOfWork.Articles.GetAll()
            };
            return View(articles);
        }        
    }
}