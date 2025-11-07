using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryDatabaseCore.Migrations
{
    /// <inheritdoc />
    public partial class CreateUniqueNonClusteredIndexForItemGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemGenre_ItemId",
                table: "ItemGenre");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGenre_ItemId_GenreId",
                table: "ItemGenre",
                columns: new[] { "ItemId", "GenreId" },
                unique: true)
                .Annotation("SqlServer:Clustered", false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemGenre_ItemId_GenreId",
                table: "ItemGenre");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGenre_ItemId",
                table: "ItemGenre",
                column: "ItemId");
        }
    }
}
