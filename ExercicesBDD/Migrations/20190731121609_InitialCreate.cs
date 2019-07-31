using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExercicesBDD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Libelle = table.Column<string>(nullable: true),
                    PrixKM = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    Adresse = table.Column<string>(nullable: true),
                    CodePostal = table.Column<int>(nullable: false),
                    Ville = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicules",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Immatriculation = table.Column<string>(nullable: true),
                    Couleur = table.Column<string>(nullable: true),
                    DateMiseEnService = table.Column<DateTime>(nullable: false),
                    CategorieID = table.Column<int>(nullable: true),
                    MarqueID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehicules_Categories_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicules_Marques_MarqueID",
                        column: x => x.MarqueID,
                        principalTable: "Marques",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreKm = table.Column<int>(nullable: false),
                    DateDebut = table.Column<DateTime>(nullable: false),
                    DateFin = table.Column<DateTime>(nullable: false),
                    ClientID = table.Column<int>(nullable: true),
                    VehiculeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Loues_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loues_Vehicules_VehiculeID",
                        column: x => x.VehiculeID,
                        principalTable: "Vehicules",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loues_ClientID",
                table: "Loues",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Loues_VehiculeID",
                table: "Loues",
                column: "VehiculeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_CategorieID",
                table: "Vehicules",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_MarqueID",
                table: "Vehicules",
                column: "MarqueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loues");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Vehicules");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Marques");
        }
    }
}
