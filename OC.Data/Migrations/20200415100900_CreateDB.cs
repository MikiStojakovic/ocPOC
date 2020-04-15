using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OC.Data.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conseillers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conseillers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fourisseur",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fourisseur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OuvertureComptes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OcRef = table.Column<string>(nullable: false),
                    DocPath = table.Column<string>(nullable: false),
                    FourisseurId = table.Column<Guid>(nullable: false),
                    ConseillerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OuvertureComptes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OuvertureComptes_Conseillers_ConseillerId",
                        column: x => x.ConseillerId,
                        principalTable: "Conseillers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OuvertureComptes_Fourisseur_FourisseurId",
                        column: x => x.FourisseurId,
                        principalTable: "Fourisseur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OuvertureCompteDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TypeCompte = table.Column<string>(nullable: true),
                    NatureCompte = table.Column<string>(nullable: true),
                    TypeOuverture = table.Column<string>(nullable: false),
                    ModeSoumission = table.Column<string>(nullable: true),
                    OuvertureCompteId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OuvertureCompteDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OuvertureCompteDetails_OuvertureComptes_OuvertureCompteId",
                        column: x => x.OuvertureCompteId,
                        principalTable: "OuvertureComptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OuvertureCompteDetails_OuvertureCompteId",
                table: "OuvertureCompteDetails",
                column: "OuvertureCompteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OuvertureComptes_ConseillerId",
                table: "OuvertureComptes",
                column: "ConseillerId");

            migrationBuilder.CreateIndex(
                name: "IX_OuvertureComptes_FourisseurId",
                table: "OuvertureComptes",
                column: "FourisseurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OuvertureCompteDetails");

            migrationBuilder.DropTable(
                name: "OuvertureComptes");

            migrationBuilder.DropTable(
                name: "Conseillers");

            migrationBuilder.DropTable(
                name: "Fourisseur");
        }
    }
}
