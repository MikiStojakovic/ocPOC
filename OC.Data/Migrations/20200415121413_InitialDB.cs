using Microsoft.EntityFrameworkCore.Migrations;

namespace OC.Data.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Fourisseur VALUES (NewID(), 'Copartis')");

            migrationBuilder
                .Sql("INSERT INTO Fourisseur VALUES (NewID(), 'Natixis')");

            migrationBuilder
                .Sql("INSERT INTO Fourisseur VALUES (NewID(), 'PSA')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Fourisseur");
        }
    }
}
