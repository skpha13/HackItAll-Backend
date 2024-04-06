using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackItAllBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddedReservationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "reservationId",
                table: "Batteries",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    batteryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_reservationId",
                table: "Batteries",
                column: "reservationId",
                unique: true,
                filter: "[reservationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_Reservations_reservationId",
                table: "Batteries",
                column: "reservationId",
                principalTable: "Reservations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_Reservations_reservationId",
                table: "Batteries");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Batteries_reservationId",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "reservationId",
                table: "Batteries");
        }
    }
}
