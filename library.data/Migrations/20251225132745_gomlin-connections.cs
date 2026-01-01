using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    public partial class gomlinconnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanId",
                table: "books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_loans_CustomerId",
                table: "loans",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_books_CustomerId",
                table: "books",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_books_LoanId",
                table: "books",
                column: "LoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_customers_CustomerId",
                table: "books",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_loans_LoanId",
                table: "books",
                column: "LoanId",
                principalTable: "loans",
                principalColumn: "LoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_loans_customers_CustomerId",
                table: "loans",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_customers_CustomerId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_loans_LoanId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_loans_customers_CustomerId",
                table: "loans");

            migrationBuilder.DropIndex(
                name: "IX_loans_CustomerId",
                table: "loans");

            migrationBuilder.DropIndex(
                name: "IX_books_CustomerId",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_LoanId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "books");
        }
    }
}
