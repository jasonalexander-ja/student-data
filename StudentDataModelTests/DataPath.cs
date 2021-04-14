using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataModelTests
{
    class DataPath
    {
        // Gets the path of the current project, comes back 3 directories 
        // from the working directory 
        public static string GetPath() => System.IO.Path.GetFullPath(@"..\..\..\");
    }
}
