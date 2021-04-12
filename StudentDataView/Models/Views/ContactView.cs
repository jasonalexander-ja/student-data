using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StudentDataView.Models;

namespace StudentDataView.Models
{
    public class ContactView
    {
        public ContactView()
        {
        }
        public ContactView(ContactDataModel databaseModel)
        {
            ContactId = databaseModel.ContactId;
            FirstName = databaseModel.FirstName;
            LastName = databaseModel.LastName;
            Relationship = databaseModel.Relationship;
            Description = databaseModel.Description;
            WrittenCommunication = databaseModel.WrittenCommunication;
            Priority = databaseModel.Priority;
            ContactPrioritySource = databaseModel.ContactPrioritySource;
            EmergencyContactLevel = databaseModel.EmergencyContactLevel;
            NextOfKin = databaseModel.NextOfKin;
            AddressDisclosure = databaseModel.AddressDisclosure;
            AddressTransferred = databaseModel.AddressTransferred;
            ParentalResponsibility = databaseModel.ParentalResponsibility;
            FeePayer = databaseModel.FeePayer;
            ParentalPortal = databaseModel.ParentalPortal;
            HomeAddressLink = databaseModel.HomeAddressLink;
            OtherHomeAddressLink = databaseModel.OtherHomeAddressLink;
            SendSms = databaseModel.SendSms;
            Title = databaseModel.Title;
            Gender = databaseModel.Gender;
        }
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
