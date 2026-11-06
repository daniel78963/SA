using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SA.APILibrary.Migrations
{
    /// <inheritdoc />
    public partial class UserAddDateBirth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateBirth",
                table: "AspNetUsers");
        }
    }
}
