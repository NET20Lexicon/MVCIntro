using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCIntroNET20.Migrations
{
    public partial class RemoveAddTestProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
