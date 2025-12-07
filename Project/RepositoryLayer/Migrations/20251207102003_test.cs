using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Call = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaceBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaceBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portafolios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portafolios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portafolios_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Clients = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Projects = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    HoursOfSupport = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    HardWorkers = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMediaId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutUs_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "7/12/2025", "Projects", null },
                    { 2, "7/12/2025", "SiteWorks", null }
                });

            migrationBuilder.InsertData(
                table: "ContactUs",
                columns: new[] { "Id", "Call", "CreateDate", "Email", "Location", "Map", "UpdateDate" },
                values: new object[] { 1, "1246556956", "7/12/2025", "test@try.com", "Iron streen, Brave Avenue, KD1, 2CF, London", "TestLink Here", null });

            migrationBuilder.InsertData(
                table: "HomePages",
                columns: new[] { "Id", "CreateDate", "Description", "Header", "UpdateDate", "VideoLink" },
                values: new object[] { 1, "7/12/2025", "Esta es la descripción de HomePage", "Este es el header de homePage", null, "Test Video Link" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreateDate", "Description", "Icon", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "7/12/2025", "Esta es la descripción de service 1", "bi bi-service1", "Plumbing service 1", null },
                    { 2, "7/12/2025", "Esta es la descripción de service 2", "bi bi-service2", "Plumbing service 2", null },
                    { 3, "7/12/2025", "Esta es la descripción de service 3", "bi bi-service3", "Plumbing service 3", null }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreateDate", "FaceBook", "Instagram", "Linkedin", "Twitter", "UpdateDate" },
                values: new object[] { 1, "7/12/2025", "testFacebook", "testInstagram", null, null, null });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreateDate", "FaceBook", "FileName", "FileType", "FullName", "Instagram", "Linkedin", "Title", "Twitter", "UpdateDate" },
                values: new object[] { 1, "7/12/2025", "facebook", "test", "test", "Jonh Black", "instragram", null, "Professor", null, null });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Comment", "CreateDate", "FileName", "FileType", "FullName", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Este es el comentario del testimonio", "7/12/2025", "test", "test", "Merlyn Monroe", "Interesting", null },
                    { 2, "Este es el comentario del testimonio", "7/12/2025", "test", "test", "Jackie Chan", "Interesting", null },
                    { 3, "Este es el comentario del testimonio", "7/12/2025", "test", "test", "Bruce Wills", "Interesting", null }
                });

            migrationBuilder.InsertData(
                table: "AboutUs",
                columns: new[] { "Id", "Clients", "CreateDate", "Description", "FileName", "FileType", "HardWorkers", "Header", "HoursOfSupport", "Projects", "SocialMediaId", "UpdateDate" },
                values: new object[] { 1, 5, "7/12/2025", "Esta es la descripción", "test", "test", 3, "Este es el header", 150, 5, 1, null });

            migrationBuilder.InsertData(
                table: "Portafolios",
                columns: new[] { "Id", "CategoryId", "CreateDate", "FileName", "FileType", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, "7/12/2025", "Test", "test", "Test Picture", null },
                    { 2, 1, "7/12/2025", "Test2", "test2", "Test Picture2", null },
                    { 3, 2, "7/12/2025", "Test3", "test3", "Test Picture3", null },
                    { 4, 2, "7/12/2025", "Test4", "test4", "Test Picture4", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_SocialMediaId",
                table: "AboutUs",
                column: "SocialMediaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portafolios_CategoryId",
                table: "Portafolios",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "HomePages");

            migrationBuilder.DropTable(
                name: "Portafolios");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
