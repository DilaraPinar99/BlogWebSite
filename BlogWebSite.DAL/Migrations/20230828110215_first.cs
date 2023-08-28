using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebSite.DAL.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleTitle = table.Column<string>(name: "Article Title", type: "nvarchar(max)", nullable: false),
                    ArticleContent = table.Column<string>(name: "Article Content", type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    NumberOfLikes = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName", "State" },
                values: new object[,]
                {
                    { 1, "Yazılım mühendisliği hakkındaki yazılar.", "Yazılım Mühendisliği", 0 },
                    { 2, "Kadınlar hakkında...", "Kadın", 0 },
                    { 3, "UX-UI meraklılarını ilgilendiren içerikler.", "UX/UI", 0 },
                    { 4, "İnsan psikolojisi.", "Akıl Sağlığı", 0 },
                    { 5, "Dünya'nın her yerinden farklı kültürler.", "Bilim", 0 },
                    { 6, "Bilimin ve yapay zekanın birleşmesiyle oluşan ilginç ve bir o kadar da eğlenceli içerik.", "Makine Öğrenmesi", 0 },
                    { 7, "İlişkiler hakkında her şey.", "İlişkiler", 0 },
                    { 8, "Dünya'nın her yerinden farklı kültürler.", "Kültür", 0 },
                    { 9, "Geçmiş zamanın incelenmesi bilimi.", "Tarih", 0 },
                    { 10, "Sanata dair her şey.", "Art", 0 }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Article Content", "Article Title", "CategoryId", "CreationDate", "Image", "IsDeleted", "NumberOfLikes", "State", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, "İnşaat alanında erkeklerin hakimiyeti var ancak bu, kadınların bu sektöre uyum sağlamadığı anlamına gelmiyor. Giderek daha fazla kadın bu alana katıldıkça, geçmişteki stereotipler ve engeller yıkılıyor. Bu, kadınların sektöre kattığı değer ve 'dışarıdaki' konumunu nasıl aşabileceğimizle ilgili bir hikaye.Mimarlıkta çalışan bir kadın olarak her zaman yabancısınızdır. Sorun değil, sınırda olmayı seviyorum. Pritzker Ödülü sahibi mimar Zaha Hadid.Rakamlar cesaretimizi kırmamalıUlusal İstatistik Ofisi'ne (ONS) göre Birleşik Krallık'ta inşaat işçilerinin yalnızca %15'i kadındı.ABD'de %14 (2022) AB'de yalnızca %10 (2021).Rakamların bizi durdurmasına izin mi vermeliyiz? Kesinlikle hayır. Günümüzün modern kadını, kendisinden önceki pek çok kadın gibi, yabancı olarak algılanmaktan korkmuyor. Kendi yolumuzu açabiliriz, sevdiğimiz insanlardan ve en önemlisi kendimizden destek bulabiliriz.O patron olduğundaİnşaatta çalışmanın ne kadar zor olduğunu anlatmaya gerek yok. Bir mimar olarak benim hem ofiste hem de şantiyede bulunmam gerekiyor.Ne zaman inşaat sahasına gönderilsem, bu deneyime son derece değer veriyordum. Çünkü konfor alanından çıkmak sizi geliştirir ve sonunda kendinizin daha iyi bir versiyonunu ortaya çıkarır.", "İnşaat Sektöründe Kadınlar: Tüm Engelleri Aşıyoruz", 2, new DateTime(2023, 8, 24, 21, 35, 0, 0, DateTimeKind.Unspecified), "/image/insaatsektorundekadinlar.png", false, 710, "Created", 1, 890 },
                    { 2, "1. Programlama kitaplarını okumak.Programlama dilleri, proje mimarisi, en iyi uygulamalar, farklı teknolojiler ve teoriler üzerine kitaplar okumak öğrenmeme ve becerilerimi geliştirmeme yardımcı oldu.“Paranızın karşılığını en iyi şekilde almak için çantanızı kafanıza dökün.” - Benjamin Franklin. 2. Eğiticileri izlemek.Eğitimler, tam bir program/uygulama oluşturmak için teknolojilerin birlikte nasıl çalıştığını ve yeni bir şeyin nasıl yapılacağını anlamanıza yardımcı olur.Nasıl yapacağımı öğrenmek için her zaman yapamadığım şeyleri yapıyorum.-Pablo Picasso 3. Her gün bir şeyler inşa etmek Öğreticilerle sınıflarla birlikte oluşturmaya başlayın ve kendi fikirlerinizi oluşturmaya çalışın.Wes Bos'un 30 günde 30 küçük projeden oluşan JavaScript30 kursu, başlamak için harika bir yerdir.“Söyle bana unuturum, öğret bana hatırlayayım, beni dahil edersen öğrenirim.” - Benjamin Franklin 4. Kendi projelerimi başlatmak.Kendi uygulamanızı oluşturmak için anlamanız gereken birçok ayrıntı var.Kendi projenizi hayata geçirmek, becerilerinizi geliştirmek için deneyim kazanmanıza yardımcı olacaktır.Twos , 7 Level Deep , Aware ve Müse'yi ben yaptım.Küçük şeyler büyük şeylerin gerçekleşmesini sağlar. — John Wooden. 5. Mülakatlara hazırlanmak.Programlama işi, geliştirici olarak öğrenmenin ve büyümenin bir yolu olabilir..İyi bir işe girebilmek için temel programlama kavramları ve problem çözme becerileriyle hazırlanmanız gerekir.Kodlama röportajını kırma kitabını okumanızı ve LeetCode'da çevrimiçi kodlama testleri yapmanızı öneririm .", "Beni Daha İyi Bir Yazılım Mühendisi Yapan 7+ Alışkanlık", 1, new DateTime(2023, 6, 17, 9, 42, 0, 0, DateTimeKind.Unspecified), "/image/beniiyibiryazilimci.png", false, 510, "Created", 2, 1950 },
                    { 3, "Ecocline'ın 2016'daki son yeniden tasarımından sonra, artık zamanın ötesinde olduğunu düşünüyorum. Planım mümkün olduğunca mevcut tasarıma sadık kalmak ve daha iyi kullanılabilirlik ve erişilebilirlik için gerekenleri değiştirmekti. Ancak küçük değişikliklerin bile bilgi çıktısı ve tüm otobüs yolculuğunun hikayesinin anlatılma şekli üzerinde büyük etkisi olabilir.Uygulama Ecolines, 22 ülkede 200 otobüsten oluşan bir filodan oluşan bir otobüs seyahat şirketidir. Maalesef mobil uygulamaları kötü kullanılabilirliğin mükemmel bir örneğidir. İyileştirilecek çok yer var. Biraz pratik kazanmak için 5 gün içinde mümkün olduğunca çok sayıda küçük sorunu çözmek istedim. Bu yüzden onu seçtim.FikirUX/UI tasarımcıları olarak görevimiz, her şeyi işlevsel ve kullanışlı hale getirmek[…] Planım uygulamayı yeniden icat etmek ya da genel olarak yeniden yapılandırmak değildi. Yapmaya çalıştığım şey mümkün olduğu kadar mevcut tasarıma bağlı kalmak ve daha iyi kullanılabilirlik ve karışıklığı önlemek için gerekenleri değiştirmek. Sezgisel hata düzeltmeye, bilgi mimarisinde hafif bir basitleştirmeye ve daha iyi erişilebilirliğe odaklandım. Hazırlık :Kullanıcı arayüzündeki daha küçük sorunları çözmek için, öncelikle varsayımları el çizimleriyle veya düşük kaliteli tel çerçevelerle test etmeye gerçekten gerek yoktu. Bu yüzden yalnızca yüksek sadakatle çalışmayı seçtim. Kağıt kalem kullanan biri olarak eskiz yapmamak alışılmadık bir durumdu ama bu durumda çok zaman kazandırdı. Başlamadan önce, her sorunu kırmızı bir kutuyla vurgulayarak her ekranı analiz etmem gerekiyordu.", "Temel Esaslar — Minimal Bir Tasarım Müdahalesi", 3, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "/image/uxUi.png", false, 3050, "Created", 1, 7850 },
                    { 4, "Bir zamanlar evrenden beklediğim kişiyle tanıştım. Hatta tam benim istediğim şekilde tanıştık.Tek başıma bir kaya tırmanışı yolculuğundaydım ve bir dizi önemli ve beklenmedik olaydan sonra, uzak bir çiftlikte kalan tek iki kişi bizdik.Tanıştığımız ilk akşam, gece geç saatlere kadar derin bir sohbet yaşadık. O andan itibaren kalçadan birleşmiştik. Heyecan verici bir macera yaşadık; tırmanmak, sevişmek ve ülkeyi baştan başa gezmek. Ruhumuzu ortaya döktük ve zor zamanlarda birbirimize yardım ettik. Bu yolculuğun sonunda onun eyaletine taşınmaya karar verdim.Mükemmel bir peri masalı gibi görünüyordu. Ama yine de değildi.Duygusal olarak güvende olduğum tek bir an bile olmadı ama kendimi derinden yalnız hissettiğim birçok an oldu.Bu kafa karıştırıcıydı. İstediğim tam olarak bu değil miydi?Artık evrene bir ilişkide ne yapmak istediğimi söylediğimi ama nasıl hissetmek istediğimi söylemediğimi fark ettim .Dışarıdan bakıldığında aynı yaşam tarzı hedeflerine, aynı tutkulara ve aynı ilgi alanlarına sahiptik. İçsel olarak; duyguları farklı bir şekilde ilettik, çatışmaları zıt kutuplarda çözdük ve birbiriyle uyuşmayan zihniyetlere sahiptik.Ayrıldık.Sorulduğunda neyin yanlış olduğunu tam olarak ifade edemedim ama hiçbir şeyin tam olarak doğru gelmediğini biliyordum.O ilişkiden sonra istediğimin tam tersi olan biriyle tanıştım. En azından kağıt üzerinde. Aynı yaşam tarzı hedeflerimize sahip değildik, ilk gün aramızda parlak bir kimya yoktu ve hayatta çok farklı yollardaydık.Ama bugün, yıllar sonra onunla geçirilen her an saf mutluluktur. Hiç bu kadar gerçekten görüldüğümü ve olduğum kişi olarak hayran olduğumu hissetmemiştim. Günlerimiz şaşırtıcı eğlencelerle dolu. Tanıştığımızda hayatta çok farklı yörüngelerde olsak da, bugün bir şekilde mükemmel bir şekilde hizalanmış bir gerçekliği birlikte yaratmış gibiydik.Nasıl bu kadar yanlış anladım?", "İstatistiksel Olarak Yanlış Kişiyle Evleneceksiniz. İşte Nedeni!", 7, new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "/image/iliskipng.png", false, 2550, "Created", 3, 18850 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
