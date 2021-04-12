using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

using StudentDataModels.Models;
using StudentDataModels.Importers;
using StudentDataView.Models;

namespace StudentDataView.Data
{
    public class DbInitialiser
    {
        public static void Initialise(StudentDataContext context)
        {
            if (context.Students.Any())
                return; // Database has been seeded 
            SeedDb(context);
        }

        private static void SeedDb(StudentDataContext context)
        {
            var files = GetAllFilesInDir("./TestData/Students");
            foreach(string file in files)
            {
                string data = File.ReadAllText(file);
                var student = MainStudentImporter.Extract(data);
                context.Students.Add(new StudentDataModel(student));
                context.SaveChanges();

                var contacts = MainContactImporter.Extract(data);
                AddContactModels(contacts, context);
            }
        }

        private static void AddContactModels(
            List<ContactModel> contactModels,
            StudentDataContext context)
        {
            foreach(var contact in contactModels)
            {
                context.Contacts.Add(new ContactDataModel(contact));
                context.SaveChanges();
            }
        }

        private static IEnumerable<string> GetAllFilesInDir(string directory) => 
            Directory.EnumerateFiles(directory, "*.json");
    }
}
