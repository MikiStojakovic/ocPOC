using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CopartisOC.Infrastructure.Migrations
{
    public partial class CreateSeparateTableForOuvertureCompteDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OcDetails_NatureCompte",
                table: "OuvertureComptes");

            migrationBuilder.DropColumn(
                name: "TypeCompte",
                table: "OuvertureComptes");

            migrationBuilder.DropColumn(
                name: "OcDetails_TypeOuverture",
                table: "OuvertureComptes");

            migrationBuilder.CreateTable(
                name: "OuvertureCompteDetails",
                columns: table => new
                {
                    OuvertureCompteId = table.Column<Guid>(nullable: false),
                    TypeCompte = table.Column<string>(nullable: true),
                    NatureCompte = table.Column<string>(nullable: true),
                    TypeOuverture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OuvertureCompteDetails", x => x.OuvertureCompteId);
                    table.ForeignKey(
                        name: "FK_OuvertureCompteDetails_OuvertureComptes_OuvertureCompteId",
                        column: x => x.OuvertureCompteId,
                        principalTable: "OuvertureComptes",
                        principalColumn: "OuvertureCompteId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OuvertureCompteDetails");

            migrationBuilder.AddColumn<string>(
                name: "OcDetails_NatureCompte",
                table: "OuvertureComptes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeCompte",
                table: "OuvertureComptes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OcDetails_TypeOuverture",
                table: "OuvertureComptes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
