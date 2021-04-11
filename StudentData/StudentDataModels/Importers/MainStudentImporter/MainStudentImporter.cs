using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentDataModels.Models;

namespace StudentDataModels.Importers
{
    public class MainStudentImporter : IImporter<StudentModel>
    {
        public static StudentModel Extract(string inputData)
        {
            var studentModel = new StudentModel();
            return studentModel;
        }
    }
}
