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
    public class UserTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id)
                .UseIdentityColumn(1,1);
         

            builder.HasData(
                new User
                {
                    Id=1,
                    UserName="dilosh",
                    Email="dilarapiinar@gmail.com",
                    Password="Dilara_1903",
                },
                 new User
                 {
                     Id = 2,
                     UserName = "musti",
                     Email = "14mustafa.pnr03@gmail.com",
                     Password = "Musti_1903",
                 },
                 new User
                 {
                     Id = 3,
                     UserName = "kitsune",
                     Email = "dpdeveloper1703@gmail.com",
                     Password = "Dilara_1903",
                 }
                );
        }
    }
}
