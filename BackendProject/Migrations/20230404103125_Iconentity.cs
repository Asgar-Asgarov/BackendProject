using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    /// <inheritdoc />
    public partial class Iconentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDetail_events_EventId",
                table: "EventDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventDetail",
                table: "EventDetail");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "events");

            migrationBuilder.RenameTable(
                name: "EventDetail",
                newName: "eventDetail");

            migrationBuilder.RenameIndex(
                name: "IX_EventDetail_EventId",
                table: "eventDetail",
                newName: "IX_eventDetail_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_eventDetail",
                table: "eventDetail",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Icon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Icon_events_EventId",
                        column: x => x.EventId,
                        principalTable: "events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Icon_EventId",
                table: "Icon",
                column: "EventId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_eventDetail_events_EventId",
                table: "eventDetail",
                column: "EventId",
                principalTable: "events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eventDetail_events_EventId",
                table: "eventDetail");

            migrationBuilder.DropTable(
                name: "Icon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_eventDetail",
                table: "eventDetail");

            migrationBuilder.RenameTable(
                name: "eventDetail",
                newName: "EventDetail");

            migrationBuilder.RenameIndex(
                name: "IX_eventDetail_EventId",
                table: "EventDetail",
                newName: "IX_EventDetail_EventId");

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventDetail",
                table: "EventDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventDetail_events_EventId",
                table: "EventDetail",
                column: "EventId",
                principalTable: "events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
