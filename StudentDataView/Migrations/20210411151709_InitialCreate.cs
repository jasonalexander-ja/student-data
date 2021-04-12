using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentDataView.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactDataModel",
                columns: table => new
                {
                    StudentDataModelID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContactDataModelID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WrittenCommunication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    ContactPrioritySource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKin = table.Column<bool>(type: "bit", nullable: false),
                    AddressDisclosure = table.Column<bool>(type: "bit", nullable: false),
                    AddressTransferred = table.Column<bool>(type: "bit", nullable: false),
                    ParentalResponsibility = table.Column<bool>(type: "bit", nullable: false),
                    FeePayer = table.Column<bool>(type: "bit", nullable: false),
                    ParentalPortal = table.Column<bool>(type: "bit", nullable: false),
                    HomeAddressLink = table.Column<bool>(type: "bit", nullable: false),
                    OtherHomeAddressLink = table.Column<bool>(type: "bit", nullable: false),
                    SendSms = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDataModel", x => x.StudentDataModelID);
                });

            migrationBuilder.CreateTable(
                name: "StudentDataModel",
                columns: table => new
                {
                    StudentDataModelID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    SourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PupilAdmissionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearGroupSourceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Upn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormerUpn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uln = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEal = table.Column<bool>(type: "bit", nullable: false),
                    FreeMeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeMeal6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FsmReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EthnicityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPp = table.Column<bool>(type: "bit", nullable: false),
                    ServiceChild = table.Column<bool>(type: "bit", nullable: false),
                    LookedAfter = table.Column<bool>(type: "bit", nullable: false),
                    EverInCare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrolmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TownCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeLanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstLanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstLanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProficiencyInEnglishCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProficiencyInEnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationalities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhsNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPregnant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasEmergencyConsent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDataModel", x => x.StudentDataModelID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactDataModel");

            migrationBuilder.DropTable(
                name: "StudentDataModel");
        }
    }
}
