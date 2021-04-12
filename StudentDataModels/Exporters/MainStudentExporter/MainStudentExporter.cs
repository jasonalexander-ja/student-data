using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using StudentDataModels.Models;

namespace StudentDataModels.Exporters
{
    public class MainStudentExporter : IExporter<StudentModel>
    {
        public static string Export(StudentModel student)
        {
            var transitionObject = new MainStudentExporterTransitionModel(student);
            return JsonSerializer.Serialize(transitionObject);
        }
    }
}
