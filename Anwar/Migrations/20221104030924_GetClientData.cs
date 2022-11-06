using Microsoft.EntityFrameworkCore.Migrations;

namespace Anwar.Migrations
{
    public partial class GetClientData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetClientsData",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    zipcode = table.Column<string>(nullable: true),
                    website = table.Column<string>(nullable: true),
                    ownership = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    created_by = table.Column<string>(nullable: true),
                    created_at = table.Column<string>(nullable: true),
                    updated_at = table.Column<string>(nullable: true),
                    industry_exp = table.Column<int>(nullable: false),
                    primary_business_unit = table.Column<int>(nullable: false),
                    accessible_business_units = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetClientsData", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetClientsData");
        }
    }
}
