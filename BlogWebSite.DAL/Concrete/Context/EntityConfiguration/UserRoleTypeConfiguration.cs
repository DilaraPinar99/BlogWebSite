using BlogWebSite.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Concrete.Context.EntityConfiguration
{
    public class UserRoleTypeConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(
            new UserRole
            {
               RoleId= 1,
               UserId= 1,
            },
            new UserRole
            {
                 RoleId = 2,
                 UserId = 1,
            },
            new UserRole
            {
                 RoleId = 2,
                 UserId = 2,
            },
            new UserRole
            {
                RoleId = 2,
                UserId = 3,
            }
            );
        }
    }
}
