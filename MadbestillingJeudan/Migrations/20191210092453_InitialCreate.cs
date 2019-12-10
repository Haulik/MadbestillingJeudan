using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MadbestillingJeudan.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Madmenu",
                columns: table => new
                {
                    Menuid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Menu = table.Column<string>(nullable: true),
                    Med_Hjem_Køkken = table.Column<string>(nullable: true),
                    Dato = table.Column<DateTime>(nullable: false),
                    Uge = table.Column<int>(nullable: false),
                    UgeNavn = table.Column<string>(nullable: true),
                    MenuStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Madmenu", x => x.Menuid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Madmenu");
        }
    }
}
