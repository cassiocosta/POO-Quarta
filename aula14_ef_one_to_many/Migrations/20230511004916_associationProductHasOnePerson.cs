using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula12_ef_test.Migrations
{
    /// <inheritdoc />
    public partial class associationProductHasOnePerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PersonId",
                table: "Products",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_People_PersonId",
                table: "Products",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_People_PersonId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PersonId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Products");
        }
    }
}
