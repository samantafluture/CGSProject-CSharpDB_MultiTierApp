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
            Gallery gallery = new Gallery();

            do
            {
                Console.WriteLine("\n**** ART GALLERY ****\n" +
                                    "Please choose one of the following options:\n");
                Console.WriteLine("\n1. Add Curator\n" +
                                    "2. Add Artist\n" +
                                    "3. Add Artpiece\n" +
                                    "4. Sell Artpiece\n" +
                                    "5. Exit\n");

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

/*
Output:

**** ART GALLERY ****
Please choose one of the following options:


1. Add Curator
2. Add Artist
3. Add Artpiece
4. Sell Artpiece
5. Exit

1
Please, enter the curator ID:
11111
Please enter the first name:
samanta
Please enter the last name:
fluture
The curator has been succefully added to the list

**** ART GALLERY ****
Please choose one of the following options:


1. Add Curator
2. Add Artist
3. Add Artpiece
4. Sell Artpiece
5. Exit

2
Please, enter the artist ID:
22222
Please enter the first name:
alissa
Please enter the last name:
osumi
The artist has been succefully added to the list

**** ART GALLERY ****
Please choose one of the following options:


1. Add Curator
2. Add Artist
3. Add Artpiece
4. Sell Artpiece
5. Exit

3
Please enter the artpiece ID:
33333
Please enter the curator ID:
11111
Please enter the artist ID:
22222
Please enter the title:
tom and peta
Please enter the year:
2014
Please enter the value:
100
The artpiece has been succefully added to the list

**** ART GALLERY ****
Please choose one of the following options:


1. Add Curator
2. Add Artist
3. Add Artpiece
4. Sell Artpiece
5. Exit

4
Please enter the artpiece ID:
33333
Please enter the estimate:
200
The artpiece has been sold successfully!

**** ART GALLERY ****
Please choose one of the following options:


1. Add Curator
2. Add Artist
3. Add Artpiece
4. Sell Artpiece
5. Exit

5
Thank you and Good-Bye
 */

