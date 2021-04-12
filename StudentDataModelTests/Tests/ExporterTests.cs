using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentDataModels.Models;
using StudentDataModels.Exporters;

namespace StudentDataModelTests
{
    [TestClass]
    public class MainStudentExporterTest
    {
        public static string FullPathToProject = DataPath.GetPath();

        [TestMethod]
        public void TestExport()
        {
            var testObj = ExampleModelGenerator.StudentModel();
            string exported = MainStudentExporter.Export(testObj);
            string correctModel = File.ReadAllText($"{FullPathToProject}/TestData/correctOutputModel.json");
            Assert.AreEqual(correctModel, exported);
        }
    }
}
