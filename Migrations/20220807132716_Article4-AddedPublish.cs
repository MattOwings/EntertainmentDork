using Microsoft.EntityFrameworkCore.Migrations;

namespace EntertainmentDork.Migrations
{
    public partial class Article4AddedPublish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Article",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Published",
                table: "Article");
        }
    }
}
