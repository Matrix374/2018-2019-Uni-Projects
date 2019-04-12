using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTD_AlgoAssignment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Company mst = new Company("MST", 0, 0, 0, 0, null);
            Company wlm = new Company("WLM", 0, 0, 0, 0, null);

            GetCSV csv = new GetCSV("C:\\Users\\Chad\\Documents\\GitHub\\2018-Uni-Projects\\ADS - Company Trading Data\\companies.csv");
            Debug.WriteLine("All Companies");
            foreach (Company c in csv.AllCompanies)
            {
                Debug.WriteLine(c + "\n");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
