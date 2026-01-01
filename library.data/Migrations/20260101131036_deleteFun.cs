using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    public partial class deleteFun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_loans_LoanId",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_LoanId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoanId",
                table: "books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_books_LoanId",
                table: "books",
                column: "LoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_loans_LoanId",
                table: "books",
                column: "LoanId",
                principalTable: "loans",
                principalColumn: "LoanId");
        }
    }
}
