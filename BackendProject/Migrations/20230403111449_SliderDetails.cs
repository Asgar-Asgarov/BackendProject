using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    /// <inheritdoc />
    public partial class SliderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SliderId",
                table: "SliderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SliderDetail_SliderId",
                table: "SliderDetail",
                column: "SliderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SliderDetail_Sliders_SliderId",
                table: "SliderDetail",
                column: "SliderId",
                principalTable: "Sliders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SliderDetail_Sliders_SliderId",
                table: "SliderDetail");

            migrationBuilder.DropIndex(
                name: "IX_SliderDetail_SliderId",
                table: "SliderDetail");

            migrationBuilder.DropColumn(
                name: "SliderId",
                table: "SliderDetail");
        }
    }
}
