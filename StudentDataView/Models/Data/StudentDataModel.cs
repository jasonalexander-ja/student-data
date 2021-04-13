using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StudentDataModels.Models;

namespace StudentDataView.Models
{
    public class StudentDataModel : StudentModel
    {
        public StudentDataModel()
        {
        }
        public StudentDataModel(StudentModel studentModel) : base(studentModel)
        {
            StudentDataModelID = studentModel.SourceId;
        }
        public string StudentDataModelID { get; set; }
        public int Points { get; set; }
        public List<ContactDataModel> Contacts { get; set; }
    }
}
