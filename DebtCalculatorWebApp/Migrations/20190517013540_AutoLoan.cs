using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtCalculatorWebApp.Migrations
{
    public partial class AutoLoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoLoan",
                columns: table => new
                {
                    AutoLoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutoLoanAmount = table.Column<double>(nullable: false),
                    AutoLoanTime = table.Column<int>(nullable: false),
                    AutoLoanApr = table.Column<double>(nullable: false),
                    RecordDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoLoan", x => x.AutoLoanId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoLoan");
        }
    }
}
