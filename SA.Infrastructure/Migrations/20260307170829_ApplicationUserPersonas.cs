using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SA.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserPersonas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "AspNetUsers");
        }
    }
}
