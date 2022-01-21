using Microsoft.EntityFrameworkCore.Migrations;

namespace homeworkASP.Migrations
{
    public partial class ammmma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioCategories_Portfolios_PortfolioId",
                table: "PortfolioCategories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "PortfolioCategories");

            migrationBuilder.AlterColumn<int>(
                name: "PortfolioId",
                table: "PortfolioCategories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioCategories_Portfolios_PortfolioId",
                table: "PortfolioCategories",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioCategories_Portfolios_PortfolioId",
                table: "PortfolioCategories");

            migrationBuilder.AlterColumn<int>(
                name: "PortfolioId",
                table: "PortfolioCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "PortfolioCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioCategories_Portfolios_PortfolioId",
                table: "PortfolioCategories",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
