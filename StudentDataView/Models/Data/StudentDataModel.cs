using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StudentDataModels.Models;

namespace StudentDataView.Models
{
    public class StudentDataModel : StudentModel
    {
        public StudentDataModel()
        {
        }
        public StudentDataModel(StudentModel studentModel)
        {
            SourceId = studentModel.SourceId;
            StudentDataModelID = studentModel.SourceId;
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
        public string StudentDataModelID { get; set; }
        public int Points { get; set; }
        public List<ContactDataModel> Contacts { get; set; }
    }
}
