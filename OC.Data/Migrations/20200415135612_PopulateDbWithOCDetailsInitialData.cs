using Microsoft.EntityFrameworkCore.Migrations;

namespace OC.Data.Migrations
{
    public partial class PopulateDbWithOCDetailsInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql(@"INSERT INTO OuvertureCompteDetails VALUES (NewID(), 'Type-Compte-1', 'Nature-1', 'Type-O-1', 'InternetInternet', '4032901C-FA95-4B1A-B466-18AEA4009DBA')");

            migrationBuilder
               .Sql(@"INSERT INTO OuvertureCompteDetails VALUES (NewID(), 'Type-Compte-2', 'Nature-2', 'Type-O-2', 'InternetPapier', '932D2512-6CB0-4231-B4E5-2EBC097157F3')");

            migrationBuilder
               .Sql(@"INSERT INTO OuvertureCompteDetails VALUES (NewID(), 'Type-Compte-3', 'Nature-1', 'Type-O-3', 'PapierPapier', '9ACAEB3C-2D33-4BC2-B014-918D340AA4A3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
