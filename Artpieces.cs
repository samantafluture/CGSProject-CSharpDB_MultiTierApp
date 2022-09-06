using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    class Artpieces : CollectionBase
    {
        public void Add(Artpiece artpiece)
        {
            List.Add(artpiece);
        }
        public Artpiece this[int index]
        {
            get { return (Artpiece)List[index]; }
            set { List[index] = value; }
        }
    }
}
