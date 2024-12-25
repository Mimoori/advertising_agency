using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agency.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "service_name",
                table: "orders",
                newName: "name_service");

            migrationBuilder.AlterColumn<string>(
                name: "period_of_execution",
                table: "service",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name_service",
                table: "orders",
                newName: "service_name");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "period_of_execution",
                table: "service",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
