using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedUsersIDs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "Workouts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "Measurements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserID",
                table: "Workouts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_UserID",
                table: "Measurements",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Users_UserID",
                table: "Measurements",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Users_UserID",
                table: "Workouts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_Users_UserID",
                table: "Measurements");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Users_UserID",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_UserID",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_UserID",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Measurements");
        }
    }
}
