using Microsoft.EntityFrameworkCore.Migrations;

namespace OC.Data.Migrations
{
    public partial class PopulateDbWithOCInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql(@"INSERT INTO OuvertureComptes VALUES (NewID(), 'OC-R-01', 'C:\Document center\Projects\GitHub\web applications\OC\ocPOC', '27ACF50B-20EF-4B42-9C31-794FBBF9548F')");

            migrationBuilder
               .Sql(@"INSERT INTO OuvertureComptes VALUES (NewID(), 'OC-R-02', 'C:\Document center\Projects\GitHub\web applications\OC\ocPOC', '27ACF50B-20EF-4B42-9C31-794FBBF9548F')");

            migrationBuilder
               .Sql(@"INSERT INTO OuvertureComptes VALUES (NewID(), 'OC-R-03', 'C:\Document center\Projects\GitHub\web applications\OC\ocPOC', '37417C9E-C86B-48A3-8065-351CDFCED2FC')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
