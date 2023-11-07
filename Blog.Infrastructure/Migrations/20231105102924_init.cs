using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsLetters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Details", "Details2", "ImageUrl", "ImageUrl2", "MapLocation", "Status" },
                values: new object[] { 1, "Blog (Türkçe: ağ günlüğü, günce) veya Weblog (Türkçe: Ağ kütüğü) teknik bilgi gerektirmeden, kendi istedikleri şeyleri, kendi istedikleri şekilde yazan insanların oluşturabildikleri, günlüğe benzeyen web siteleridir. Genellikle güncelden eskiye doğru sıralanmış yazı ve yorumların yayınlandığı, web tabanlı bir yayını belirtir. Çoğunlukla her gönderinin sonunda yazarın adı ve gönderi zamanı belirtilir. Yayıncının seçimine göre okuyucular yazılara yorum yapılabilir. Yorumlar, blog kültürünün çok önemli bir dinamiğidir; bu sayede yazar ve okuyucular arasında iletişim sağlanır. Bunun dışında, geri izleme (trackback) mekanizmasıyla, belirli bir yazı hakkında yazılan diğer yazıların belirlenebilmesi de mümkündür.[1]\r\n\r\nGönderiler genellikle ters kronolojik sırada görüntülenir, böylece en son gönderi web sayfasının en üstünde ilk olarak görünür. 2009 yılına kadar, bloglar genellikle tek bir kişinin, ara sıra küçük bir grubun çalışmasıydı ve genellikle tek bir konuyu kapsıyordu. 2010'larda, birden çok yazarın yazılarını içeren ve bazen profesyonelce düzenlenen \"çok yazarlı bloglar\" (MAB'ler) ortaya çıktı. Gazetelerden, diğer medya kuruluşlarından, üniversitelerden, düşünce kuruluşlarından, savunuculuk gruplarından ve benzer kurumlardan gelen MAB'ler, artan miktarda blog trafiğinden sorumludur. Twitter ve diğer \"mikroblog\" sistemlerinin yükselişi, MAB'lerin ve tek yazarlı blogların haber medyasına entegre edilmesine yardımcı olur. 2010 yıllarından sonra özellikle mobil blog'lar popüler oldu.[2] Sosyal medya ve sosyal ağ'ların yaygınlaşması ile bloglar bunlarla artık gevşek bir şekilde kullanılmaktadır.\r\n\r\nİlk bloglar elle yazılıp güncellenirken, bugün bu iş için özel yazılmış yazılımlar kullanılmaktadır. Bu yazılımlardan bazıları bir blog servisi sağlayıcı sitenin alt alan adları olarak yaratılabilen, bazıları ise kullanıcının kendi sunucusuna kurup çalıştırması gereken Blogger, Blogcu.com, WordPress, SpinMedia, joomla, Drupal gibi yazılımlardır.[3]\r\n\r\nPek çok blog, felsefe, din ve sanattan bilim, siyaset ve spora kadar belirli bir konular hakkında yorumlar sağlar. Diğerleri, daha kişisel çevrimiçi günlükler veya belirli bir kişi veya şirketin çevrimiçi marka reklamı işlevi görür. Tipik bir blog, metni, dijital görüntüleri ve diğer bloglara, web sayfalarına ve konusuyla ilgili diğer medyaya bağlantıları birleştirir. Bazıları kişisel (kişisel blog), haber (haber blogu), bilim (bilim blogu), sanat (sanat blogu), moda (moda blogu), felsefe (felsefe blogu), işletme (işletme blogu), fitness (fitness blogu), teknoloji (teknoloji blogu), kitap (kitap blogu), tasarım (tasarım blogu), yemek (yemek blogu), savaş (savaş blogu), teknoloji (teknoloji blogu), siyaset (siyasi blog), ekonomi (ekonomi blogu), hukuk (hukuk blogu), kurumsal (kurumsal blog), feminist (feminist blog), fotoğraflar (fotoblog), videolar (video blogları veya \"vlog'lar\"), müzik (MP3 blogu) ve ses (podcast'ler) konularına odaklansa da, çoğu blog esas olarak metinseldir.[4] Eğitimde, bloglar öğretim kaynakları olarak kullanılabilir; bunlara edublog'lar denir. Edebi blog'lar edebiyatla ilgili bloglardır. Mikroblog, çok kısa gönderiler içeren başka bir blog türüdür. 2022'ye ait bir tahmin, 1,9 milyardan fazla web sitesinden 600 milyondan fazla genel blog olduğunu öne sürdü. Blog oluşturanlara blogcu veya bloger denir. Bunlar çoğunlukla kamusal figür, internet ünlüsü ve diğer sosyal etki'si olan kişilerdir.\r\n\r\nİngilizcedeki \"web\" ve \"log\" kelimelerinin birleşmesinden oluşan weblog kavramının zamanla yaygınlaşmış adıdır.", null, null, null, null, true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { 1, null, "Yazılım", true },
                    { 2, null, "Oyun", true },
                    { 3, null, "Film", true },
                    { 4, null, "Teknoloji", true }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "About", "ImageUrl", "Mail", "Name", "Password", "Status" },
                values: new object[,]
                {
                    { 1, "Deneme", null, "bahadirhakan@blog.com", "Bahadır Hakan", "111", true },
                    { 2, "Deneme", null, "aysecinar@blog.com", "Ayşe Çınar", "333", true },
                    { 3, "Deneme", null, "cemkaya@blog.com", "Cem Kaya", "000", true }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CategoryId", "Content", "CreateDate", "ImageUrl", "Status", "ThumbnailImage", "Title", "WriterId" },
                values: new object[,]
                {
                    { 1, 4, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Architecto, rerum aliquid? Quam culpa quis inventore recusandae itaque. Quo quas tempora, voluptatibus ab, sunt quis ex quasi fugiat iusto modi explicabo quos rerum consequatur quibusdam fuga laborum iure nam architecto. Placeat qui hic porro suscipit voluptate. Placeat aliquid animi delectus perspiciatis quidem, quo illum nihil obcaecati quisquam, modi, eius unde impedit deleniti sunt eligendi voluptates reprehenderit. Nihil incidunt dolor blanditiis sequi illum, neque molestias quidem laborum dolore ea ipsam at culpa inventore facilis aperiam impedit quo nostrum atque architecto accusamus. Optio praesentium impedit eveniet deleniti atque amet aperiam ab, recusandae quaerat nihil culpa magnam eligendi sapiente ea fugit, accusantium temporibus voluptates dolorum sit aut est. Dolore dolores, consequuntur minus ipsa, eos exercitationem similique quibusdam quos inventore earum maxime molestiae, id ut omnis blanditiis alias sunt totam ad ex consequatur assumenda nihil excepturi dolorum? Molestias at, blanditiis magni libero neque recusandae suscipit voluptatem quibusdam delectus impedit earum illo reprehenderit eligendi quasi labore laudantium iure nam similique quis eum velit. Soluta unde odio explicabo est vel. Quo placeat culpa accusantium similique voluptas aliquam libero nisi saepe vero, iusto totam tenetur pariatur facere commodi, necessitatibus explicabo sapiente fugit hic quisquam modi! Nisi, impedit voluptatibus.", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "/web/images/5.jpg", true, null, "İphone 15 Tanıtıldı", 1 },
                    { 2, 3, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Inventore, iusto reprehenderit quisquam officiis quae illo ab facere veniam, commodi consequatur corrupti aut a suscipit, nam omnis? Dolor, totam! Esse, eveniet expedita in amet necessitatibus dignissimos, asperiores optio adipisci sapiente obcaecati nam? Enim numquam soluta voluptas, ducimus ab nobis consequatur. Cumque eaque expedita voluptates minima, nostrum laborum itaque obcaecati delectus aliquam officiis illo, repudiandae alias sapiente. Ullam culpa libero perferendis id praesentium nemo autem odit illum totam! Totam quae natus aliquid sunt? Illo, at sed? Ab, id? Ut culpa eaque, in deserunt dicta corporis animi numquam repudiandae porro libero totam amet tempore non ducimus odio hic fugit! Nobis consectetur quibusdam ullam velit sapiente praesentium aspernatur voluptates omnis voluptas delectus nam quisquam magni deserunt, cumque impedit, totam quae atque optio officia esse facilis! Fuga, veritatis obcaecati. Omnis, nulla natus! Ipsam, blanditiis autem excepturi, ullam ducimus ut eligendi officiis aperiam ipsum numquam laborum sapiente doloremque consequatur placeat voluptatum quisquam at saepe dolores iure maiores. Dignissimos eos atque eligendi impedit itaque eveniet cum id quod tenetur quam illo soluta optio nihil maxime, corrupti alias fugit iusto unde officia repellat. Deleniti, veniam! Quod sed vitae rem blanditiis similique unde molestias dignissimos nisi possimus. Eum, itaque?", new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "/web/images/2.jpg", true, null, "Kimyager: Walter White", 2 },
                    { 3, 2, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni quos harum in! Deserunt dicta dolore, ea vero eos fugit expedita voluptatum eius pariatur error assumenda nihil, illo quaerat a alias, obcaecati animi quibusdam quam consectetur quisquam fugiat? Sequi quas eos temporibus officiis excepturi sunt vero praesentium id quibusdam! Officiis ab repellat inventore qui enim quae ipsum consequuntur, temporibus harum culpa maxime est doloribus provident a magnam unde at saepe nostrum similique eaque corrupti adipisci dolor amet commodi! Atque id aspernatur impedit molestiae autem? Impedit rerum inventore molestiae ipsa similique aliquam iste amet debitis placeat! Fugit praesentium eligendi officiis ullam, sint distinctio, neque ratione maiores consequatur in, quasi facilis nesciunt dolorem. Fugiat quibusdam harum impedit tempore ipsa, tenetur ipsum id deleniti?", new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "/web/images/3.jpg", true, null, "Fifa 2022 Ekim Sonunda Çıkıyor", 3 },
                    { 4, 3, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Iure corporis quasi sunt exercitationem, consequatur, optio dolores eum totam omnis nesciunt dolor veniam repudiandae atque alias veritatis iusto? Odit voluptatibus sapiente aliquid. Dicta dolores possimus harum voluptas iusto labore, mollitia atque alias id debitis dignissimos in cum illo corrupti! Doloremque quod, necessitatibus ducimus saepe optio iusto possimus quasi at sed magnam fuga perspiciatis beatae vero modi recusandae fugit! Saepe doloremque veritatis accusamus exercitationem a consequuntur natus aliquam, provident impedit iste modi nam corporis quidem minus, earum magni nesciunt, illo facere molestias dolor alias maiores! Tenetur dolores architecto numquam fugiat voluptates fugit. Rem eligendi explicabo aliquid corporis recusandae repellendus magni sit voluptatem necessitatibus quas magnam consectetur cumque accusamus placeat, ratione similique sed accusantium cum beatae, adipisci fugit nobis excepturi perferendis! Suscipit nam eius cum voluptate impedit, repudiandae, laudantium explicabo nisi molestiae eos fugiat cupiditate. Ipsam cupiditate quidem quo in cum, soluta et dolores repellendus porro ut nesciunt odit quasi necessitatibus maiores! Praesentium dolorum, doloribus porro odit laboriosam repellat. Aperiam quas hic optio provident rerum nostrum facere sit commodi eum alias, atque neque.", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "/web/images/1.jpg", true, null, "Into The Night", 1 },
                    { 5, 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque voluptatibus temporibus numquam iure minima quam animi sit, laudantium quia fugit ea error. Nemo itaque repellendus placeat reiciendis voluptates rerum quidem voluptatibus autem a dicta voluptas, ratione quod repellat corrupti eum veniam inventore illo natus qui animi! Id minima a temporibus voluptas modi aperiam dolore, aliquid non sapiente ullam rem nobis, repudiandae magnam qui aspernatur, quibusdam nemo saepe. Sunt exercitationem aliquid nihil ducimus vitae quam soluta, eveniet neque aspernatur praesentium aut officiis quidem totam impedit, sint voluptatem earum, veritatis cum voluptates atque iure? Quisquam vero esse nostrum architecto. Molestias soluta neque voluptas voluptates rerum velit laudantium ex in odio consectetur aut amet possimus culpa commodi natus quibusdam nam maxime tempore eveniet, nostrum cupiditate aperiam eaque. Culpa temporibus placeat officiis architecto voluptatem illo ex nam consequuntur illum fugiat nihil similique officia quidem exercitationem sapiente, tenetur minus! Labore hic, aut rem ea aspernatur nulla, magni a quaerat cupiditate laudantium error autem velit mollitia perspiciatis beatae dolor assumenda, maiores possimus voluptatibus quisquam accusamus quo doloribus alias corporis. Ex dignissimos aperiam eos qui ut sequi vel illo, voluptate voluptas ullam iste reiciendis? Tenetur at voluptas laboriosam ad dolor. Quidem id unde nemo sint consectetur consequuntur laudantium incidunt. Sit porro odio dolorum quaerat assumenda modi quo molestias vero hic, voluptas molestiae iusto quos? Facere, reiciendis a fugit architecto libero, cumque, perspiciatis reprehenderit hic earum dolor pariatur dolorem! Quia expedita architecto maxime ea fuga veritatis eius ratione. Neque quas beatae porro excepturi veniam! Ipsum dolore voluptas rerum.", new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "/web/images/8.jpg", true, null, "Pyhton ile Veri Analizi", 1 },
                    { 6, 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus porro perspiciatis, fugiat qui vel voluptatibus voluptatum molestias harum expedita quasi. Odit facere, iste excepturi qui exercitationem maxime numquam dolores, aperiam error provident commodi. Neque beatae alias necessitatibus perspiciatis aliquam molestias accusantium odio nam cumque ad ipsa, incidunt fuga quisquam. Asperiores minima tempore molestiae itaque voluptate officiis dolorum similique quas excepturi, repellat animi aliquid magni sint tempora earum amet? Dolores laudantium atque velit est corrupti dolore, vel possimus accusamus nemo, quisquam tempore repellendus id. Ducimus dolores dolor accusantium repudiandae nam esse corporis iusto vitae iure exercitationem quasi error voluptas eveniet autem sit dolorum facere, ipsa neque quaerat ipsum at rerum cum. Accusamus exercitationem harum omnis in officiis ullam quaerat. Sint necessitatibus nam illum quo neque mollitia dolores delectus, molestiae, unde doloribus ea eos inventore incidunt, quam iste magnam porro fuga a numquam assumenda? Ullam nihil illo praesentium esse facere sint. Animi dolore laudantium iste facere nobis fugit nostrum assumenda itaque praesentium. Nihil voluptate ea voluptatum, suscipit veritatis cupiditate quam vitae rem dolores omnis animi consequuntur ad magni maiores! Totam distinctio omnis saepe sunt enim ex dolorem, laborum, mollitia deleniti ducimus qui cupiditate doloribus quam architecto velit ut a, ab quisquam optio? Accusamus, ipsam eligendi. Accusantium aspernatur sit quas nemo explicabo magnam aliquam odit quisquam quasi quia odio tempore, molestiae labore est rerum mollitia dicta maxime alias perferendis soluta ratione. Earum, tempore?", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "/web/images/6.jpg", true, null, "C# ile Asenkron Metodlar", 2 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BlogId", "Content", "Date", "Status", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, 4, "çok faydalı bir içerik!", new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Teşekkürler", "Ali Yıldırım" },
                    { 2, 3, "çok ama çok beğendim kaleminize sağlık.", new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Harika", "Gizem Çınar" },
                    { 3, 2, "merhaba içerik biraz daha genişletilebilirse daha faydalı olur.", new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Tavsiye", "Aslı Yıldız" },
                    { 4, 4, "bu içeriği herkese öneriyorum.", new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Öneri", "Mert Kaya" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WriterId",
                table: "Blogs",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "NewsLetters");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
