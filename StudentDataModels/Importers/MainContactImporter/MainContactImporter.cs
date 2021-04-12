using System.Collections.Generic;

using System.Text.Json;
using StudentDataModels.Models;

namespace StudentDataModels.Importers
{
    public class MainContactImporter : IImporter<List<ContactModel>>
    {
        public static List<ContactModel> Extract(string inputData)
        {
            var transitionModel = JsonSerializer.Deserialize<JsonTransitionModel>(
                inputData);
            var contactDetailsJson = transitionModel.JsonExtensionData["ContactDetails"];
            string studentSourceId = JsonTransitionModel.StringFromDict(
                transitionModel.JsonExtensionData, "LearnerId");
            var contactDetails = GetContacts(contactDetailsJson, studentSourceId);
            return contactDetails;
        }

        private static List<ContactModel> GetContacts(JsonElement contacts, string studentSourceId)
        {
            List<ContactModel> contactList = new List<ContactModel>();
            foreach(var element in contacts.EnumerateArray())
            {
                var contact = ParseContact(element);
                contact.StudentSourceId = studentSourceId;
                contactList.Add(contact);
            }
            return contactList;
        }
        private static ContactModel ParseContact(JsonElement contactJson)
        {
            var contact = new ContactModel();
            contact.ContactId = JsonTransitionModel.IntFromElem(contactJson, "ContactId");
            contact.FirstName = JsonTransitionModel.StringFromElem(contactJson, "ForeName");
            contact.LastName = JsonTransitionModel.StringFromElem(contactJson, "SurName");
            contact.Relationship = JsonTransitionModel.StringFromElem(contactJson, "Relationship");
            contact.Description = JsonTransitionModel.StringFromElem(contactJson, "Description");
            contact.WrittenCommunication = JsonTransitionModel.StringFromElem(contactJson, "WrittenCommunication");
            contact.Priority = JsonTransitionModel.IntFromElem(contactJson, "Priority");
            contact.ContactPrioritySource = JsonTransitionModel.StringFromElem(contactJson, "ContactPrioritySource");
            contact.EmergencyContactLevel = JsonTransitionModel.StringFromElem(contactJson, "EmergencyContactLevel");
            contact.NextOfKin = JsonTransitionModel.BoolFromElem(contactJson, "NextOfKin");
            contact.AddressDisclosure = JsonTransitionModel.BoolFromElem(contactJson, "AddressDisclosure");
            contact.AddressTransferred = JsonTransitionModel.BoolFromElem(contactJson, "AddressTransferred");
            contact.ParentalResponsibility = JsonTransitionModel.BoolFromElem(contactJson, "ParentalResponsibility");
            contact.FeePayer = JsonTransitionModel.BoolFromElem(contactJson, "FeePayer");
            contact.ParentalPortal = JsonTransitionModel.BoolFromElem(contactJson, "ParentalPortal");
            contact.HomeAddressLink = JsonTransitionModel.BoolFromElem(contactJson, "HomeAddressLink");
            contact.OtherHomeAddressLink = JsonTransitionModel.BoolFromElem(contactJson, "OtherHomeAddressLink");
            contact.SendSms = JsonTransitionModel.BoolFromElem(contactJson, "SendSMS");
            contact.Title = JsonTransitionModel.StringFromElem(contactJson, "Title");
            contact.Gender = JsonTransitionModel.StringFromElem(contactJson, "Gender");
            return contact;
        }
    }
}
