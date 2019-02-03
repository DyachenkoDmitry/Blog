using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.WebUI.ViewModel.FeedBack
{
    public class Improvement
    {
        public int ImprovementId { get; set; }
        public string Display { get; set; }
        public bool IsChecked { get; set; }
    }
}