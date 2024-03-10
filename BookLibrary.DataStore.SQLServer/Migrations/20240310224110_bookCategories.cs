using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.DataStore.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class bookCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBookCategory_BookCategory_CategoriesCategoryId",
                table: "BookBookCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategory",
                table: "BookCategory");

            migrationBuilder.RenameTable(
                name: "BookCategory",
                newName: "BookCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookBookCategory_BookCategories_CategoriesCategoryId",
                table: "BookBookCategory",
                column: "CategoriesCategoryId",
                principalTable: "BookCategories",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBookCategory_BookCategories_CategoriesCategoryId",
                table: "BookBookCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories");

            migrationBuilder.RenameTable(
                name: "BookCategories",
                newName: "BookCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategory",
                table: "BookCategory",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookBookCategory_BookCategory_CategoriesCategoryId",
                table: "BookBookCategory",
                column: "CategoriesCategoryId",
                principalTable: "BookCategory",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
