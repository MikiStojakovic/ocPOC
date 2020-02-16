using Microsoft.EntityFrameworkCore.Migrations;

namespace ocPOC.Migrations
{
    public partial class _01_InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OuvertureComptes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OcRef = table.Column<string>(nullable: true),
                    PropertyOne = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OuvertureComptes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OuvertureComptes");
        }
    }
}
