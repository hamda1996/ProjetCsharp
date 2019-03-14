using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilRougeApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    PersonneID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.PersonneID);
                });

            migrationBuilder.CreateTable(
                name: "Formation",
                columns: table => new
                {
                    FormationID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonneID = table.Column<long>(nullable: false),
                    Titre = table.Column<string>(nullable: true),
                    Duree = table.Column<int>(nullable: false),
                    Date_Deb = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formation", x => x.FormationID);
                    table.ForeignKey(
                        name: "FK_Formation_Personne_PersonneID",
                        column: x => x.PersonneID,
                        principalTable: "Personne",
                        principalColumn: "PersonneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Formation_PersonneID",
                table: "Formation",
                column: "PersonneID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formation");

            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
