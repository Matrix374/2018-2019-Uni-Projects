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

            foreach(Company c in allCompanies)
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
            //See if Remove removes Companies from Trees
        }

        [Test]
        public void EditCompany()
        {
            //See if Edit's values matches expected value
        }

        [Test]
        public void GetBuyers()
        {
            //Assert that buyers actually exist
        }
    }
}
