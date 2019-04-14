using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTD_AlgoAssignment
{
    public partial class Form1 : Form
    {
        AVLTree<string> compTree = new AVLTree<string>();
        Dictionary<String, Company> compDict = new Dictionary<string, Company>();

        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFile.FileName;
                try
                {
                    pathText.Text = fileName;
                }
                catch (IOException)
                {
                    Debug.WriteLine("Cannot Find File");
                }
            }
        }

        private void pathSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                GetCSV csv = new GetCSV(pathText.Text);
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
            catch (Exception)
            {
                Debug.WriteLine("Cannot Open File");
            }
        }

        Boolean select = false;

        private void sortButton_Click(object sender, EventArgs e)
        {

            if(select)
            {
                sortButton.Text = "Sort : Alphabetical";
                companyList.Sorting = SortOrder.Descending;
                companyList.Refresh();
                select = false;
            }
            else
            {
                sortButton.Text = "Sort: Reverse Alphabetical";
                companyList.Sorting = SortOrder.Ascending;
                companyList.Refresh();
                select = true;
            }
        }
    }
}
