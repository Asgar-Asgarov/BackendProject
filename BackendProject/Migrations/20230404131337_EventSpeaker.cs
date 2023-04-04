using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    /// <inheritdoc />
    public partial class EventSpeaker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Speaker_eventDetail_EventDetailId",
                table: "Speaker");

            migrationBuilder.DropIndex(
                name: "IX_Speaker_EventDetailId",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "EventDetailId",
                table: "Speaker");

            migrationBuilder.CreateTable(
                name: "EventSpeaker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakerId = table.Column<int>(type: "int", nullable: false),
                    EventDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSpeaker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventSpeaker_Speaker_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speaker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventSpeaker_eventDetail_EventDetailId",
                        column: x => x.EventDetailId,
                        principalTable: "eventDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeaker_EventDetailId",
                table: "EventSpeaker",
                column: "EventDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeaker_SpeakerId",
                table: "EventSpeaker",
                column: "SpeakerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventSpeaker");

            migrationBuilder.AddColumn<int>(
                name: "EventDetailId",
                table: "Speaker",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_EventDetailId",
                table: "Speaker",
                column: "EventDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Speaker_eventDetail_EventDetailId",
                table: "Speaker",
                column: "EventDetailId",
                principalTable: "eventDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
