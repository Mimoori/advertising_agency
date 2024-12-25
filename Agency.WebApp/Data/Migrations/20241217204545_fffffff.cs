using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agency.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class fffffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name_service",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "service",
                table: "orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "service",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "status",
                table: "orders");

            migrationBuilder.AddColumn<string>(
                name: "name_service",
                table: "orders",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
