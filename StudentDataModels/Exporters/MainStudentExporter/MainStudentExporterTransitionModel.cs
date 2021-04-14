using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json.Serialization;
using StudentDataModels.Models;

namespace StudentDataModels.Exporters
{
    class MainStudentExporterTransitionModel : StudentModel
    {
        public MainStudentExporterTransitionModel(StudentModel studentModel) : base(studentModel)
        {
            Dob = ParseDate(studentModel.Dob);
            FsmReviewDate = ParseDate(studentModel.FsmReviewDate);
            StartDate = ParseDate(studentModel.StartDate);
            EndDate = ParseDate(studentModel.EndDate);
        }
        private static string ParseDate(DateTime date)
        {
            DateTime blankDate = new DateTime();
            string output = blankDate != date ?
                date.ToString() : null;
            return output;
        }
        public new string Dob { get; set; }
        public new string FsmReviewDate { get; set; }
        public new string StartDate { get; set; }
        public new string EndDate { get; set; }
    }
}
