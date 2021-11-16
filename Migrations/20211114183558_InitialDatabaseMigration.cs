using Microsoft.EntityFrameworkCore.Migrations;

namespace hotelRes_V_03.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "c",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guest_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guest_contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guest_email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest_Profiles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guest_Profiles");
        }
    }
}
