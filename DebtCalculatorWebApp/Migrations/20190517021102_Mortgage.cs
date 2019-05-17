using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtCalculatorWebApp.Migrations
{
    public partial class Mortgage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mortgage",
                columns: table => new
                {
                    MortgageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MortgageAmount = table.Column<double>(nullable: false),
                    MortgageTime = table.Column<int>(nullable: false),
                    MortgageApr = table.Column<double>(nullable: false),
                    RecordDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mortgage", x => x.MortgageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mortgage");
        }
    }
}
