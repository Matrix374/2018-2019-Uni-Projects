using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTD_AlgoAssignment
{
    class Company : IComparable
    {
        string name;
        int netIncome, opIncome, totalAssets, numEmployees;
        ArrayList buyer = new ArrayList();

        public Company(string name, int netIncome, int opIncome, int totalAssets, int numEmployees, ArrayList buyer)
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
        public ArrayList Buyer { get => buyer; set => buyer = value; }

        public int CompareTo(object obj)
        {
            Company other = (Company)obj;
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            string value = "Company : " + Name + "\n" +
                "Net Income : " + NetIncome + "\n" +
                "Operating Income : " + OpIncome + "\n" +
                "Total Assets : " + TotalAssets + "\n" +
                "NumEmployees : " + NumEmployees + "\n" +
                "Buyer: ";

            foreach(string b in Buyer)
            {
                value += b + ", ";
            }

            return value;
        }
    }
}
