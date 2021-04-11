using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentDataModels.Models;

namespace StudentDataModels.Exporters
{
    public class MainStudentExporter : IExporter<StudentModel>
    {
        public string Export(StudentModel fromData)
        {
            return "";
        }
    }
}
