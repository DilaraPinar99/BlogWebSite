using BlogWebSite.Core.Enums;
using BlogWebSite.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Concrete.Context.EntityConfiguration
{
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.Property(x => x.CategoryName)
                .IsRequired();


            builder.Property(x => x.CategoryDescription)
                .HasMaxLength(256);

            

            builder.HasData(
                new Category
                {
                    Id=1,
                    CategoryName = "Yazılım Mühendisliği",
                    CategoryDescription="Yazılım mühendisliği hakkındaki yazılar.",
                    State = State.Created
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Kadın",
                    CategoryDescription = "Kadınlar hakkında...",
                    State = State.Created
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "UX/UI",
                    CategoryDescription = "UX-UI meraklılarını ilgilendiren içerikler.",
                    State = State.Created

                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Akıl Sağlığı",
                    CategoryDescription = "İnsan psikolojisi.",
                    State = State.Created
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "Bilim",
                    CategoryDescription = "Dünya'nın her yerinden farklı kültürler.",
                    State = State.Created
                },
                new Category
                {
                    Id = 6,
                    CategoryName = "Makine Öğrenmesi",
                    CategoryDescription = "Bilimin ve yapay zekanın birleşmesiyle oluşan ilginç ve bir o kadar da eğlenceli içerik.",
                    State = State.Created
                },
                new Category
                {
                    Id = 7,
                    CategoryName = "İlişkiler",
                    CategoryDescription = "İlişkiler hakkında her şey.",
                    State = State.Created
                },
                new Category
                {
                    Id = 8,
                    CategoryName = "Kültür",
                    CategoryDescription = "Dünya'nın her yerinden farklı kültürler.",
                    State = State.Created
                },
                new Category
                {
                    Id = 9,
                    CategoryName = "Tarih",
                    CategoryDescription = "Geçmiş zamanın incelenmesi bilimi.",
                    State = State.Created
                },
                new Category
                {
                    Id = 10,
                    CategoryName = "Art",
                    CategoryDescription = "Sanata dair her şey.",
                    State = State.Created

                }  );

        }
    }
}
