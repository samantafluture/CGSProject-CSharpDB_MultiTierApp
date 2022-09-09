using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("**** ART GALLERY ****\n" +
                                    "Please choose one of the following options:\n");
                Console.WriteLine("\n1. Add Curator\n" +
                                    "2. Add Artist\n" +
                                    "3. Add Artpiece\n" +
                                    "4. Sell Artpiece\n" +
                                    "5. Exit\n");

                Gallery gallery = new Gallery();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        gallery.AddCurator();
                        break;
                    case "2":
                        gallery.AddArtist();
                        break;
                    case "3":
                        gallery.AddArtpiece();
                        break;
                    case "4":
                        gallery.SellArtpiece();
                        break;
                    case "5":
                        Console.WriteLine("Thank you and Good-Bye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 5");
                        break;
                }
            } while (true);
        }
    }
}

    