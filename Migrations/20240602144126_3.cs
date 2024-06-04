using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CALLОМОЙСЬКИЙ.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Contacts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Calls",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UsersId",
                table: "Messages",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UsersId",
                table: "Contacts",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_UsersId",
                table: "Calls",
                column: "UsersId");

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

            migrationBuilder.DropIndex(
                name: "IX_Messages_UsersId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UsersId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Calls_UsersId",
                table: "Calls");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Calls");
        }
    }
}
