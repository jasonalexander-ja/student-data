using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDataView.Migrations
{
    public partial class ChangesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentID",
                table: "ContactDataModel");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "ContactDataModel",
                newName: "StudentDataModelID1");

            migrationBuilder.RenameIndex(
                name: "IX_ContactDataModel_StudentID",
                table: "ContactDataModel",
                newName: "IX_ContactDataModel_StudentDataModelID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentDataModelID1",
                table: "ContactDataModel",
                column: "StudentDataModelID1",
                principalTable: "StudentDataModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentDataModelID1",
                table: "ContactDataModel");

            migrationBuilder.RenameColumn(
                name: "StudentDataModelID1",
                table: "ContactDataModel",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_ContactDataModel_StudentDataModelID1",
                table: "ContactDataModel",
                newName: "IX_ContactDataModel_StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentID",
                table: "ContactDataModel",
                column: "StudentID",
                principalTable: "StudentDataModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
