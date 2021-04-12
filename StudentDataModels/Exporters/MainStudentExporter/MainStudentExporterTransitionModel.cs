using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json.Serialization;
using StudentDataModels.Models;

namespace StudentDataModels.Exporters
{
    class MainStudentExporterTransitionModel : StudentModel
    {
        public MainStudentExporterTransitionModel(StudentModel studentModel)
        {
            SourceId = studentModel.SourceId;
            OldSourceId = studentModel.OldSourceId;
            PupilAdmissionNumber = studentModel.PupilAdmissionNumber;
            FirstName = studentModel.FirstName;
            LegalFirstName = studentModel.LegalFirstName;
            MiddleName = studentModel.MiddleName;
            LastName = studentModel.LastName;
            LegalLastName = studentModel.LegalLastName;
            FormerLastName = studentModel.FormerLastName;
            Gender = studentModel.Gender;
            YearCode = studentModel.YearCode;
            YearGroupSourceId = studentModel.YearGroupSourceId;
            Upn = studentModel.Upn;
            FormerUpn = studentModel.FormerUpn;
            Uln = studentModel.Uln;
            IsEal = studentModel.IsEal;
            FreeMeal = studentModel.FreeMeal;
            FreeMeal6 = studentModel.FreeMeal6;
            EthnicityCode = studentModel.EthnicityCode;
            IsPp = studentModel.IsPp;
            ServiceChild = studentModel.ServiceChild;
            LookedAfter = studentModel.LookedAfter;
            EverInCare = studentModel.EverInCare;
            SenCategory = studentModel.SenCategory;
            EnrolmentStatus = studentModel.EnrolmentStatus;
            AddressLine1 = studentModel.AddressLine1;
            AddressLine2 = studentModel.AddressLine2;
            TownCity = studentModel.TownCity;
            County = studentModel.County;
            Country = studentModel.Country;
            Postcode = studentModel.Postcode;
            HomeLanguageCode = studentModel.HomeLanguageCode;
            HomeLanguageName = studentModel.HomeLanguageName;
            FirstLanguageCode = studentModel.FirstLanguageCode;
            FirstLanguageName = studentModel.FirstLanguageName;
            ProficiencyInEnglishCode = studentModel.ProficiencyInEnglishCode;
            ProficiencyInEnglishName = studentModel.ProficiencyInEnglishName;
            Nationalities = studentModel.Nationalities;
            CountryOfBirth = studentModel.CountryOfBirth;
            PhotoHash = studentModel.PhotoHash;
            NhsNumber = studentModel.NhsNumber;
            IsPregnant = studentModel.IsPregnant;
            HasEmergencyConsent = studentModel.HasEmergencyConsent;

            Dob = ParseDate(studentModel.Dob);
            FsmReviewDate = ParseDate(studentModel.FsmReviewDate);
            StartDate = ParseDate(studentModel.StartDate);
            EndDate = ParseDate(studentModel.EndDate);
        }
        private static string ParseDate(DateTime date)
        {
            DateTime blankDate = new DateTime();
            string output = blankDate != date ?
                date.ToString() : null;
            return output;
        }
        public new string Dob { get; set; }
        public new string FsmReviewDate { get; set; }
        public new string StartDate { get; set; }
        public new string EndDate { get; set; }
    }
}
