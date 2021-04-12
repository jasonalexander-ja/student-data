using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentDataModels.Models;
using StudentDataModels.Importers;

namespace StudentDataModelTests
{
    [TestClass]
    public class ContactsImporterTest
    {
        public static string FullPathToProject = DataPath.GetPath();

        [TestMethod]
        public void TestImport()
        {
            string inputJson = File.ReadAllText($"{FullPathToProject}/TestData/inputTestModel.json");
            var importedModel = MainContactImporter.Extract(inputJson);
            var imported = importedModel.Where(contact => contact.ContactId == 3469).First();
            Assert.IsNotNull(imported);
            var correctModel = ExampleModelGenerator.ContactImportExample();
            CheckModels(imported, correctModel);
        }

        private static void CheckModels(ContactModel imported, ContactModel actual)
        {
            Assert.AreEqual(imported.AddressDisclosure, actual.AddressDisclosure);
            Assert.AreEqual(imported.AddressTransferred, actual.AddressTransferred);
            Assert.AreEqual(imported.ContactId, actual.ContactId);
            Assert.AreEqual(imported.ContactPrioritySource, actual.ContactPrioritySource);
            Assert.AreEqual(imported.Description, actual.Description);
            Assert.AreEqual(imported.EmergencyContactLevel, actual.EmergencyContactLevel);
            Assert.AreEqual(imported.FeePayer, actual.FeePayer);
            Assert.AreEqual(imported.FirstName, actual.FirstName);
            Assert.AreEqual(imported.Gender, actual.Gender);
            Assert.AreEqual(imported.HomeAddressLink, actual.HomeAddressLink);
            Assert.AreEqual(imported.LastName, actual.LastName);
            Assert.AreEqual(imported.NextOfKin, actual.NextOfKin);
            Assert.AreEqual(imported.OtherHomeAddressLink, actual.OtherHomeAddressLink);
            Assert.AreEqual(imported.ParentalPortal, actual.ParentalPortal);
            Assert.AreEqual(imported.ParentalResponsibility, actual.ParentalResponsibility);
            Assert.AreEqual(imported.Priority, actual.Priority);
            Assert.AreEqual(imported.Relationship, actual.Relationship);
            Assert.AreEqual(imported.SendSms, actual.SendSms);
            Assert.AreEqual(imported.Title, actual.Title);
            Assert.AreEqual(imported.WrittenCommunication, actual.WrittenCommunication);
        }

    }
}
