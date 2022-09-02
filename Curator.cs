using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    class Curator : Person
    { 
        string curatorID;
        double commission;
        const double commissionRate = 0.25;

        // no initialization is required for firstName and lastName
        // because they are from Person class
        // just initialize local variables
        // minus the const one (commisionRate)
        public Curator(string curatorID, double commision, string firstName, 
            string lastName) : base(firstName, lastName)
        {
            this.curatorID = curatorID;
            this.commission = commision;
        }

        public string CuratorID
        {
            get { return curatorID; }
            set { curatorID = value; }
        }

        public double Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public string GetID()
        {
            return CuratorID;
        }

        public void SetCommission(double comm)
        {
            Commission += comm;
        }

        public void clearCommand()
        {
            Console.Clear();
        }

        // override a method that is inhenrit 
        public override string toString()
        {
            return CuratorID + " " + base.toString() + " " +  Commission;
        }
    }
}


