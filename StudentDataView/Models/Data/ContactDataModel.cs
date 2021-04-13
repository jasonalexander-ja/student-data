using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentDataModels.Models;

namespace StudentDataView.Models
{
    public class ContactDataModel : ContactModel
    {
        public ContactDataModel()
        {
        }
        public ContactDataModel(ContactModel contactModel) : base(contactModel)
        {
            StudentDataModelID = contactModel.StudentSourceId;
        }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ContactDataModelID { get; set; }
        // Used as database a key for EntityFramework, should be same as StudentSourceId 
        public string StudentDataModelID { get; set; }
        public StudentDataModel Student { get; set; }
    }
}
