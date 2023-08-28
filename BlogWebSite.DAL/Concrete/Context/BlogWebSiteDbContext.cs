using BlogWebSite.DAL.Concrete.Context.EntityConfiguration;
using BlogWebSite.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Concrete.Context
{
    public class BlogWebSiteDbContext : DbContext
    {

        public BlogWebSiteDbContext(DbContextOptions<BlogWebSiteDbContext> options) : base(options)
        {
          
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleTypeConfiguration())
                 .ApplyConfiguration(new CategoryTypeConfiguration());
        
        }
      
    }
}
