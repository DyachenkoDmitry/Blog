using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.WebUI.Domain.Entities;

namespace Blog.WebUI.Domain.Interfaces
{
    public interface IArticleRepository: IRepository<Article>
    {
        // Some addition logic
    }
}
