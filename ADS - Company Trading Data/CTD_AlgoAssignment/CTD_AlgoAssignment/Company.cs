using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTD_AlgoAssignment
{
    class Company
    {
        string name;
        int netIncome, opIncome, totalAssets, numEmployees;
        List<Company> buyer; //Different Data Structure, Linked List? AVLTree? Graphs?

        public Company(string name, int netIncome, int opIncome, int totalAssets, int numEmployees, List<Company> buyer)
        {
            Name = name;
            NetIncome = netIncome;
            OpIncome = opIncome;
            TotalAssets = totalAssets;
            NumEmployees = numEmployees;
            Buyer = buyer;
        }

        public string Name { get => name; set => name = value; }
        public int NetIncome { get => netIncome; set => netIncome = value; }
        public int OpIncome { get => opIncome; set => opIncome = value; }
        public int TotalAssets { get => totalAssets; set => totalAssets = value; }
        public int NumEmployees { get => numEmployees; set => numEmployees = value; }
        internal List<Company> Buyer { get => buyer; set => buyer = value; }

        public override string ToString()
        {
            return "Company : " + Name + "\n" +
                "Net Income : " + NetIncome + "\n" +
                "Operating Income : " + OpIncome + "\n" +
                "Total Assets : " + TotalAssets + "\n" +
                "NumEmployees : " + NumEmployees + "\n" +
                "Buyers : " + Buyer + "\n";
        }
    }
}
