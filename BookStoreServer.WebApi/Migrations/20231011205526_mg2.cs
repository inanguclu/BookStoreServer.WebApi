using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksCategories",
                table: "BooksCategories");

            migrationBuilder.DropIndex(
                name: "IX_BooksCategories_BookId",
                table: "BooksCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BooksCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksCategories",
                table: "BooksCategories",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_BooksCategories_CategoryId",
                table: "BooksCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksCategories_Categories_CategoryId",
                table: "BooksCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksCategories_Categories_CategoryId",
                table: "BooksCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksCategories",
                table: "BooksCategories");

            migrationBuilder.DropIndex(
                name: "IX_BooksCategories_CategoryId",
                table: "BooksCategories");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BooksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksCategories",
                table: "BooksCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BooksCategories_BookId",
                table: "BooksCategories",
                column: "BookId");
        }
    }
}
