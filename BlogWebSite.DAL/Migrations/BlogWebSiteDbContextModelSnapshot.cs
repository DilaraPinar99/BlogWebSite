﻿// <auto-generated />
using System;
using BlogWebSite.DAL.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogWebSite.DAL.Migrations
{
    [DbContext(typeof(BlogWebSiteDbContext))]
    partial class BlogWebSiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlogWebSite.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ArticleContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Article Content");

                    b.Property<string>("ArticleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Article Title");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfLikes")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleContent = "İnşaat alanında erkeklerin hakimiyeti var ancak bu, kadınların bu sektöre uyum sağlamadığı anlamına gelmiyor. Giderek daha fazla kadın bu alana katıldıkça, geçmişteki stereotipler ve engeller yıkılıyor. Bu, kadınların sektöre kattığı değer ve 'dışarıdaki' konumunu nasıl aşabileceğimizle ilgili bir hikaye.Mimarlıkta çalışan bir kadın olarak her zaman yabancısınızdır. Sorun değil, sınırda olmayı seviyorum. Pritzker Ödülü sahibi mimar Zaha Hadid.Rakamlar cesaretimizi kırmamalıUlusal İstatistik Ofisi'ne (ONS) göre Birleşik Krallık'ta inşaat işçilerinin yalnızca %15'i kadındı.ABD'de %14 (2022) AB'de yalnızca %10 (2021).Rakamların bizi durdurmasına izin mi vermeliyiz? Kesinlikle hayır. Günümüzün modern kadını, kendisinden önceki pek çok kadın gibi, yabancı olarak algılanmaktan korkmuyor. Kendi yolumuzu açabiliriz, sevdiğimiz insanlardan ve en önemlisi kendimizden destek bulabiliriz.O patron olduğundaİnşaatta çalışmanın ne kadar zor olduğunu anlatmaya gerek yok. Bir mimar olarak benim hem ofiste hem de şantiyede bulunmam gerekiyor.Ne zaman inşaat sahasına gönderilsem, bu deneyime son derece değer veriyordum. Çünkü konfor alanından çıkmak sizi geliştirir ve sonunda kendinizin daha iyi bir versiyonunu ortaya çıkarır.",
                            ArticleTitle = "İnşaat Sektöründe Kadınlar: Tüm Engelleri Aşıyoruz",
                            CategoryId = 2,
                            CreationDate = new DateTime(2023, 8, 24, 21, 35, 0, 0, DateTimeKind.Unspecified),
                            Image = "/image/insaatsektorundekadinlar.png",
                            IsDeleted = false,
                            NumberOfLikes = 710,
                            State = "Created",
                            UserId = 1,
                            ViewsCount = 890
                        },
                        new
                        {
                            Id = 2,
                            ArticleContent = "1. Programlama kitaplarını okumak.Programlama dilleri, proje mimarisi, en iyi uygulamalar, farklı teknolojiler ve teoriler üzerine kitaplar okumak öğrenmeme ve becerilerimi geliştirmeme yardımcı oldu.“Paranızın karşılığını en iyi şekilde almak için çantanızı kafanıza dökün.” - Benjamin Franklin. 2. Eğiticileri izlemek.Eğitimler, tam bir program/uygulama oluşturmak için teknolojilerin birlikte nasıl çalıştığını ve yeni bir şeyin nasıl yapılacağını anlamanıza yardımcı olur.Nasıl yapacağımı öğrenmek için her zaman yapamadığım şeyleri yapıyorum.-Pablo Picasso 3. Her gün bir şeyler inşa etmek Öğreticilerle sınıflarla birlikte oluşturmaya başlayın ve kendi fikirlerinizi oluşturmaya çalışın.Wes Bos'un 30 günde 30 küçük projeden oluşan JavaScript30 kursu, başlamak için harika bir yerdir.“Söyle bana unuturum, öğret bana hatırlayayım, beni dahil edersen öğrenirim.” - Benjamin Franklin 4. Kendi projelerimi başlatmak.Kendi uygulamanızı oluşturmak için anlamanız gereken birçok ayrıntı var.Kendi projenizi hayata geçirmek, becerilerinizi geliştirmek için deneyim kazanmanıza yardımcı olacaktır.Twos , 7 Level Deep , Aware ve Müse'yi ben yaptım.Küçük şeyler büyük şeylerin gerçekleşmesini sağlar. — John Wooden. 5. Mülakatlara hazırlanmak.Programlama işi, geliştirici olarak öğrenmenin ve büyümenin bir yolu olabilir..İyi bir işe girebilmek için temel programlama kavramları ve problem çözme becerileriyle hazırlanmanız gerekir.Kodlama röportajını kırma kitabını okumanızı ve LeetCode'da çevrimiçi kodlama testleri yapmanızı öneririm .",
                            ArticleTitle = "Beni Daha İyi Bir Yazılım Mühendisi Yapan 7+ Alışkanlık",
                            CategoryId = 1,
                            CreationDate = new DateTime(2023, 6, 17, 9, 42, 0, 0, DateTimeKind.Unspecified),
                            Image = "/image/beniiyibiryazilimci.png",
                            IsDeleted = false,
                            NumberOfLikes = 510,
                            State = "Created",
                            UserId = 2,
                            ViewsCount = 1950
                        },
                        new
                        {
                            Id = 3,
                            ArticleContent = "Ecocline'ın 2016'daki son yeniden tasarımından sonra, artık zamanın ötesinde olduğunu düşünüyorum. Planım mümkün olduğunca mevcut tasarıma sadık kalmak ve daha iyi kullanılabilirlik ve erişilebilirlik için gerekenleri değiştirmekti. Ancak küçük değişikliklerin bile bilgi çıktısı ve tüm otobüs yolculuğunun hikayesinin anlatılma şekli üzerinde büyük etkisi olabilir.Uygulama Ecolines, 22 ülkede 200 otobüsten oluşan bir filodan oluşan bir otobüs seyahat şirketidir. Maalesef mobil uygulamaları kötü kullanılabilirliğin mükemmel bir örneğidir. İyileştirilecek çok yer var. Biraz pratik kazanmak için 5 gün içinde mümkün olduğunca çok sayıda küçük sorunu çözmek istedim. Bu yüzden onu seçtim.FikirUX/UI tasarımcıları olarak görevimiz, her şeyi işlevsel ve kullanışlı hale getirmek[…] Planım uygulamayı yeniden icat etmek ya da genel olarak yeniden yapılandırmak değildi. Yapmaya çalıştığım şey mümkün olduğu kadar mevcut tasarıma bağlı kalmak ve daha iyi kullanılabilirlik ve karışıklığı önlemek için gerekenleri değiştirmek. Sezgisel hata düzeltmeye, bilgi mimarisinde hafif bir basitleştirmeye ve daha iyi erişilebilirliğe odaklandım. Hazırlık :Kullanıcı arayüzündeki daha küçük sorunları çözmek için, öncelikle varsayımları el çizimleriyle veya düşük kaliteli tel çerçevelerle test etmeye gerçekten gerek yoktu. Bu yüzden yalnızca yüksek sadakatle çalışmayı seçtim. Kağıt kalem kullanan biri olarak eskiz yapmamak alışılmadık bir durumdu ama bu durumda çok zaman kazandırdı. Başlamadan önce, her sorunu kırmızı bir kutuyla vurgulayarak her ekranı analiz etmem gerekiyordu.",
                            ArticleTitle = "Temel Esaslar — Minimal Bir Tasarım Müdahalesi",
                            CategoryId = 3,
                            CreationDate = new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/image/uxUi.png",
                            IsDeleted = false,
                            NumberOfLikes = 3050,
                            State = "Created",
                            UserId = 1,
                            ViewsCount = 7850
                        },
                        new
                        {
                            Id = 4,
                            ArticleContent = "Bir zamanlar evrenden beklediğim kişiyle tanıştım. Hatta tam benim istediğim şekilde tanıştık.Tek başıma bir kaya tırmanışı yolculuğundaydım ve bir dizi önemli ve beklenmedik olaydan sonra, uzak bir çiftlikte kalan tek iki kişi bizdik.Tanıştığımız ilk akşam, gece geç saatlere kadar derin bir sohbet yaşadık. O andan itibaren kalçadan birleşmiştik. Heyecan verici bir macera yaşadık; tırmanmak, sevişmek ve ülkeyi baştan başa gezmek. Ruhumuzu ortaya döktük ve zor zamanlarda birbirimize yardım ettik. Bu yolculuğun sonunda onun eyaletine taşınmaya karar verdim.Mükemmel bir peri masalı gibi görünüyordu. Ama yine de değildi.Duygusal olarak güvende olduğum tek bir an bile olmadı ama kendimi derinden yalnız hissettiğim birçok an oldu.Bu kafa karıştırıcıydı. İstediğim tam olarak bu değil miydi?Artık evrene bir ilişkide ne yapmak istediğimi söylediğimi ama nasıl hissetmek istediğimi söylemediğimi fark ettim .Dışarıdan bakıldığında aynı yaşam tarzı hedeflerine, aynı tutkulara ve aynı ilgi alanlarına sahiptik. İçsel olarak; duyguları farklı bir şekilde ilettik, çatışmaları zıt kutuplarda çözdük ve birbiriyle uyuşmayan zihniyetlere sahiptik.Ayrıldık.Sorulduğunda neyin yanlış olduğunu tam olarak ifade edemedim ama hiçbir şeyin tam olarak doğru gelmediğini biliyordum.O ilişkiden sonra istediğimin tam tersi olan biriyle tanıştım. En azından kağıt üzerinde. Aynı yaşam tarzı hedeflerimize sahip değildik, ilk gün aramızda parlak bir kimya yoktu ve hayatta çok farklı yollardaydık.Ama bugün, yıllar sonra onunla geçirilen her an saf mutluluktur. Hiç bu kadar gerçekten görüldüğümü ve olduğum kişi olarak hayran olduğumu hissetmemiştim. Günlerimiz şaşırtıcı eğlencelerle dolu. Tanıştığımızda hayatta çok farklı yörüngelerde olsak da, bugün bir şekilde mükemmel bir şekilde hizalanmış bir gerçekliği birlikte yaratmış gibiydik.Nasıl bu kadar yanlış anladım?",
                            ArticleTitle = "İstatistiksel Olarak Yanlış Kişiyle Evleneceksiniz. İşte Nedeni!",
                            CategoryId = 7,
                            CreationDate = new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "/image/iliskipng.png",
                            IsDeleted = false,
                            NumberOfLikes = 2550,
                            State = "Created",
                            UserId = 3,
                            ViewsCount = 18850
                        });
                });

            modelBuilder.Entity("BlogWebSite.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryDescription")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryDescription = "Yazılım mühendisliği hakkındaki yazılar.",
                            CategoryName = "Yazılım Mühendisliği",
                            State = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryDescription = "Kadınlar hakkında...",
                            CategoryName = "Kadın",
                            State = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryDescription = "UX-UI meraklılarını ilgilendiren içerikler.",
                            CategoryName = "UX/UI",
                            State = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryDescription = "İnsan psikolojisi.",
                            CategoryName = "Akıl Sağlığı",
                            State = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryDescription = "Dünya'nın her yerinden farklı kültürler.",
                            CategoryName = "Bilim",
                            State = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryDescription = "Bilimin ve yapay zekanın birleşmesiyle oluşan ilginç ve bir o kadar da eğlenceli içerik.",
                            CategoryName = "Makine Öğrenmesi",
                            State = 0
                        },
                        new
                        {
                            Id = 7,
                            CategoryDescription = "İlişkiler hakkında her şey.",
                            CategoryName = "İlişkiler",
                            State = 0
                        },
                        new
                        {
                            Id = 8,
                            CategoryDescription = "Dünya'nın her yerinden farklı kültürler.",
                            CategoryName = "Kültür",
                            State = 0
                        },
                        new
                        {
                            Id = 9,
                            CategoryDescription = "Geçmiş zamanın incelenmesi bilimi.",
                            CategoryName = "Tarih",
                            State = 0
                        },
                        new
                        {
                            Id = 10,
                            CategoryDescription = "Sanata dair her şey.",
                            CategoryName = "Art",
                            State = 0
                        });
                });

            modelBuilder.Entity("BlogWebSite.Entities.Article", b =>
                {
                    b.HasOne("BlogWebSite.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogWebSite.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}