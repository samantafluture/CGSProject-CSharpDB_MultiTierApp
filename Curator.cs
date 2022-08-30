using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    internal class Curator : Person
    {
        const double commRate = 0.1; 
        string curatorID;
        double commission;

        public Curator(string firstName, string lastName, string curatorID, double commision) 
            : base(firstName, lastName)
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

        public void SetComm(double newCommission)
        {
            Commission += newCommission;
        }

        public override string ToString()
        {
            return base.ToString() + " " + CuratorID + " " + Commission;
        }
    }
}
