using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentAppUserRelationMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUserID",
                table: "Comment",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_AppUserID",
                table: "Comment",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_AppUserID",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_AppUserID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Comment");
        }
    }
}
