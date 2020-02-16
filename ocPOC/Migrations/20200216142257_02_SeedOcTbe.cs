using Microsoft.EntityFrameworkCore.Migrations;

namespace ocPOC.Migrations
{
    public partial class _02_SeedOcTbe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OuvertureComptes",
                columns: new[] { "Id", "OcRef", "PropertyOne" },
                values: new object[] { 1, "Ref1", "prop1" });

            migrationBuilder.InsertData(
                table: "OuvertureComptes",
                columns: new[] { "Id", "OcRef", "PropertyOne" },
                values: new object[] { 2, "Ref2", "prop2" });

            migrationBuilder.InsertData(
                table: "OuvertureComptes",
                columns: new[] { "Id", "OcRef", "PropertyOne" },
                values: new object[] { 3, "Ref3", "prop3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OuvertureComptes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OuvertureComptes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OuvertureComptes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
