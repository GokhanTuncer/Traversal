﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class MigrationAddRelationDestinationReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DestinationID",
                table: "Reservations",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destination_DestinationID",
                table: "Reservations",
                column: "DestinationID",
                principalTable: "Destination",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destination_DestinationID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DestinationID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Reservations");
        }
    }
}
