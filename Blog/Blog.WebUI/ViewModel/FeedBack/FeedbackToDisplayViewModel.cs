using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Blog.WebUI.Extensions.Enum;

namespace Blog.WebUI.ViewModel.FeedBack
{
    public class FeedbackToDisplayViewModel
    {
        [MinLength(1)]
        [Required(ErrorMessage = "You should type your name.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "You should set up your gender.")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Please, select one or several improvements.")]
        public List<Improvement> Improvements { get; set; }

        public FeedbackToDisplayViewModel()
        {
            Improvements = new List<Improvement>(2);
            Improvements.Add(new Improvement
                {
                    ImprovementId = 0,
                    Display = "More articles"
                });
            Improvements.Add(new Improvement
                {
                    ImprovementId = 1,
                    Display = "More authors"
                });
            Improvements.Add(new Improvement
                {
                    ImprovementId = 2,
                    Display = "Improve design"
                });
            Improvements.Add(new Improvement
                {
                    ImprovementId = 3,
                    Display = "Add categories of articles"
                });
            
        }

    }
}