using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    /// <inheritdoc />
    public partial class ModifyIcon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icon_events_EventId",
                table: "Icon");

            migrationBuilder.DropIndex(
                name: "IX_Icon_EventId",
                table: "Icon");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Icon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Icon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Icon_EventId",
                table: "Icon",
                column: "EventId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Icon_events_EventId",
                table: "Icon",
                column: "EventId",
                principalTable: "events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
