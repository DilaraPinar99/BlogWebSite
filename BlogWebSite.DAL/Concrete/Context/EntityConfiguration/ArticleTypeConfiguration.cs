using BlogWebSite.Core.Enums;
using BlogWebSite.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Concrete.Context.EntityConfiguration
{
    public class ArticleTypeConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.Property(x => x.ArticleTitle)
                .IsRequired()
                .HasColumnName("Article Title");

            builder.Property(x => x.ArticleContent)
                .IsRequired()
                .HasColumnName("Article Content");

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.State)
                   .HasConversion(new EnumToStringConverter<State>());

            builder.HasData(
             new Article
             {
                 Id = 1,
                 ArticleTitle = "İnşaat Sektöründe Kadınlar: Tüm Engelleri Aşıyoruz",
                 ArticleContent = "İnşaat alanında erkeklerin hakimiyeti var ancak bu, kadınların bu sektöre uyum sağlamadığı anlamına gelmiyor. Giderek daha fazla kadın bu alana katıldıkça, geçmişteki stereotipler ve engeller yıkılıyor. Bu, kadınların sektöre kattığı değer ve 'dışarıdaki' konumunu nasıl aşabileceğimizle ilgili bir hikaye.Mimarlıkta çalışan bir kadın olarak her zaman yabancısınızdır. Sorun değil, sınırda olmayı seviyorum. Pritzker Ödülü sahibi mimar Zaha Hadid.Rakamlar cesaretimizi kırmamalıUlusal İstatistik Ofisi'ne (ONS) göre Birleşik Krallık'ta inşaat işçilerinin yalnızca %15'i kadındı.ABD'de %14 (2022) AB'de yalnızca %10 (2021).Rakamların bizi durdurmasına izin mi vermeliyiz? Kesinlikle hayır. Günümüzün modern kadını, kendisinden önceki pek çok kadın gibi, yabancı olarak algılanmaktan korkmuyor. Kendi yolumuzu açabiliriz, sevdiğimiz insanlardan ve en önemlisi kendimizden destek bulabiliriz.O patron olduğundaİnşaatta çalışmanın ne kadar zor olduğunu anlatmaya gerek yok. Bir mimar olarak benim hem ofiste hem de şantiyede bulunmam gerekiyor.Ne zaman inşaat sahasına gönderilsem, bu deneyime son derece değer veriyordum. Çünkü konfor alanından çıkmak sizi geliştirir ve sonunda kendinizin daha iyi bir versiyonunu ortaya çıkarır.",
                 CreationDate = new DateTime(2023, 08, 24, 21, 35, 0),
                 ViewsCount = 890,
                 NumberOfLikes = 710,
                 Image = @"/image/insaatsektorundekadinlar.png",
                 IsDeleted = false,
                 CategoryId = 2,
                 State = State.Created,
                 UserId=1
                 
             },
                 new Article
                 {
                     Id = 2,
                     ArticleTitle = "Beni Daha İyi Bir Yazılım Mühendisi Yapan 7+ Alışkanlık",
                     ArticleContent = "1. Programlama kitaplarını okumak.Programlama dilleri, proje mimarisi, en iyi uygulamalar, farklı teknolojiler ve teoriler üzerine kitaplar okumak öğrenmeme ve becerilerimi geliştirmeme yardımcı oldu.“Paranızın karşılığını en iyi şekilde almak için çantanızı kafanıza dökün.” - Benjamin Franklin. 2. Eğiticileri izlemek.Eğitimler, tam bir program/uygulama oluşturmak için teknolojilerin birlikte nasıl çalıştığını ve yeni bir şeyin nasıl yapılacağını anlamanıza yardımcı olur.Nasıl yapacağımı öğrenmek için her zaman yapamadığım şeyleri yapıyorum.-Pablo Picasso 3. Her gün bir şeyler inşa etmek Öğreticilerle sınıflarla birlikte oluşturmaya başlayın ve kendi fikirlerinizi oluşturmaya çalışın.Wes Bos'un 30 günde 30 küçük projeden oluşan JavaScript30 kursu, başlamak için harika bir yerdir.“Söyle bana unuturum, öğret bana hatırlayayım, beni dahil edersen öğrenirim.” - Benjamin Franklin 4. Kendi projelerimi başlatmak.Kendi uygulamanızı oluşturmak için anlamanız gereken birçok ayrıntı var.Kendi projenizi hayata geçirmek, becerilerinizi geliştirmek için deneyim kazanmanıza yardımcı olacaktır.Twos , 7 Level Deep , Aware ve Müse'yi ben yaptım.Küçük şeyler büyük şeylerin gerçekleşmesini sağlar. — John Wooden. 5. Mülakatlara hazırlanmak.Programlama işi, geliştirici olarak öğrenmenin ve büyümenin bir yolu olabilir..İyi bir işe girebilmek için temel programlama kavramları ve problem çözme becerileriyle hazırlanmanız gerekir.Kodlama röportajını kırma kitabını okumanızı ve LeetCode'da çevrimiçi kodlama testleri yapmanızı öneririm .",
                     CreationDate = new DateTime(2023, 06, 17, 09, 42, 0),
                     ViewsCount = 1950,
                     NumberOfLikes = 510,
                     Image = @"/image/beniiyibiryazilimci.png",
                     IsDeleted = false,
                     CategoryId = 1,
                     State = State.Created,
                     UserId = 2
                 },
   new Article
   {
       Id = 3,
       ArticleTitle = "Temel Esaslar — Minimal Bir Tasarım Müdahalesi",
       ArticleContent = "Ecocline'ın 2016'daki son yeniden tasarımından sonra, artık zamanın ötesinde olduğunu düşünüyorum. Planım mümkün olduğunca mevcut tasarıma sadık kalmak ve daha iyi kullanılabilirlik ve erişilebilirlik için gerekenleri değiştirmekti. Ancak küçük değişikliklerin bile bilgi çıktısı ve tüm otobüs yolculuğunun hikayesinin anlatılma şekli üzerinde büyük etkisi olabilir.Uygulama Ecolines, 22 ülkede 200 otobüsten oluşan bir filodan oluşan bir otobüs seyahat şirketidir. Maalesef mobil uygulamaları kötü kullanılabilirliğin mükemmel bir örneğidir. İyileştirilecek çok yer var. Biraz pratik kazanmak için 5 gün içinde mümkün olduğunca çok sayıda küçük sorunu çözmek istedim. Bu yüzden onu seçtim.FikirUX/UI tasarımcıları olarak görevimiz, her şeyi işlevsel ve kullanışlı hale getirmek[…] Planım uygulamayı yeniden icat etmek ya da genel olarak yeniden yapılandırmak değildi. Yapmaya çalıştığım şey mümkün olduğu kadar mevcut tasarıma bağlı kalmak ve daha iyi kullanılabilirlik ve karışıklığı önlemek için gerekenleri değiştirmek. Sezgisel hata düzeltmeye, bilgi mimarisinde hafif bir basitleştirmeye ve daha iyi erişilebilirliğe odaklandım. Hazırlık :Kullanıcı arayüzündeki daha küçük sorunları çözmek için, öncelikle varsayımları el çizimleriyle veya düşük kaliteli tel çerçevelerle test etmeye gerçekten gerek yoktu. Bu yüzden yalnızca yüksek sadakatle çalışmayı seçtim. Kağıt kalem kullanan biri olarak eskiz yapmamak alışılmadık bir durumdu ama bu durumda çok zaman kazandırdı. Başlamadan önce, her sorunu kırmızı bir kutuyla vurgulayarak her ekranı analiz etmem gerekiyordu.",
       CreationDate = new DateTime(2023, 06, 11, 0, 0, 0),
       ViewsCount = 7850,
       NumberOfLikes = 3050,
       Image = @"/image/uxUi.png",
       IsDeleted = false,
       CategoryId = 3,
       State = State.Created,
       UserId = 1
   },
     new Article
     {
         Id = 4,
         ArticleTitle = "İstatistiksel Olarak Yanlış Kişiyle Evleneceksiniz. İşte Nedeni!",
         ArticleContent = "Bir zamanlar evrenden beklediğim kişiyle tanıştım. Hatta tam benim istediğim şekilde tanıştık.Tek başıma bir kaya tırmanışı yolculuğundaydım ve bir dizi önemli ve beklenmedik olaydan sonra, uzak bir çiftlikte kalan tek iki kişi bizdik.Tanıştığımız ilk akşam, gece geç saatlere kadar derin bir sohbet yaşadık. O andan itibaren kalçadan birleşmiştik. Heyecan verici bir macera yaşadık; tırmanmak, sevişmek ve ülkeyi baştan başa gezmek. Ruhumuzu ortaya döktük ve zor zamanlarda birbirimize yardım ettik. Bu yolculuğun sonunda onun eyaletine taşınmaya karar verdim.Mükemmel bir peri masalı gibi görünüyordu. Ama yine de değildi.Duygusal olarak güvende olduğum tek bir an bile olmadı ama kendimi derinden yalnız hissettiğim birçok an oldu.Bu kafa karıştırıcıydı. İstediğim tam olarak bu değil miydi?Artık evrene bir ilişkide ne yapmak istediğimi söylediğimi ama nasıl hissetmek istediğimi söylemediğimi fark ettim .Dışarıdan bakıldığında aynı yaşam tarzı hedeflerine, aynı tutkulara ve aynı ilgi alanlarına sahiptik. İçsel olarak; duyguları farklı bir şekilde ilettik, çatışmaları zıt kutuplarda çözdük ve birbiriyle uyuşmayan zihniyetlere sahiptik.Ayrıldık.Sorulduğunda neyin yanlış olduğunu tam olarak ifade edemedim ama hiçbir şeyin tam olarak doğru gelmediğini biliyordum.O ilişkiden sonra istediğimin tam tersi olan biriyle tanıştım. En azından kağıt üzerinde. Aynı yaşam tarzı hedeflerimize sahip değildik, ilk gün aramızda parlak bir kimya yoktu ve hayatta çok farklı yollardaydık.Ama bugün, yıllar sonra onunla geçirilen her an saf mutluluktur. Hiç bu kadar gerçekten görüldüğümü ve olduğum kişi olarak hayran olduğumu hissetmemiştim. Günlerimiz şaşırtıcı eğlencelerle dolu. Tanıştığımızda hayatta çok farklı yörüngelerde olsak da, bugün bir şekilde mükemmel bir şekilde hizalanmış bir gerçekliği birlikte yaratmış gibiydik.Nasıl bu kadar yanlış anladım?",
         CreationDate = new DateTime(2020, 11, 11, 0, 0, 0),
         ViewsCount = 18850,
         NumberOfLikes = 2550,
         Image = @"/image/iliskipng.png",
         IsDeleted = false,
         CategoryId = 7,
         State = State.Created,
         UserId = 3
     });


        }
    }
}

