using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    class Artists : CollectionBase
    {
        public void Add(Artist artist)
        {
            List.Add(artist);
        }
        public Artist this[int index]
        {
            get { return (Artist)List[index]; }
            set { List[index] = value; }
        }
    }
}
