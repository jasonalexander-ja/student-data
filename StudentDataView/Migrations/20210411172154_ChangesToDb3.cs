using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDataView.Migrations
{
    public partial class ChangesToDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "StudentDataModel",
                newName: "StudentDataModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentDataModelID",
                table: "StudentDataModel",
                newName: "ID");
        }
    }
}
