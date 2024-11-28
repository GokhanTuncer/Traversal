using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class MigrationAddDestinationFKtoGuideChangeTypeStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Guide",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "GuideID",
                table: "Destination",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destination_GuideID",
                table: "Destination",
                column: "GuideID");

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Guide_GuideID",
                table: "Destination",
                column: "GuideID",
                principalTable: "Guide",
                principalColumn: "GuideID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Guide_GuideID",
                table: "Destination");

            migrationBuilder.DropIndex(
                name: "IX_Destination_GuideID",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "GuideID",
                table: "Destination");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Guide",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
