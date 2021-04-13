using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataModels.Models
{
    public class StudentModel
    {
        public StudentModel() { }
        public StudentModel(StudentModel studentModel)
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
            Dob = studentModel.Dob;
            Upn = studentModel.Upn;
            FormerUpn = studentModel.FormerUpn;
            Uln = studentModel.Uln;
            IsEal = studentModel.IsEal;
            FreeMeal = studentModel.FreeMeal;
            FreeMeal6 = studentModel.FreeMeal6;
            FsmReviewDate = studentModel.FsmReviewDate;
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
            StartDate = studentModel.StartDate;
            EndDate = studentModel.EndDate;
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
    }
}
