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
        AVLTree<Company> compTree = new AVLTree<Company>();

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
                    companyList.Items.Add(c.Name, c.Name, c.Name); //Flawed Implementation Maybe
                    compTree.InsertItem(c);
                }

                companyList.FullRowSelect = true;

                totalCompLabel.Text = "Total Companies : " + compTree.Count();
                treeHeightLabel.Text = "Tree Height : " + compTree.Height();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            Company search = new Company(searchBox.Text, 0, 0, 0, 0, null);
            if (compTree.Contains(search))
            {
                Node<Company> result = compTree.GetNode(search);
                companyName.Text = result.Data.Name;
                companyDetails.Text = result.Data.ToString();
            }
            else
            {
                searchBox.Text += " not found";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Company search = new Company(companyName.Text, 0, 0, 0, 0, null);
            Node<Company> result = compTree.GetNode(search);

            if (result != null)
            {
                compTree.RemoveItem(result.Data);

                companyList.Items.RemoveByKey(result.Data.Name);
                companyList.Refresh();

                companyName.Text = "Company Name";
                companyDetails.Text = "Company Details";

                searchBox.Text = "";
                totalCompLabel.Text = "Total Companies : " + compTree.Count();
                treeHeightLabel.Text = "Tree Height : " + compTree.Height();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void companyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (companyList.SelectedItems.Count > 0)
            {
                string name = companyList.SelectedItems[index: 0].Text;

                Company search = new Company(name, 0, 0, 0, 0, null);
                Node<Company> result = compTree.GetNode(search);

                if (result != null)
                {
                    companyName.Text = result.Data.Name;
                    companyDetails.Text = result.Data.ToString();
                }
            }
        }
    }
}
