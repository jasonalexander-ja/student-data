using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentDataModels.Models;

namespace StudentDataView.Models
{
    public class ContactDataModel : ContactModel
    {
        public ContactDataModel()
        {
        }
        public ContactDataModel(ContactModel contactModel)
        {
            StudentSourceId = contactModel.StudentSourceId;
            StudentDataModelID = contactModel.StudentSourceId;
            ContactId = contactModel.ContactId;
            FirstName = contactModel.FirstName;
            LastName = contactModel.LastName;
            Relationship = contactModel.Relationship;
            Description = contactModel.Description;
            WrittenCommunication = contactModel.WrittenCommunication;
            Priority = contactModel.Priority;
            ContactPrioritySource = contactModel.ContactPrioritySource;
            EmergencyContactLevel = contactModel.EmergencyContactLevel;
            NextOfKin = contactModel.NextOfKin;
            AddressDisclosure = contactModel.AddressDisclosure;
            AddressTransferred = contactModel.AddressTransferred;
            ParentalResponsibility = contactModel.ParentalResponsibility;
            FeePayer = contactModel.FeePayer;
            ParentalPortal = contactModel.ParentalPortal;
            HomeAddressLink = contactModel.HomeAddressLink;
            OtherHomeAddressLink = contactModel.OtherHomeAddressLink;
            SendSms = contactModel.SendSms;
            Title = contactModel.Title;
            Gender = contactModel.Gender;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ContactDataModelID { get; set; }
        // Used as database a key for EntityFramework, should be same as StudentSourceId 
        public string StudentDataModelID { get; set; }
        public StudentDataModel Student { get; set; }
    }
}
