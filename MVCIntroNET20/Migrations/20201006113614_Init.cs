using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCIntroNET20.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Age", "Department", "Name", "Salary" },
                values: new object[] { 1, 20, "IT", "Kalle", 20000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
