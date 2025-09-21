using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameContactNotesToCustomerNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactNotes_People_CustomerId",
                table: "ContactNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactNotes",
                table: "ContactNotes");

            migrationBuilder.RenameTable(
                name: "ContactNotes",
                newName: "CustomerNotes");

            migrationBuilder.RenameIndex(
                name: "IX_ContactNotes_CustomerId_CreatedAt",
                table: "CustomerNotes",
                newName: "IX_CustomerNotes_CustomerId_CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_ContactNotes_CustomerId",
                table: "CustomerNotes",
                newName: "IX_CustomerNotes_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerNotes",
                table: "CustomerNotes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerNotes_People_CustomerId",
                table: "CustomerNotes",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerNotes_People_CustomerId",
                table: "CustomerNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerNotes",
                table: "CustomerNotes");

            migrationBuilder.RenameTable(
                name: "CustomerNotes",
                newName: "ContactNotes");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerNotes_CustomerId_CreatedAt",
                table: "ContactNotes",
                newName: "IX_ContactNotes_CustomerId_CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerNotes_CustomerId",
                table: "ContactNotes",
                newName: "IX_ContactNotes_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactNotes",
                table: "ContactNotes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactNotes_People_CustomerId",
                table: "ContactNotes",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
