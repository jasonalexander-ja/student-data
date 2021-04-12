using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataModels.Importers
{
    public interface IImporter<T>
    {
        static T Extract(string inputData) => throw new NotImplementedException();
    }
}
