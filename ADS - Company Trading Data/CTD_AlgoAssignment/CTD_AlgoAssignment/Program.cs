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
            AVLTree<string> compTree = new AVLTree<string>();
            Dictionary<String, Company> compDict = new Dictionary<string, Company>();

            GetCSV csv = new GetCSV("C:\\Users\\Chad\\Documents\\GitHub\\2018-Uni-Projects\\ADS - Company Trading Data\\companies.csv");
            foreach (Company c in csv.AllCompanies)
            {
                compTree.InsertItem(c.Name);
                compDict.Add(c.Name, c);
            }

            string output = null;
            compTree.InOrder(ref output); //Alphabetical

            Debug.WriteLine("Amount of Companies: " + compTree.Count());
            Debug.WriteLine("Tree Height: " + compTree.Height());
            Debug.WriteLine("All Companies");
            Debug.WriteLine(output);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
