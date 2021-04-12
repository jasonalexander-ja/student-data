using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using StudentDataModels.Models;

namespace StudentDataModels.Importers
{
    public class MainStudentImporter : IImporter<StudentModel>
    {
        public static StudentModel Extract(string inputData)
        { 
            var transitionModel = JsonSerializer.Deserialize<JsonTransitionModel>(inputData);
            var jsonData = transitionModel.JsonExtensionData;
            StudentModel finalModel = new StudentModel();
            ExtractSenData(jsonData, finalModel);
            ExtractAddressData(jsonData, finalModel);
            ExtractLanguageData(jsonData, finalModel);
            ExtractNationalityData(jsonData, finalModel);
            ExtractGeneralStudentData(jsonData, finalModel);
            ExtractStudentNameData(jsonData, finalModel);
            return finalModel;
        }

        private static void ExtractSenData(
            Dictionary<string, JsonElement> jsonData,
            StudentModel student)
        {
            var senProvisionDetail = jsonData["SENProvisionDetails"][0];
            student.SenCategory = JsonTransitionModel.StringFromElem(senProvisionDetail, "ProvisionTypeCode");
        }

        private static void ExtractAddressData(
            Dictionary<string, JsonElement> jsonData,
            StudentModel student)
        {
            var addressDetails = jsonData["AddressDetails"][0];

            student.AddressLine1 = JsonTransitionModel.StringFromElem(addressDetails, "Number") +
                " " + JsonTransitionModel.StringFromElem(addressDetails, "Street");
            student.AddressLine2 = JsonTransitionModel.StringFromElem(addressDetails, "Locality");
            student.TownCity = JsonTransitionModel.StringFromElem(addressDetails, "Town");
            student.Country = JsonTransitionModel.StringFromElem(addressDetails, "Country");
            student.Postcode = JsonTransitionModel.StringFromElem(addressDetails, "PostCode");
        }

        private static void ExtractLanguageData(
            Dictionary<string, JsonElement> jsonData,
            StudentModel student)
        {
            var languageDetail = jsonData["LanguageDetails"][0];
            student.FirstLanguageCode = JsonTransitionModel.StringFromElem(languageDetail, "LanguageCode");

            student.IsEal = jsonData["EAL"].GetBoolean();
        }

        private static void ExtractNationalityData(
            Dictionary<string, JsonElement> jsonData,
            StudentModel student)
        {
            var addressDetails = jsonData["AddressDetails"][0];
            string country = JsonTransitionModel.StringFromElem(addressDetails, "Country");
            student.Nationalities = country;
            student.CountryOfBirth = country;
        }

        private static void ExtractGeneralStudentData(
            Dictionary<string, JsonElement> jsonData,
            StudentModel student)
        {
            student.Dob = JsonTransitionModel.DateFromDict(jsonData, "DateOfBirth");
            student.StartDate = JsonTransitionModel.DateFromDict(jsonData, "DateOfEntry");

            student.SourceId = JsonTransitionModel.StringFromDict(jsonData, "LearnerId");
            student.PupilAdmissionNumber = JsonTransitionModel.StringFromDict(jsonData, "LearnerCode");
            student.Uln = JsonTransitionModel.StringFromDict(jsonData, "ULN");
            student.Upn = JsonTransitionModel.StringFromDict(jsonData, "UPN");
            student.FormerUpn = JsonTransitionModel.StringFromDict(jsonData, "FormerUPN");
            student.EnrolmentStatus = JsonTransitionModel.StringFromDict(jsonData, "EnrolementStatus");

            student.Gender = JsonTransitionModel.StringFromDict(jsonData, "Gender");
            student.YearCode = JsonTransitionModel.StringFromDict(jsonData, "Year");
            student.EthnicityCode = JsonTransitionModel.StringFromDict(jsonData, "Ethnicity");
        }

        private static void ExtractStudentNameData(
            Dictionary<string, JsonElement> jsonData,
            StudentModel student)
        {
            student.FirstName = JsonTransitionModel.StringFromDict(jsonData, "Forename");
            student.LegalFirstName = JsonTransitionModel.StringFromDict(jsonData, "LegalForename");
            student.MiddleName = JsonTransitionModel.StringFromDict(jsonData, "MiddleName");
            student.LastName = JsonTransitionModel.StringFromDict(jsonData, "Surname");
            student.LegalLastName = JsonTransitionModel.StringFromDict(jsonData, "LegalSurname");
            student.FormerLastName = JsonTransitionModel.StringFromDict(jsonData, "FormerSurname");
        }
    }
}
