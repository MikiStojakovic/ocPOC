using Microsoft.EntityFrameworkCore.Migrations;

namespace OC.Data.Migrations
{
    public partial class PopulateDbWithRestOfTheInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Conseillers VALUES (NewID(), 'CGP-01', 'Konjo', 'Polumenta', '338BB73B-A388-4882-AD84-8EE15B3D2712')");

            migrationBuilder
                .Sql("INSERT INTO Conseillers VALUES (NewID(), 'CGP-02', 'Prvo', 'Polumenta', '338BB73B-A388-4882-AD84-8EE15B3D2712')");           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
