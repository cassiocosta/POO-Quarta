using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula12_ef_test.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceAndPhoneNumberOnProductAndPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "People",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "People");
        }
    }
}
