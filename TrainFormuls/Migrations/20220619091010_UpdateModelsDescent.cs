using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainFormuls.Migrations
{
    public partial class UpdateModelsDescent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Quantities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Formulas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Quantities");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Formulas");
        }
    }
}
