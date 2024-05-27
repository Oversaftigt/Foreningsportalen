using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForeningsPortalen.DatabaseMigration.Migrations
{
    /// <inheritdoc />
    public partial class DocumentUserNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Users_CreatorUserId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "CreatorUserId",
                table: "Documents",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_CreatorUserId",
                table: "Documents",
                newName: "IX_Documents_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users_UserId",
                table: "Documents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Users_MemberUserId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "MemberUserId",
                table: "Documents",
                newName: "CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_MemberUserId",
                table: "Documents",
                newName: "IX_Documents_CreatorUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users_CreatorUserId",
                table: "Documents",
                column: "CreatorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
