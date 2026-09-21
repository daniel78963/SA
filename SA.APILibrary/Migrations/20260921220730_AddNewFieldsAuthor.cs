using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SA.APILibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldsAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Authors",
                newName: "Surnames");

            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Authors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Names",
                table: "Authors",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Names",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "Surnames",
                table: "Authors",
                newName: "Name");
        }
    }
}
