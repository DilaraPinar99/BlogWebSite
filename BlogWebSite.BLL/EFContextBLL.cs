using BlogWebSite.DAL.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.BLL
{
    public static class EFContextBLL
    {
        public static IServiceCollection AddScopedBLL(this IServiceCollection services)
        {
            services.AddScopedDAL();

            return services;
        }
    }
}
