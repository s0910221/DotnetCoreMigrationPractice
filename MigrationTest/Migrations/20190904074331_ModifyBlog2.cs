using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationTest.Migrations
{
    public partial class ModifyBlog2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lru",
                table: "Blogs",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Blogs",
                newName: "Lru");
        }
    }
}
