using System.ComponentModel.DataAnnotations;

namespace Blog.WebUI.Extensions.Enum
{
    public enum Gender
    {
        [Display(Name = "Male")]
        Male = 1,
        [Display(Name = "Female")]
        Female = 2
    }
}