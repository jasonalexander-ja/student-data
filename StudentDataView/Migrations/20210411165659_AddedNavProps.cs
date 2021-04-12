using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDataView.Migrations
{
    public partial class AddedNavProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentID",
                table: "ContactDataModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDataModel_StudentID",
                table: "ContactDataModel",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentID",
                table: "ContactDataModel",
                column: "StudentID",
                principalTable: "StudentDataModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentID",
                table: "ContactDataModel");

            migrationBuilder.DropIndex(
                name: "IX_ContactDataModel_StudentID",
                table: "ContactDataModel");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "ContactDataModel");
        }
    }
}
