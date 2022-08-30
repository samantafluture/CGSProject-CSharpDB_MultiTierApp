using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    // abstract -> we do not instantiated, they are meant to be inherent
    abstract class Person
    {
        // default -> is private 
        // local variables
        string firstName;
        string lastName;

        // constructor -> method to initialize the local variables (same name of the class)
        // receive arguments / paramenters
        // this -> refers to the local variables
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // get and set methods
        public string FirstName 
        { 
            get 
            { 
                return firstName; 
            } 
            set 
            { 
                firstName = value; 
            } 
        }

        public string LastName 
        {
            get 
            { 
                return lastName; 
            } 
            set 
            { 
                lastName = value; 
            } 
        }

        // use properties instead of local variables this.firstName...
        // override a method that is inhenrit 
        // virtual because it is going to be override by its child
        public virtual string toString()
        {
            return FirstName + " " + LastName;
        }
    }
}
