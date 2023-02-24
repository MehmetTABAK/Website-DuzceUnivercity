using Microsoft.EntityFrameworkCore.Migrations;

namespace DüzceÜniversitesi.Migrations
{
    public partial class duyuruIcerik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DuyuruIcerigi",
                table: "announcements",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DuyuruIcerigi",
                table: "announcements");
        }
    }
}
