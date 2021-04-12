using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDataView.Migrations
{
    public partial class CorrectedStudentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentDataModelID",
                table: "StudentDataModel",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "StudentDataModel",
                newName: "StudentDataModelID");
        }
    }
}
