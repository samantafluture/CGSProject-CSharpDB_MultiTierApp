using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    class Artist : Person
    {
        string artistID;

        public Artist(string artistID, string firstName,
            string lastName) : base(firstName, lastName)
        {
            this.artistID = artistID;
        }

        public string ArtistID
        {
            get { return artistID; }
            set { artistID = value; }
        }

        public override string toString()
        {
            return ArtistID + " " + base.toString();
        }

        public string GetID()
        {
            return artistID;
        }
    }
}
