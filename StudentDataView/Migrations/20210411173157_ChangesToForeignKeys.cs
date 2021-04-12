using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDataView.Migrations
{
    public partial class ChangesToForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentDataModelID1",
                table: "ContactDataModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactDataModel",
                table: "ContactDataModel");

            migrationBuilder.DropIndex(
                name: "IX_ContactDataModel_StudentDataModelID1",
                table: "ContactDataModel");

            migrationBuilder.DropColumn(
                name: "StudentDataModelID1",
                table: "ContactDataModel");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDataModelID",
                table: "ContactDataModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentDataModelID",
                table: "ContactDataModel",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactDataModel",
                table: "ContactDataModel",
                column: "ContactDataModelID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDataModel_StudentDataModelID",
                table: "ContactDataModel",
                column: "StudentDataModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentDataModelID",
                table: "ContactDataModel",
                column: "StudentDataModelID",
                principalTable: "StudentDataModel",
                principalColumn: "StudentDataModelID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentDataModelID",
                table: "ContactDataModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactDataModel",
                table: "ContactDataModel");

            migrationBuilder.DropIndex(
                name: "IX_ContactDataModel_StudentDataModelID",
                table: "ContactDataModel");

            migrationBuilder.AlterColumn<string>(
                name: "StudentDataModelID",
                table: "ContactDataModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactDataModelID",
                table: "ContactDataModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "StudentDataModelID1",
                table: "ContactDataModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactDataModel",
                table: "ContactDataModel",
                column: "StudentDataModelID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDataModel_StudentDataModelID1",
                table: "ContactDataModel",
                column: "StudentDataModelID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDataModel_StudentDataModel_StudentDataModelID1",
                table: "ContactDataModel",
                column: "StudentDataModelID1",
                principalTable: "StudentDataModel",
                principalColumn: "StudentDataModelID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
