using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentDataModels.Models;

namespace StudentDataModelTests
{
    public class ExampleModelGenerator
    {
        public static StudentModel StudentModel()
        {
            return new StudentModel
            {
                SourceId = "test",
                OldSourceId = "test",
                PupilAdmissionNumber = "test",
                FirstName = "test",
                LegalFirstName = "test",
                MiddleName = "test",
                LastName = "test",
                LegalLastName = "test",
                FormerLastName = "test",
                Gender = "test",
                YearCode = "test",
                YearGroupSourceId = "test",
                Dob = new DateTime(2020, 01, 01),
                Upn = "test",
                FormerUpn = "test",
                Uln = "test",
                IsEal = true,
                FreeMeal = "test",
                FreeMeal6 = "test",
                FsmReviewDate = new DateTime(2020, 01, 01),
                EthnicityCode = "test",
                IsPp = true,
                ServiceChild = true,
                LookedAfter = true,
                EverInCare = "test",
                SenCategory = "test",
                EnrolmentStatus = "test",
                AddressLine1 = "test",
                AddressLine2 = "test",
                TownCity = "test",
                County = "test",
                Country = "test",
                Postcode = "test",
                StartDate = new DateTime(2020, 01, 01),
                EndDate = new DateTime(2020, 01, 01),
                HomeLanguageCode = "test",
                HomeLanguageName = "test",
                FirstLanguageCode = "test",
                FirstLanguageName = "test",
                ProficiencyInEnglishCode = "test",
                ProficiencyInEnglishName = "test",
                Nationalities = "test",
                CountryOfBirth = "test",
                PhotoHash = "test",
                NhsNumber = "test",
                IsPregnant = "test",
                HasEmergencyConsent = "test"
            };
        }
        public static StudentModel StudentImportExample()
        {
            return new StudentModel
            {
                SourceId = "1091",
                OldSourceId = null,
                PupilAdmissionNumber = "6177",
                FirstName = "Vicki",
                LegalFirstName = "Vicki",
                MiddleName = "",
                LastName = "Newhart",
                LegalLastName = "Newhart",
                FormerLastName = "",
                Gender = "F",
                YearCode = "7",
                YearGroupSourceId = null,
                Dob = new DateTime(1999, 06, 09),
                Upn = "U502400200093",
                FormerUpn = "",
                Uln = "7196241826",
                IsEal = false,
                FreeMeal = null,
                FreeMeal6 = null,
                FsmReviewDate = new DateTime(),
                EthnicityCode = "WBRI",
                IsPp = false,
                ServiceChild = false,
                LookedAfter = false,
                EverInCare = null,
                SenCategory = "E",
                EnrolmentStatus = "C",
                AddressLine1 = "268 Coronation Street",
                AddressLine2 = "",
                TownCity = "Derby",
                County = null,
                Country = "GBR",
                Postcode = "DE3 3FE",
                StartDate = new DateTime(2010, 09, 01),
                EndDate = new DateTime(),
                HomeLanguageCode = null,
                HomeLanguageName = null,
                FirstLanguageCode = "ENG",
                FirstLanguageName = null,
                ProficiencyInEnglishCode = null,
                ProficiencyInEnglishName = null,
                Nationalities = "GBR",
                CountryOfBirth = "GBR",
                PhotoHash = null,
                NhsNumber = null,
                IsPregnant = null,
                HasEmergencyConsent = null
            };
        }

        public static ContactModel ContactImportExample()
        {
            return new ContactModel()
            {
                AddressDisclosure = false,
                AddressTransferred = false,
                ContactId = 3469,
                ContactPrioritySource = "",
                Description = "Other Contact",
                EmergencyContactLevel = "Secondary",
                FeePayer = false,
                FirstName = "Bethany",
                Gender = "F",
                HomeAddressLink = false,
                LastName = "Sepulveda",
                NextOfKin = false,
                OtherHomeAddressLink = false,
                ParentalPortal = false,
                ParentalResponsibility = true,
                Priority = 4,
                Relationship = "OTH",
                SendSms = false,
                Title = "Mrs",
                WrittenCommunication = ""
            };
        }
    }
}
