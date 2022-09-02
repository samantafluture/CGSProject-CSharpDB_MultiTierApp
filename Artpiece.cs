using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    // when it's nothing before class, it's private
    // by default, everything is private
    class Artpiece
    {
        string pieceID, title, artistID, curatorID;
        int year;
        double value, estimate; // value = price; estimate = offer
        char status;

        public Artpiece(string pieceID, string title, int year, double value,
            double estimate, char status, string artistID, string curatorID)
        {
            this.pieceID = pieceID;
            this.title = title;
            this.year = year;
            this.value = value;
            this.estimate = estimate;
            this.status = status;
            this.artistID = artistID;
            this.curatorID = curatorID;
        }

        public string PieceID
        {
            get { return pieceID; }
            set { pieceID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Year
        {
            get { return year;  }
            set { year = value;  }
        }

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public double Estimate
        {
            get { return estimate; }
            set { estimate = value; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
        }

        public string ArtistID
        {
            get { return artistID; }
            set { artistID = value; }
        }

        public string CuratorID
        {
            get { return curatorID; }
            set { curatorID = value; }
        }


        public string GetId()
        {
            return PieceID;
        }

        public override string ToString()
        {
            return PieceID + " " + Title + " " + this.curatorID + " " + this.artistID + 
                " " + Year + " " + Value + " " + Estimate + " " + Status;
        }

        public void ChangeStatus(char stat)
        {
            Status = stat;
        }

        public double CalculateComm(double val, double est)
        {
            return (est - val) * 0.10;
        }
    }
}
