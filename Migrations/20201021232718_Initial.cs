using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthEquity.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, "GeorgeC@Yahoo.com", "George", "Clooney", "801-444-5555" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2, "RobertR@Yahoo.com", "Robert", "Redford", "801-333-5655" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 3, "AlbertE@Yahoo.com", "Albert", "Einstein", "801-663-5655" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
