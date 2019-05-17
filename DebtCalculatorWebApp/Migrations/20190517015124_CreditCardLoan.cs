using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtCalculatorWebApp.Migrations
{
    public partial class CreditCardLoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCardLoan",
                columns: table => new
                {
                    CreditCardLoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreditCardLoanAmount = table.Column<double>(nullable: false),
                    CreditCardLoanTime = table.Column<int>(nullable: false),
                    CreditcardLoanApr = table.Column<double>(nullable: false),
                    RecordDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardLoan", x => x.CreditCardLoanId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCardLoan");
        }
    }
}
