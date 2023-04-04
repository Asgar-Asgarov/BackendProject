using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    /// <inheritdoc />
    public partial class IconUrlandTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "duration",
                table: "events",
                newName: "startTime");

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "finishTime",
                table: "events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "events");

            migrationBuilder.DropColumn(
                name: "finishTime",
                table: "events");

            migrationBuilder.RenameColumn(
                name: "startTime",
                table: "events",
                newName: "duration");
        }
    }
}
