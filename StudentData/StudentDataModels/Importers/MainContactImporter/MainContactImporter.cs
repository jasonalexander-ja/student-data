using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentDataModels.Models;

namespace StudentDataModels.Importers
{
    public class MainContactImporter : IImporter<ContactModel>
    {
        public static ContactModel Extract(string inputData)
        {
            var studentModel = new ContactModel();
            return studentModel;
        }
    }
}
