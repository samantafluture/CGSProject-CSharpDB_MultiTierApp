using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    class Gallery
    {
        // instantiate the list of curators from the class Curators
        Curators myCurators = new Curators();
        Artists myArtists = new Artists();
        Artpieces myArtpieces = new Artpieces();

        // each method should have 1 functionalty (OOP)
        // as generic as possible, independent
        // stored in a list of objects
        public void AddCurator()
        {
            Console.WriteLine("Please, enter the curator ID: ");
            string curID = Console.ReadLine();

            // id -> check for the lenght
            if (curID.Length != 5)
            {
                Console.WriteLine("Error! The CuratorID should be exactly 5 characters");
            }
            else
            {
                // id -> check if id already exists in the list (uniqueness of ID)
                // myCurators -> object list for the class Curators
                foreach (Curator cur in myCurators)
                {
                    if (cur.GetID() == curID)
                    {
                        Console.WriteLine("Error! There is another curator with this ID");
                        return;
                        // return if there's another curator with this ID (or the condition is false)
                        // break is used to exit (escape) the loop that you are currently executing
                        // return will exit the entire method you are currently executings
                    }

                }
                Console.WriteLine("Please enter the first name: ");
                string fn = Console.ReadLine();
                Console.WriteLine("Please enter the last name: ");
                string ln = Console.ReadLine();

                // fn, ln -> check for the lenght
                if (fn.Length + ln.Length > 40)
                {
                    Console.WriteLine("Error! The lenght of full name should be less than 40 characters");
                }
                else
                {
                    double commission = 0.0;

                    // instantiate the class of curator
                    Curator cur = new Curator(curID, commission, fn, ln);

                    // add the current object to the list
                    // object is a copy of the class
                    myCurators.Add(cur);
                    Console.WriteLine("The curator has been succefully added to the list");
                }
            }
        }

        public void AddArtist()
        {
            Console.WriteLine("Please, enter the artist ID: ");
            string aID = Console.ReadLine();

            if (aID.Length != 5)
            {
                Console.WriteLine("Error! The artist ID should be exactly 5 characters");
            }
            else
            {
                foreach (Artist artist in myArtists)
                {
                    if (artist.GetID() == aID)
                    {
                        Console.WriteLine("Error! There is another artist with this ID");
                        return;
                    }
                }

                Console.WriteLine("Please enter the first name: ");
                string fn = Console.ReadLine();
                Console.WriteLine("Please enter the last name: ");
                string ln = Console.ReadLine();

                if (fn.Length + ln.Length > 40)
                {
                    Console.WriteLine("Error! The lenght of full name should be less than 40 characters");
                }
                else
                {
                    Artist artist = new Artist(aID, fn, ln);
                    myArtists.Add(artist);

                    Console.WriteLine("The artist has been succefully added to the list");
                }
            }
        }

        public void AddArtpiece()
        {
            Console.WriteLine("Please enter the artpiece ID: ");
            string pID = Console.ReadLine();

            if (pID.Length != 5)
            {
                Console.WriteLine("Error! The artpieceID should have 5 characters");
            }
            else
            {
                foreach (Artpiece piece in myArtpieces)
                {
                    if (piece.GetId() == pID)
                    {
                        Console.WriteLine("Error! There is another artpiece with this ID");
                        return;
                    }
                }

                Console.WriteLine("Please enter the title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Please enter the year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the value: ");
                double value = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the estimate: ");
                double estimate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the status: ");
                char status = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Please enter the artist ID: ");
                string aID = Console.ReadLine();

                if (aID.Length != 5)
                {
                    Console.WriteLine("Error! The artist ID should be exactly 5 characters");
                }
                else
                {
                    foreach (Artist artist in myArtists)
                    {
                        if (artist.GetID() == aID)
                        {
                            Console.WriteLine("Error! There is another artist with this ID");
                            return;
                        }
                    }

                    Console.WriteLine("Please enter the curator ID: ");
                    string cID = Console.ReadLine();

                    if (cID.Length != 5)
                    {
                        Console.WriteLine("Error! The CuratorID should be exactly 5 characters");
                    }
                    else
                    {
                        foreach (Curator cur in myCurators)
                        {
                            if (cur.GetID() == cID)
                            {
                                Console.WriteLine("Error! There is another curator with this ID");
                                return;
                            }

                        }

                        Artpiece artpiece = new Artpiece(pID, title, year, value, estimate, status, aID, cID);
                        myArtpieces.Add(artpiece);

                        Console.WriteLine("The artpiece has been succefully added to the list");
                    }
                }
            }
        }
    }
}