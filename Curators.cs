using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    // inherets from a coletor of data structure / colletion base
    // collection base is a package for data structure
    // in that way, I can call list
    // we add an object into the list
    class Curators : CollectionBase
        // in charge of: data structures
    {
        public void Add(Curator curator)
        {
            List.Add(curator);
        }

        // special method; get access to access of list
        // it's like a "casting" of the class Curators 
        public Curator this[int index]
        {
            // type casting, changing the type of a variable if it is necessary for the result
            get { return (Curator)List[index]; } 
            set { List[index] = value;}
        }
    }
}
