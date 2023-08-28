using BlogWebSite.DAL.Abstract;
using BlogWebSite.DAL.Base.EntityFramework;
using BlogWebSite.DAL.Concrete.Context;
using BlogWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Concrete.Repositories
{
    public class ArticleRepo : BaseRepository<Article, BlogWebSiteDbContext>, IArticleRepo
    {
        public ArticleRepo(BlogWebSiteDbContext context) : base(context)
        {
        }
    }
}
