using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForeningsPortalen.DatabaseMigration.Migrations
{
    /// <inheritdoc />
    public partial class DocumentToUnionRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UnionId",
                table: "Documents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UnionId",
                table: "Documents",
                column: "UnionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Unions_UnionId",
                table: "Documents",
                column: "UnionId",
                principalTable: "Unions",
                principalColumn: "UnionId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Unions_UnionId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_UnionId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "UnionId",
                table: "Documents");
        }
    }
}
