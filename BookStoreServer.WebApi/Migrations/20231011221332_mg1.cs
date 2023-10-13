using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BooksCategories",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksCategories", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BooksCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "CreatedAt", "ISBN", "IsActive", "IsDeleted", "Price", "Quantity", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "Author1", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7737), "ISBN1", true, false, 10m, 10, "Summary1", "Book1" },
                    { 2, "Author2", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7741), "ISBN2", true, false, 10m, 10, "Summary2", "Book2" },
                    { 3, "Author3", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7743), "ISBN3", true, false, 10m, 10, "Summary3", "Book3" },
                    { 4, "Author4", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7745), "ISBN4", true, false, 10m, 10, "Summary4", "Book4" },
                    { 5, "Author5", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7747), "ISBN5", true, false, 10m, 10, "Summary5", "Book5" },
                    { 6, "Author6", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7750), "ISBN6", true, false, 10m, 10, "Summary6", "Book6" },
                    { 7, "Author7", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7752), "ISBN7", true, false, 10m, 10, "Summary7", "Book7" },
                    { 8, "Author8", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7754), "ISBN8", true, false, 10m, 10, "Summary8", "Book8" },
                    { 9, "Author9", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7756), "ISBN9", true, false, 10m, 10, "Summary9", "Book9" },
                    { 10, "Author10", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7759), "ISBN10", true, false, 10m, 10, "Summary10", "Book10" },
                    { 11, "Author11", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7761), "ISBN11", true, false, 10m, 10, "Summary11", "Book11" },
                    { 12, "Author12", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7762), "ISBN12", true, false, 10m, 10, "Summary12", "Book12" },
                    { 13, "Author13", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7764), "ISBN13", true, false, 10m, 10, "Summary13", "Book13" },
                    { 14, "Author14", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7766), "ISBN14", true, false, 10m, 10, "Summary14", "Book14" },
                    { 15, "Author15", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7768), "ISBN15", true, false, 10m, 10, "Summary15", "Book15" },
                    { 16, "Author16", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7770), "ISBN16", true, false, 10m, 10, "Summary16", "Book16" },
                    { 17, "Author17", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7772), "ISBN17", true, false, 10m, 10, "Summary17", "Book17" },
                    { 18, "Author18", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7774), "ISBN18", true, false, 10m, 10, "Summary18", "Book18" },
                    { 19, "Author19", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7776), "ISBN19", true, false, 10m, 10, "Summary19", "Book19" },
                    { 20, "Author20", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7778), "ISBN20", true, false, 10m, 10, "Summary20", "Book20" },
                    { 21, "Author21", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7779), "ISBN21", true, false, 10m, 10, "Summary21", "Book21" },
                    { 22, "Author22", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7781), "ISBN22", true, false, 10m, 10, "Summary22", "Book22" },
                    { 23, "Author23", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7783), "ISBN23", true, false, 10m, 10, "Summary23", "Book23" },
                    { 24, "Author24", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7784), "ISBN24", true, false, 10m, 10, "Summary24", "Book24" },
                    { 25, "Author25", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7786), "ISBN25", true, false, 10m, 10, "Summary25", "Book25" },
                    { 26, "Author26", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7788), "ISBN26", true, false, 10m, 10, "Summary26", "Book26" },
                    { 27, "Author27", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7789), "ISBN27", true, false, 10m, 10, "Summary27", "Book27" },
                    { 28, "Author28", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7791), "ISBN28", true, false, 10m, 10, "Summary28", "Book28" },
                    { 29, "Author29", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7793), "ISBN29", true, false, 10m, 10, "Summary29", "Book29" },
                    { 30, "Author30", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7816), "ISBN30", true, false, 10m, 10, "Summary30", "Book30" },
                    { 31, "Author31", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7818), "ISBN31", true, false, 10m, 10, "Summary31", "Book31" },
                    { 32, "Author32", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7820), "ISBN32", true, false, 10m, 10, "Summary32", "Book32" },
                    { 33, "Author33", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7822), "ISBN33", true, false, 10m, 10, "Summary33", "Book33" },
                    { 34, "Author34", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7824), "ISBN34", true, false, 10m, 10, "Summary34", "Book34" },
                    { 35, "Author35", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7826), "ISBN35", true, false, 10m, 10, "Summary35", "Book35" },
                    { 36, "Author36", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7828), "ISBN36", true, false, 10m, 10, "Summary36", "Book36" },
                    { 37, "Author37", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7829), "ISBN37", true, false, 10m, 10, "Summary37", "Book37" },
                    { 38, "Author38", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7831), "ISBN38", true, false, 10m, 10, "Summary38", "Book38" },
                    { 39, "Author39", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7833), "ISBN39", true, false, 10m, 10, "Summary39", "Book39" },
                    { 40, "Author40", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7835), "ISBN40", true, false, 10m, 10, "Summary40", "Book40" },
                    { 41, "Author41", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7836), "ISBN41", true, false, 10m, 10, "Summary41", "Book41" },
                    { 42, "Author42", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7838), "ISBN42", true, false, 10m, 10, "Summary42", "Book42" },
                    { 43, "Author43", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7840), "ISBN43", true, false, 10m, 10, "Summary43", "Book43" },
                    { 44, "Author44", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7842), "ISBN44", true, false, 10m, 10, "Summary44", "Book44" },
                    { 45, "Author45", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7844), "ISBN45", true, false, 10m, 10, "Summary45", "Book45" },
                    { 46, "Author46", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7845), "ISBN46", true, false, 10m, 10, "Summary46", "Book46" },
                    { 47, "Author47", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7847), "ISBN47", true, false, 10m, 10, "Summary47", "Book47" },
                    { 48, "Author48", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7849), "ISBN48", true, false, 10m, 10, "Summary48", "Book48" },
                    { 49, "Author49", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7851), "ISBN49", true, false, 10m, 10, "Summary49", "Book49" },
                    { 50, "Author50", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7852), "ISBN50", true, false, 10m, 10, "Summary50", "Book50" },
                    { 51, "Author51", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7854), "ISBN51", true, false, 10m, 10, "Summary51", "Book51" },
                    { 52, "Author52", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7856), "ISBN52", true, false, 10m, 10, "Summary52", "Book52" },
                    { 53, "Author53", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7858), "ISBN53", true, false, 10m, 10, "Summary53", "Book53" },
                    { 54, "Author54", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7859), "ISBN54", true, false, 10m, 10, "Summary54", "Book54" },
                    { 55, "Author55", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7861), "ISBN55", true, false, 10m, 10, "Summary55", "Book55" },
                    { 56, "Author56", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7863), "ISBN56", true, false, 10m, 10, "Summary56", "Book56" },
                    { 57, "Author57", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7865), "ISBN57", true, false, 10m, 10, "Summary57", "Book57" },
                    { 58, "Author58", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7866), "ISBN58", true, false, 10m, 10, "Summary58", "Book58" },
                    { 59, "Author59", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7884), "ISBN59", true, false, 10m, 10, "Summary59", "Book59" },
                    { 60, "Author60", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7886), "ISBN60", true, false, 10m, 10, "Summary60", "Book60" },
                    { 61, "Author61", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7888), "ISBN61", true, false, 10m, 10, "Summary61", "Book61" },
                    { 62, "Author62", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7890), "ISBN62", true, false, 10m, 10, "Summary62", "Book62" },
                    { 63, "Author63", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7892), "ISBN63", true, false, 10m, 10, "Summary63", "Book63" },
                    { 64, "Author64", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7894), "ISBN64", true, false, 10m, 10, "Summary64", "Book64" },
                    { 65, "Author65", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7896), "ISBN65", true, false, 10m, 10, "Summary65", "Book65" },
                    { 66, "Author66", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7898), "ISBN66", true, false, 10m, 10, "Summary66", "Book66" },
                    { 67, "Author67", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7900), "ISBN67", true, false, 10m, 10, "Summary67", "Book67" },
                    { 68, "Author68", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7902), "ISBN68", true, false, 10m, 10, "Summary68", "Book68" },
                    { 69, "Author69", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7903), "ISBN69", true, false, 10m, 10, "Summary69", "Book69" },
                    { 70, "Author70", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7905), "ISBN70", true, false, 10m, 10, "Summary70", "Book70" },
                    { 71, "Author71", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7907), "ISBN71", true, false, 10m, 10, "Summary71", "Book71" },
                    { 72, "Author72", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7908), "ISBN72", true, false, 10m, 10, "Summary72", "Book72" },
                    { 73, "Author73", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7910), "ISBN73", true, false, 10m, 10, "Summary73", "Book73" },
                    { 74, "Author74", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7912), "ISBN74", true, false, 10m, 10, "Summary74", "Book74" },
                    { 75, "Author75", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7914), "ISBN75", true, false, 10m, 10, "Summary75", "Book75" },
                    { 76, "Author76", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7915), "ISBN76", true, false, 10m, 10, "Summary76", "Book76" },
                    { 77, "Author77", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7917), "ISBN77", true, false, 10m, 10, "Summary77", "Book77" },
                    { 78, "Author78", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7919), "ISBN78", true, false, 10m, 10, "Summary78", "Book78" },
                    { 79, "Author79", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7921), "ISBN79", true, false, 10m, 10, "Summary79", "Book79" },
                    { 80, "Author80", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7922), "ISBN80", true, false, 10m, 10, "Summary80", "Book80" },
                    { 81, "Author81", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7924), "ISBN81", true, false, 10m, 10, "Summary81", "Book81" },
                    { 82, "Author82", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7926), "ISBN82", true, false, 10m, 10, "Summary82", "Book82" },
                    { 83, "Author83", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7927), "ISBN83", true, false, 10m, 10, "Summary83", "Book83" },
                    { 84, "Author84", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7929), "ISBN84", true, false, 10m, 10, "Summary84", "Book84" },
                    { 85, "Author85", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7931), "ISBN85", true, false, 10m, 10, "Summary85", "Book85" },
                    { 86, "Author86", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7948), "ISBN86", true, false, 10m, 10, "Summary86", "Book86" },
                    { 87, "Author87", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7951), "ISBN87", true, false, 10m, 10, "Summary87", "Book87" },
                    { 88, "Author88", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7953), "ISBN88", true, false, 10m, 10, "Summary88", "Book88" },
                    { 89, "Author89", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7954), "ISBN89", true, false, 10m, 10, "Summary89", "Book89" },
                    { 90, "Author90", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7956), "ISBN90", true, false, 10m, 10, "Summary90", "Book90" },
                    { 91, "Author91", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7958), "ISBN91", true, false, 10m, 10, "Summary91", "Book91" },
                    { 92, "Author92", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7960), "ISBN92", true, false, 10m, 10, "Summary92", "Book92" },
                    { 93, "Author93", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7961), "ISBN93", true, false, 10m, 10, "Summary93", "Book93" },
                    { 94, "Author94", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7963), "ISBN94", true, false, 10m, 10, "Summary94", "Book94" },
                    { 95, "Author95", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7965), "ISBN95", true, false, 10m, 10, "Summary95", "Book95" },
                    { 96, "Author96", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7967), "ISBN96", true, false, 10m, 10, "Summary96", "Book96" },
                    { 97, "Author97", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7969), "ISBN97", true, false, 10m, 10, "Summary97", "Book97" },
                    { 98, "Author98", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7970), "ISBN98", true, false, 10m, 10, "Summary98", "Book98" },
                    { 99, "Author99", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7972), "ISBN99", true, false, 10m, 10, "Summary99", "Book99" },
                    { 100, "Author100", "https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg", new DateTime(2023, 10, 12, 1, 13, 32, 663, DateTimeKind.Local).AddTicks(7974), "ISBN100", true, false, 10m, 10, "Summary100", "Book100" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "Category 1" },
                    { 2, true, false, "Category 2" },
                    { 3, true, false, "Category 3" },
                    { 4, true, false, "Category 4" },
                    { 5, true, false, "Category 5" },
                    { 6, true, false, "Category 6" },
                    { 7, true, false, "Category 7" },
                    { 8, true, false, "Category 8" },
                    { 9, true, false, "Category 9" },
                    { 10, true, false, "Category 10" }
                });

            migrationBuilder.InsertData(
                table: "BooksCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 6 },
                    { 4, 2 },
                    { 5, 10 },
                    { 6, 2 },
                    { 7, 10 },
                    { 8, 4 },
                    { 9, 3 },
                    { 10, 10 },
                    { 11, 5 },
                    { 12, 9 },
                    { 13, 5 },
                    { 14, 7 },
                    { 15, 6 },
                    { 16, 5 },
                    { 17, 5 },
                    { 18, 5 },
                    { 19, 10 },
                    { 20, 4 },
                    { 21, 5 },
                    { 22, 2 },
                    { 23, 7 },
                    { 24, 5 },
                    { 25, 1 },
                    { 26, 2 },
                    { 27, 4 },
                    { 28, 6 },
                    { 29, 2 },
                    { 30, 2 },
                    { 31, 5 },
                    { 32, 8 },
                    { 33, 10 },
                    { 34, 7 },
                    { 35, 9 },
                    { 36, 3 },
                    { 37, 1 },
                    { 38, 3 },
                    { 39, 9 },
                    { 40, 5 },
                    { 41, 4 },
                    { 42, 3 },
                    { 43, 7 },
                    { 44, 3 },
                    { 45, 9 },
                    { 46, 9 },
                    { 47, 5 },
                    { 48, 10 },
                    { 49, 7 },
                    { 50, 4 },
                    { 51, 7 },
                    { 52, 6 },
                    { 53, 1 },
                    { 54, 8 },
                    { 55, 3 },
                    { 56, 4 },
                    { 57, 10 },
                    { 58, 8 },
                    { 59, 10 },
                    { 60, 2 },
                    { 61, 4 },
                    { 62, 5 },
                    { 63, 4 },
                    { 64, 6 },
                    { 65, 7 },
                    { 66, 4 },
                    { 67, 8 },
                    { 68, 5 },
                    { 69, 8 },
                    { 70, 3 },
                    { 71, 4 },
                    { 72, 5 },
                    { 73, 10 },
                    { 74, 10 },
                    { 75, 2 },
                    { 76, 8 },
                    { 77, 6 },
                    { 78, 6 },
                    { 79, 2 },
                    { 80, 7 },
                    { 81, 4 },
                    { 82, 9 },
                    { 83, 2 },
                    { 84, 10 },
                    { 85, 7 },
                    { 86, 6 },
                    { 87, 10 },
                    { 88, 2 },
                    { 89, 2 },
                    { 90, 1 },
                    { 91, 8 },
                    { 92, 10 },
                    { 93, 1 },
                    { 94, 9 },
                    { 95, 9 },
                    { 96, 1 },
                    { 97, 10 },
                    { 98, 1 },
                    { 99, 7 },
                    { 100, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksCategories_CategoryId",
                table: "BooksCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
