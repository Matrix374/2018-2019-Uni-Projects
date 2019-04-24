using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTD_AlgoAssignmentTest
{
    using CTD_AlgoAssignment;
    using NUnit.Framework;
    using System.Collections;

    class Test
    {
        private GetCSV csv;
        private ArrayList allCompanies;

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            csv = new GetCSV(@"companies.csv");
            allCompanies = csv.AllCompanies;
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {

        }

        [SetUp]
        public void SetUp()
        {
        }

        public void TearDown()
        {

        }

        [Test]
        public void GetAllCompaniesBSTree()
        {
            BSTree<Company> bsTree = new BSTree<Company>();

            foreach (Company c in allCompanies)
            {
                bsTree.InsertItem(c);
            }

            int total = bsTree.Count();
            int height = bsTree.Height();

            Assert.AreEqual(47, total);
            Assert.AreEqual(12, height);
        }

        [Test]
        public void GetAllCompaniesAVLTree()
        {
            AVLTree<Company> avlTree = new AVLTree<Company>();

            foreach (Company c in allCompanies)
            {
                avlTree.InsertItem(c);
            }

            int total = avlTree.Count();
            int height = avlTree.Height();

            Assert.AreEqual(47, total);
            Assert.AreEqual(6, height);
        }

        [Test]
        public void SearchCompany()
        {
            AVLTree<Company> avlTree = new AVLTree<Company>();

            foreach (Company c in allCompanies)
            {
                avlTree.InsertItem(c);
            }

            Company[] search = new Company[5];
            search[0] = new Company("AMX", 0, 0, 0, 0, null);
            search[1] = new Company("MST", 0, 0, 0, 0, null);
            search[2] = new Company("QWR", 0, 0, 0, 0, null);
            search[3] = new Company("BGR", 0, 0, 0, 0, null);
            search[4] = new Company("CDW", 0, 0, 0, 0, null);

            Assert.IsTrue(avlTree.Contains(search[0]));
            Assert.IsTrue(avlTree.Contains(search[1]));
            Assert.IsFalse(avlTree.Contains(search[2]));
            Assert.IsTrue(avlTree.Contains(search[3]));
            Assert.IsFalse(avlTree.Contains(search[4]));
        }

        [Test]
        public void RemoveCompany()
        {
            AVLTree<Company> avlTree = new AVLTree<Company>();

            foreach (Company c in allCompanies)
            {
                avlTree.InsertItem(c);
            }

            Company[] search = new Company[5];
            search[0] = new Company("AMX", 0, 0, 0, 0, null);
            search[1] = new Company("MST", 0, 0, 0, 0, null);
            search[2] = new Company("BRG", 0, 0, 0, 0, null);
            search[3] = new Company("BGR", 0, 0, 0, 0, null);
            search[4] = new Company("QQQ", 0, 0, 0, 0, null);

            for (int i = 0; i < 5; i++)
            {
                Assert.IsTrue(avlTree.Contains(search[i]));
            }

            for (int i = 0; i < 5; i++)
            {
                avlTree.RemoveItem(search[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Assert.IsFalse(avlTree.Contains(search[i]));
            }
        }

        [Test]
        public void EditCompany()
        {
            int i = 0;
            AVLTree<Company> avlTree = new AVLTree<Company>();

            foreach (Company c in allCompanies)
            {
                avlTree.InsertItem(c);
            }

            Company[] search = new Company[5];
            search[0] = new Company("AMX", 0, 0, 0, 0, null);
            search[1] = new Company("MST", 0, 0, 0, 0, null);
            search[2] = new Company("BRG", 0, 0, 0, 0, null);
            search[3] = new Company("BGR", 0, 0, 0, 0, null);
            search[4] = new Company("QQQ", 0, 0, 0, 0, null);

            Node<Company>[] oldNode = new Node<Company>[5];
            Node<Company>[] newNode = new Node<Company>[5];

            for (i = 0; i < 5; i++)
            {
                oldNode[i] = avlTree.GetNode(search[i]);
                newNode[i] = avlTree.GetNode(search[i]);
            }

            string[] net = new string[5] {"", "4556778", "", "", "" };
            string[] op = new string[5] { "", "25000", "4555211", "", "" };
            string[] tot = new string[5] { "", "34550", "5448799", "54652164", "" };
            string[] emp = new string[5] { "", "894445", "366445", "875561", "64553" };

            for (i = 0; i < 5; i++)
            {
                if (net[i].Equals("") && op[i].Equals("") && tot[i].Equals("") && emp[i].Equals(""))
                {
                    Assert.AreEqual(oldNode[i].Data.NetIncome, newNode[i].Data.NetIncome);
                    Assert.AreEqual(oldNode[i].Data.OpIncome, newNode[i].Data.OpIncome);
                    Assert.AreEqual(oldNode[i].Data.TotalAssets, newNode[i].Data.TotalAssets);
                    Assert.AreEqual(oldNode[i].Data.NumEmployees, newNode[i].Data.NumEmployees);
                }
                else
                {
                    int num = 0;
                    if (net[i].CompareTo("") != 0 && int.TryParse(net[i], out num))
                    {
                        newNode[i].Data.NetIncome = num;
                    }
                    else
                    {
                        net[i] = Convert.ToString(oldNode[i].Data.NetIncome);
                    }

                    if (op[i].CompareTo("") != 0 && int.TryParse(op[i], out num))
                    {
                        newNode[i].Data.OpIncome = num;
                    }
                    else
                    {
                        op[i] = Convert.ToString(oldNode[i].Data.OpIncome);
                    }

                    if (tot[i].CompareTo("") != 0 && int.TryParse(tot[i], out num))
                    {
                        newNode[i].Data.TotalAssets = num;
                    }
                    else
                    {
                        tot[i] = Convert.ToString(oldNode[i].Data.TotalAssets);
                    }

                    if (emp[i].CompareTo("") != 0 && int.TryParse(emp[i], out num))
                    {
                        newNode[i].Data.NumEmployees = num;
                    }
                    else
                    {
                        emp[i] = Convert.ToString(oldNode[i].Data.NumEmployees);
                    }

                    avlTree.EditNode(newNode[i]);
                    newNode[i] = avlTree.GetNode(search[i]);

                    Assert.AreEqual(Convert.ToInt32(net[i]), newNode[i].Data.NetIncome);
                    Assert.AreEqual(Convert.ToInt32(op[i]), newNode[i].Data.OpIncome);
                    Assert.AreEqual(Convert.ToInt32(tot[i]), newNode[i].Data.TotalAssets);
                    Assert.AreEqual(Convert.ToInt32(emp[i]), newNode[i].Data.NumEmployees);
                }
            }
        }
    }
}
