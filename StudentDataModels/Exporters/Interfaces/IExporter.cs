using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataModels.Exporters
{
    public interface IExporter<T>
    {
        static string Export(T fromData) => throw new NotImplementedException();
    }
}
