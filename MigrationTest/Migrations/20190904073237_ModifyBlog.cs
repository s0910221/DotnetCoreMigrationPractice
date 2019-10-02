using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTest.Migrations
{
    public partial class ModifyBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Blogs",
                newName: "Lru");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lru",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Blogs",
                nullable: false,
                defaultValue: "");
        }
    }
}
