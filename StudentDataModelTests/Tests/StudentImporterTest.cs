using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentDataModels.Models;
using StudentDataModels.Importers;

namespace StudentDataModelTests
{
    [TestClass]
    public class StudentImporterTest
    {
        public static string FullPathToProject = DataPath.GetPath();

        [TestMethod]
        public void TestImport()
        {
            string inputJson = File.ReadAllText($"{FullPathToProject}/TestData/inputTestModel.json");
            StudentModel imported = MainStudentImporter.Extract(inputJson);
            var correctModel = ExampleModelGenerator.StudentImportExample();
            CheckModels(imported, correctModel);
        }

        private static void CheckModels(StudentModel imported, StudentModel actual)
        {
            Assert.AreEqual(imported.SourceId, actual.SourceId);
            Assert.AreEqual(imported.OldSourceId, actual.OldSourceId);
            Assert.AreEqual(imported.PupilAdmissionNumber, actual.PupilAdmissionNumber);
            Assert.AreEqual(imported.FirstName, actual.FirstName);
            Assert.AreEqual(imported.LegalFirstName, actual.LegalFirstName);
            Assert.AreEqual(imported.MiddleName, actual.MiddleName);
            Assert.AreEqual(imported.LastName, actual.LastName);
            Assert.AreEqual(imported.LegalLastName, actual.LegalLastName);
            Assert.AreEqual(imported.FormerLastName, actual.FormerLastName);
            Assert.AreEqual(imported.Gender, actual.Gender);
            Assert.AreEqual(imported.YearCode, actual.YearCode);
            Assert.AreEqual(imported.YearGroupSourceId, actual.YearGroupSourceId);
            Assert.AreEqual(imported.Dob, actual.Dob);
            Assert.AreEqual(imported.Upn, actual.Upn);
            Assert.AreEqual(imported.FormerUpn, actual.FormerUpn);
            Assert.AreEqual(imported.Uln, actual.Uln);
            Assert.AreEqual(imported.IsEal, actual.IsEal);
            Assert.AreEqual(imported.FreeMeal, actual.FreeMeal);
            Assert.AreEqual(imported.FreeMeal6, actual.FreeMeal6);
            Assert.AreEqual(imported.FsmReviewDate, actual.FsmReviewDate);
            Assert.AreEqual(imported.EthnicityCode, actual.EthnicityCode);
            Assert.AreEqual(imported.IsPp, actual.IsPp);
            Assert.AreEqual(imported.ServiceChild, actual.ServiceChild);
            Assert.AreEqual(imported.LookedAfter, actual.LookedAfter);
            Assert.AreEqual(imported.EverInCare, actual.EverInCare);
            Assert.AreEqual(imported.SenCategory, actual.SenCategory);
            Assert.AreEqual(imported.EnrolmentStatus, actual.EnrolmentStatus);
            Assert.AreEqual(imported.AddressLine1, actual.AddressLine1);
            Assert.AreEqual(imported.AddressLine2, actual.AddressLine2);
            Assert.AreEqual(imported.TownCity, actual.TownCity);
            Assert.AreEqual(imported.County, actual.County);
            Assert.AreEqual(imported.Country, actual.Country);
            Assert.AreEqual(imported.Postcode, actual.Postcode);
            Assert.AreEqual(imported.StartDate, actual.StartDate);
            Assert.AreEqual(imported.EndDate, actual.EndDate);
            Assert.AreEqual(imported.HomeLanguageCode, actual.HomeLanguageCode);
            Assert.AreEqual(imported.HomeLanguageName, actual.HomeLanguageName);
            Assert.AreEqual(imported.FirstLanguageCode, actual.FirstLanguageCode);
            Assert.AreEqual(imported.FirstLanguageName, actual.FirstLanguageName);
            Assert.AreEqual(imported.ProficiencyInEnglishCode, actual.ProficiencyInEnglishCode);
            Assert.AreEqual(imported.ProficiencyInEnglishName, actual.ProficiencyInEnglishName);
            Assert.AreEqual(imported.Nationalities, actual.Nationalities);
            Assert.AreEqual(imported.CountryOfBirth, actual.CountryOfBirth);
            Assert.AreEqual(imported.PhotoHash, actual.PhotoHash);
            Assert.AreEqual(imported.NhsNumber, actual.NhsNumber);
            Assert.AreEqual(imported.IsPregnant, actual.IsPregnant);
            Assert.AreEqual(imported.HasEmergencyConsent, actual.HasEmergencyConsent);
        }

    }
}
