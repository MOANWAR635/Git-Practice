using Microsoft.EntityFrameworkCore.Migrations;

namespace Anwar.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "liveDatas",
                columns: table => new
                {
                    AutoIncrementID = table.Column<string>(nullable: false),
                    userId = table.Column<int>(nullable: false),
                    id = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liveDatas", x => x.AutoIncrementID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FName = table.Column<string>(nullable: false),
                    LName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Passwords = table.Column<string>(nullable: false),
                    FatherName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Pincode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "liveDatas");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
