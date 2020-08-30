using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetsLostAndFound.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Microchipped = table.Column<bool>(nullable: false),
                    Microchip = table.Column<string>(nullable: true),
                    RegisterId = table.Column<string>(nullable: true),
                    AdoptionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
