using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Blog.WebUI.Helpers.Enum
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this System.Enum enumValue)
        {
            return enumValue.GetType()?
                .GetMember(enumValue.ToString())?
                .First()?
                .GetCustomAttribute<DisplayAttribute>()?
                .Name;
        }
    }
}