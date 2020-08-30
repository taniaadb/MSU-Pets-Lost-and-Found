using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetsLostAndFound.Migrations
{
    public partial class Lost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Lost",
                table: "Pet",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LostDate",
                table: "Pet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lost",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "LostDate",
                table: "Pet");
        }
    }
}
