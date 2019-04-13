using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTD_AlgoAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AVLTree<string> compTree = new AVLTree<string>();
            Dictionary<String, Company> compDict = new Dictionary<string, Company>();

            GetCSV csv = new GetCSV("C:\\Users\\Chad\\Documents\\GitHub\\2018-Uni-Projects\\ADS - Company Trading Data\\companies.csv");
            foreach (Company c in csv.AllCompanies)
            {
                companyList.Items.Add(c.Name);
                compTree.InsertItem(c.Name);
                compDict.Add(c.Name, c);
            }

            string output = null;
            compTree.InOrder(ref output); //Alphabetical

            Debug.WriteLine("Amount of Companies: " + compTree.Count());
            Debug.WriteLine("Tree Height: " + compTree.Height());
            Debug.WriteLine("All Companies");
            Debug.WriteLine(output);
        }

    }
}
