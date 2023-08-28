using BlogWebSite.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Concrete.Context
{
    public class BlogWebSiteIdentityDbContext : IdentityDbContext<User, Role, int>
    {

        public BlogWebSiteIdentityDbContext(DbContextOptions<BlogWebSiteIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //builder.Entity<User>(x =>
            //x.HasMany(x => x.Articles)
            //.WithOne().HasForeignKey(x => x.UserId).IsRequired().OnDelete(DeleteBehavior.NoAction)
            //);

            base.OnModelCreating(builder);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

    }
}
