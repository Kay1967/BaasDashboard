using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaasDashboard.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Sleep",
                table: "Users",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Stress",
                table: "Users",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sleep",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Stress",
                table: "Users");
        }
    }
}
