using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppPeopleApi.Migrations
{
    public partial class added_title_to_person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "People");
        }
    }
}
