using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetsLostAndFound.Migrations
{
    public partial class LastSeen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastSeen",
                table: "Pet",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastSeen",
                table: "Pet");
        }
    }
}
