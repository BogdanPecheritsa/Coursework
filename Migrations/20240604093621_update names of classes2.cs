using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CALLОМОЙСЬКИЙ.Migrations
{
    /// <inheritdoc />
    public partial class updatenamesofclasses2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calls_Users_UserId",
                table: "Calls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_UserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Messages",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                newName: "IX_Messages_UsersId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Contacts",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts",
                newName: "IX_Contacts_UsersId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Calls",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Calls_UserId",
                table: "Calls",
                newName: "IX_Calls_UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calls_Users_UsersId",
                table: "Calls",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_UsersId",
                table: "Contacts",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UsersId",
                table: "Messages",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calls_Users_UsersId",
                table: "Calls");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_UsersId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UsersId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Messages",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_UsersId",
                table: "Messages",
                newName: "IX_Messages_UserId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Contacts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_UsersId",
                table: "Contacts",
                newName: "IX_Contacts_UserId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Calls",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Calls_UsersId",
                table: "Calls",
                newName: "IX_Calls_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calls_Users_UserId",
                table: "Calls",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_UserId",
                table: "Contacts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
