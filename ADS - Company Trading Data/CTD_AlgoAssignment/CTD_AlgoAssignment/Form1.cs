using System;
using System.Collections;
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
        Label[] buyer;

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

            if(companyList != null)
            {
                companyList.Clear();
                companyList.Refresh();
                buyList.Clear();
                buyList.Refresh();
            }
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
            buyList.Clear();
            buyList.Refresh();
            Company search = new Company(searchBox.Text, 0, 0, 0, 0, null);
            if (compTree.Contains(search))
            {
                Node<Company> result = compTree.GetNode(search);
                companyName.Text = result.Data.Name;
                netIncomeLabel.Text = "Net Income : " + Convert.ToString(result.Data.NetIncome);
                opIncomeLabel.Text = "Operating Income : " + Convert.ToString(result.Data.OpIncome);
                totalAssetsLabel.Text = "Total Assets : " + Convert.ToString(result.Data.TotalAssets);
                numEmployeesLabel.Text = "Number of Employees : " + Convert.ToString(result.Data.NumEmployees);
                buyLabel.Text = "Buyer : ";

                foreach (string b in result.Data.Buyer)
                {
                    buyList.Items.Add(b);
                }

                buyList.Refresh();
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
                netIncomeLabel.Text = "Net Income : ";
                opIncomeLabel.Text = "Operating Income : ";
                totalAssetsLabel.Text = "Total Assets : ";
                numEmployeesLabel.Text = "Number of Employees : ";
                buyLabel.Text = "Buyer : ";

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
            buyList.Clear();
            buyList.Refresh();
            if (companyList.SelectedItems.Count > 0)
            {
                string name = companyList.SelectedItems[index: 0].Text;

                Company search = new Company(name, 0, 0, 0, 0, null);
                Node<Company> result = compTree.GetNode(search);

                if (result != null)
                {
                    companyName.Text = result.Data.Name;
                    netIncomeLabel.Text = "Net Income : " + Convert.ToString(result.Data.NetIncome);
                    opIncomeLabel.Text = "Operating Income : " + Convert.ToString(result.Data.OpIncome);
                    totalAssetsLabel.Text = "Total Assets : " + Convert.ToString(result.Data.TotalAssets);
                    numEmployeesLabel.Text = "Number of Employees : " + Convert.ToString(result.Data.NumEmployees);
                    buyLabel.Text = "Buyer : ";

                    foreach (string b in result.Data.Buyer)
                    {
                        buyList.Items.Add(b);
                    }

                    buyList.Refresh();
                }
            }
        }

        private void buyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buyList.SelectedItems.Count > 0)
            {
                string name = buyList.SelectedItems[index: 0].Text;

                Company search = new Company(name, 0, 0, 0, 0, null);
                Node<Company> result = compTree.GetNode(search);

                if (result != null)
                {
                    companyName.Text = result.Data.Name;
                    netIncomeLabel.Text = "Net Income : " + Convert.ToString(result.Data.NetIncome);
                    opIncomeLabel.Text = "Operating Income : " + Convert.ToString(result.Data.OpIncome);
                    totalAssetsLabel.Text = "Total Assets : " + Convert.ToString(result.Data.TotalAssets);
                    numEmployeesLabel.Text = "Number of Employees : " + Convert.ToString(result.Data.NumEmployees);
                    buyLabel.Text = "Buyer : ";

                    buyList.Clear();

                    foreach (string b in result.Data.Buyer)
                    {
                        buyList.Items.Add(b);
                    }

                    buyList.Refresh();
                }
            }
        }

        private void tradeButton_Click(object sender, EventArgs e)
        {
            int tradePotential = 0;
            string maxCompany = null;
            ArrayList allCompanies = compTree.GetAll();
            foreach(Company c in allCompanies)
            {
                int temp = 0;
                foreach(string b in c.Buyer)
                {
                    Node<Company> tempComp;
                    Company search = new Company(b, 0, 0, 0, 0, null);
                    tempComp = compTree.GetNode(search);

                    temp += tempComp.Data.NetIncome;
                }

                if(tradePotential < temp)
                {
                    tradePotential = temp;
                    maxCompany = c.Name;
                }
            }

            tradeLabel.Text = "Company with Biggest Potential is: " + maxCompany;
        }
    }
}
