using Microsoft.EntityFrameworkCore.Migrations;

namespace Anwar.Migrations
{
    public partial class NewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pagenumber",
                table: "liveDatas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "results",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    applicant_id = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    middlename = table.Column<string>(nullable: true),
                    consultant_name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    email_address_1 = table.Column<string>(nullable: true),
                    other_phone = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    mobile_number = table.Column<string>(nullable: true),
                    created_at = table.Column<string>(nullable: true),
                    created_by = table.Column<string>(nullable: true),
                    applicant_status = table.Column<string>(nullable: true),
                    skills = table.Column<string>(nullable: true),
                    source = table.Column<string>(nullable: true),
                    resume_path = table.Column<string>(nullable: true),
                    home_phone_number = table.Column<string>(nullable: true),
                    work_phone_number = table.Column<string>(nullable: true),
                    job_title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_results", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "results");

            migrationBuilder.DropColumn(
                name: "Pagenumber",
                table: "liveDatas");
        }
    }
}
