using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataModels.Models
{
    public class ContactModel
    {
        public ContactModel() { }
        public ContactModel(ContactModel contactModel)
        {
            StudentSourceId = contactModel.StudentSourceId;
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
        public string StudentSourceId { get; set; }
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relationship { get; set; }
        public string Description { get; set; }
        public string WrittenCommunication { get; set; }
        public int Priority { get; set; }
        public string ContactPrioritySource { get; set; }
        public string EmergencyContactLevel { get; set; }
        public bool NextOfKin { get; set; }
        public bool AddressDisclosure { get; set; }
        public bool AddressTransferred { get; set; }
        public bool ParentalResponsibility { get; set; }
        public bool FeePayer { get; set; }
        public bool ParentalPortal { get; set; }
        public bool HomeAddressLink { get; set; }
        public bool OtherHomeAddressLink { get; set; }
        public bool SendSms { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
    }
}
