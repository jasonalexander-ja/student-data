using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StudentDataView.Models;

namespace StudentDataView.Models
{
    public class StudentView
    {
        public StudentView(StudentDataModel databaseModel)
        {
            SourceId = databaseModel.SourceId;
            OldSourceId = databaseModel.OldSourceId;
            PupilAdmissionNumber = databaseModel.PupilAdmissionNumber;
            FirstName = databaseModel.FirstName;
            LegalFirstName = databaseModel.LegalFirstName;
            MiddleName = databaseModel.MiddleName;
            LastName = databaseModel.LastName;
            LegalLastName = databaseModel.LegalLastName;
            FormerLastName = databaseModel.FormerLastName;
            Gender = databaseModel.Gender;
            YearCode = databaseModel.YearCode;
            YearGroupSourceId = databaseModel.YearGroupSourceId;
            Dob = databaseModel.Dob;
            Upn = databaseModel.Upn;
            FormerUpn = databaseModel.FormerUpn;
            Uln = databaseModel.Uln;
            IsEal = databaseModel.IsEal;
            FreeMeal = databaseModel.FreeMeal;
            FreeMeal6 = databaseModel.FreeMeal6;
            FsmReviewDate = databaseModel.FsmReviewDate;
            EthnicityCode = databaseModel.EthnicityCode;
            IsPp = databaseModel.IsPp;
            ServiceChild = databaseModel.ServiceChild;
            LookedAfter = databaseModel.LookedAfter;
            EverInCare = databaseModel.EverInCare;
            SenCategory = databaseModel.SenCategory;
            EnrolmentStatus = databaseModel.EnrolmentStatus;
            AddressLine1 = databaseModel.AddressLine1;
            AddressLine2 = databaseModel.AddressLine2;
            TownCity = databaseModel.TownCity;
            County = databaseModel.County;
            Country = databaseModel.Country;
            Postcode = databaseModel.Postcode;
            StartDate = databaseModel.StartDate;
            EndDate = databaseModel.EndDate;
            HomeLanguageCode = databaseModel.HomeLanguageCode;
            HomeLanguageName = databaseModel.HomeLanguageName;
            FirstLanguageCode = databaseModel.FirstLanguageCode;
            FirstLanguageName = databaseModel.FirstLanguageName;
            ProficiencyInEnglishCode = databaseModel.ProficiencyInEnglishCode;
            ProficiencyInEnglishName = databaseModel.ProficiencyInEnglishName;
            Nationalities = databaseModel.Nationalities;
            CountryOfBirth = databaseModel.CountryOfBirth;
            PhotoHash = databaseModel.PhotoHash;
            NhsNumber = databaseModel.NhsNumber;
            IsPregnant = databaseModel.IsPregnant;
            HasEmergencyConsent = databaseModel.HasEmergencyConsent;
            Points = databaseModel.Points;
        }
        public string SourceId { get; set; }
        public string OldSourceId { get; set; }
        public string PupilAdmissionNumber { get; set; }
        public string FirstName { get; set; }
        public string LegalFirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string LegalLastName { get; set; }
        public string FormerLastName { get; set; }
        public string Gender { get; set; }
        public string YearCode { get; set; }
        public string YearGroupSourceId { get; set; }
        public DateTime Dob { get; set; }
        public string Upn { get; set; }
        public string FormerUpn { get; set; }
        public string Uln { get; set; }
        public bool IsEal { get; set; }
        public string FreeMeal { get; set; }
        public string FreeMeal6 { get; set; }
        public DateTime FsmReviewDate { get; set; }
        public string EthnicityCode { get; set; }
        public bool IsPp { get; set; }
        public bool ServiceChild { get; set; }
        public bool LookedAfter { get; set; }
        public string EverInCare { get; set; }
        public string SenCategory { get; set; }
        public string EnrolmentStatus { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string HomeLanguageCode { get; set; }
        public string HomeLanguageName { get; set; }
        public string FirstLanguageCode { get; set; }
        public string FirstLanguageName { get; set; }
        public string ProficiencyInEnglishCode { get; set; }
        public string ProficiencyInEnglishName { get; set; }
        public string Nationalities { get; set; }
        public string CountryOfBirth { get; set; }
        public string PhotoHash { get; set; }
        public string NhsNumber { get; set; }
        public string IsPregnant { get; set; }
        public string HasEmergencyConsent { get; set; }
        public int Points { get; set; }
    }
}
