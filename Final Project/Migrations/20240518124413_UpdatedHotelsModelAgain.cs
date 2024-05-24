using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedHotelsModelAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelsId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_HotelsId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "HotelsId",
                table: "Rooms");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "HotelsId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelsId",
                table: "Rooms",
                column: "HotelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelsId",
                table: "Rooms",
                column: "HotelsId",
                principalTable: "Hotels",
                principalColumn: "Id");
        }
    }
}
