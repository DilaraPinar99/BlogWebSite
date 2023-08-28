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
    public class RoleTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.HasData(
            new Role
            {
                Id = 1,
                Name = "Admin",
            },
            new Role
            {
                Id = 2,
                Name = "AuthorUser",
            }
            );

        }
    }
}
