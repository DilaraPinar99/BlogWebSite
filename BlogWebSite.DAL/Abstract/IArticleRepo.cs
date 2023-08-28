using BlogWebSite.Core.IBaseRepositories;
using BlogWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Abstract
{
    public interface IArticleRepo : IBaseRepository<Article>
    {

    }
}
