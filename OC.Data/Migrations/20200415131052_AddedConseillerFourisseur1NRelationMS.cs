using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OC.Data.Migrations
{
    public partial class AddedConseillerFourisseur1NRelationMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OuvertureComptes_Fourisseur_FourisseurId",
                table: "OuvertureComptes");

            migrationBuilder.DropIndex(
                name: "IX_OuvertureComptes_FourisseurId",
                table: "OuvertureComptes");

            migrationBuilder.DropColumn(
                name: "FourisseurId",
                table: "OuvertureComptes");

            migrationBuilder.AddColumn<Guid>(
                name: "FourisseurId",
                table: "Conseillers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Conseillers_FourisseurId",
                table: "Conseillers",
                column: "FourisseurId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conseillers_Fourisseur_FourisseurId",
                table: "Conseillers",
                column: "FourisseurId",
                principalTable: "Fourisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conseillers_Fourisseur_FourisseurId",
                table: "Conseillers");

            migrationBuilder.DropIndex(
                name: "IX_Conseillers_FourisseurId",
                table: "Conseillers");

            migrationBuilder.DropColumn(
                name: "FourisseurId",
                table: "Conseillers");

            migrationBuilder.AddColumn<Guid>(
                name: "FourisseurId",
                table: "OuvertureComptes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_OuvertureComptes_FourisseurId",
                table: "OuvertureComptes",
                column: "FourisseurId");

            migrationBuilder.AddForeignKey(
                name: "FK_OuvertureComptes_Fourisseur_FourisseurId",
                table: "OuvertureComptes",
                column: "FourisseurId",
                principalTable: "Fourisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
