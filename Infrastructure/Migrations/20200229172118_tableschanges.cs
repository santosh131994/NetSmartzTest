using Microsoft.EntityFrameworkCore.Migrations;

namespace NetSmartz.Infrastructure.Migrations
{
    public partial class tableschanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Isdeleted",
                table: "Products",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Isdeleted",
                table: "Categories",
                newName: "IsDeleted");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceRange",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisplayOrder",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Products",
                newName: "Isdeleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Categories",
                newName: "Isdeleted");

            migrationBuilder.AlterColumn<string>(
                name: "PriceRange",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "DisplayOrder",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
