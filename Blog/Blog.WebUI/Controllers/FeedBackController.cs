using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.WebUI.Extensions.Enum;
using Blog.WebUI.ViewModel.FeedBack;

namespace Blog.WebUI.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: FeedBack
        [HttpGet]
        public ActionResult ShowFeedback()
        {
            var model = new FeedbackToDisplayViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult ShowFeedback(FeedbackToDisplayViewModel feedback)
        {
            if (ModelState.IsValid)
            {
                return View("SuccessfulFeedback", feedback);
            }

            return View();
        }
    }
}