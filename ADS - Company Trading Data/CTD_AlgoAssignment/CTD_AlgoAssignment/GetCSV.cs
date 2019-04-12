using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTD_AlgoAssignment
{
    class GetCSV
    {
        public GetCSV(string directory)
        {
            try
            {
                string data = File.ReadAllText(directory);
                Debug.WriteLine(data);
            }
            catch(Exception e)
            {
                Debug.WriteLine("File could not be read");
            }
        }
    }
}
