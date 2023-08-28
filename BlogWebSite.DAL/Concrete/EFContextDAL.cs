using BlogWebSite.DAL.Abstract;
using BlogWebSite.DAL.Concrete.Context;
using BlogWebSite.DAL.Concrete.Repositories;
using BlogWebSite.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Concrete
{
    public static class EFContextDAL
    {
        public static IServiceCollection AddScopedDAL(this IServiceCollection services)
        {
            services.AddDbContext<BlogWebSiteDbContext>(opt =>
            {
                string standartCon = "Server=DESKTOP-TEGGASV\\SQL2022;Database=BlogWebSite;Trusted_Connection=True;";
                opt.UseSqlServer(standartCon);
                opt.UseLazyLoadingProxies();
            });

            services.AddDbContext<BlogWebSiteIdentityDbContext>(opt =>
            {
                string standartConnection = "Server=DESKTOP-TEGGASV\\SQL2022;Database=BlogWebSiteIdentity;Trusted_Connection=True;";
                opt.UseSqlServer(standartConnection);
                opt.UseLazyLoadingProxies();
            })
                .AddScoped<IArticleRepo, ArticleRepo>()
                .AddScoped<ICategoryRepo, CategoryRepo>();


             services.AddIdentityCore<User>().AddRoles<Role>().AddEntityFrameworkStores<BlogWebSiteIdentityDbContext>();

            return services;
        }
    }
}
