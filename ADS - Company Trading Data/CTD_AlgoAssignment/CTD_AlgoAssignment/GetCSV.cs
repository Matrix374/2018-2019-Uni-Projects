using System;
using System.Collections;

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
        ArrayList allCompanies = new ArrayList();

        public GetCSV(string directory)
        {
            try 
            {
                StreamReader reader = new StreamReader(directory);
                Company c;
                ArrayList b;
                int i = 0;

                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var charsToRemove = new string[] { "[", "]" };

                    foreach (string brackets in charsToRemove)
                    {
                        values[5] = values[5].Replace(brackets, string.Empty);
                    }

                    var buyers = values[5].Split(';');

                    b = new ArrayList(buyers);

                    if (i > 0)
                    {
                        c = new Company(values[0], Convert.ToInt32(values[1]), Convert.ToInt32(values[2]), Convert.ToInt32(values[3]), Convert.ToInt32(values[4]), b);
                        AllCompanies.Add(c);
                    }

                    i++;
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine("Could not read file");
            }
        }

        public ArrayList AllCompanies { get => allCompanies; set => allCompanies = value; }
    }
}
