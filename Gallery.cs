using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
                if (CuratorVerifier(curID) == true)
                {
                    Console.WriteLine("Error! This id already exists");
                }
                else
                {
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
                if (ArtistVerifier(aID) == true)
                {
                    Console.WriteLine("Error! This id already exists");
                } else
                {
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
        }

        public void AddArtpiece()
        {
            Console.WriteLine("Please enter the artpiece ID: ");
            string pID = Console.ReadLine();

            if (pID.Length != 5)
            {
                Console.WriteLine("Error! The id should have 5 characters");
            }
            else
            {
                if (ArtpieceVerifier(pID) == true)
                {
                    Console.WriteLine("Error! This id already exists");
                }
                else
                {
                    Console.WriteLine("Please enter the curator ID: ");
                    string cID = Console.ReadLine();

                    if (CuratorVerifier(cID) == true)
                    {
                        Console.WriteLine("Error! This id already exists");
                    }
                    else
                    {
                        Console.WriteLine("Please enter the artist ID: ");
                        string aID = Console.ReadLine();

                        if (ArtistVerifier(aID) == true)
                        {
                            Console.WriteLine("Error! This id already exists");
                        }
                        else
                        {
                            Console.WriteLine("Please enter the title: ");
                            string title = Console.ReadLine();

                            Console.WriteLine("Please enter the year: ");
                            int year = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Please enter the value: ");
                            double value = Convert.ToDouble(Console.ReadLine());

                            // set default estimate and status values
                            double estimate = 0.0;
                            char status = 'E';

                            Artpiece artpiece = new Artpiece(pID, title, year, value,
                                estimate, status, aID, cID);
                            myArtpieces.Add(artpiece);

                            Console.WriteLine("The artpiece has been succefully added to the list");
                        }
                    }
                }

            }
        }

        // check if artpiece ID exists (if is valid)
        public bool ArtpieceVerifier(string artPId)
        {
            bool flag = false;

            foreach (Artpiece piece in myArtpieces)
            {
                if (piece.GetId() == artPId)
                {
                    flag = true;
                }
            }

            return flag;
        }

        // check if artist ID exists (if is valid)
        public bool ArtistVerifier(string artId)
        {
            bool flag = false;

            foreach (Artist artist in myArtists)
            {
                if (artist.GetID() == artId)
                {
                    flag = true;
                }
            }

            return flag;
        }

        // check if curator ID exists (if is valid)
        public bool CuratorVerifier(string cId)
        {
            bool flag = false;

            foreach (Curator curator in myCurators)
            {
                if (curator.GetID() == cId)
                {
                    flag = true;
                }
            }

            return flag;
        }

    }
}