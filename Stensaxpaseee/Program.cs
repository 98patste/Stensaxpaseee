using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stensaxpaseee
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {

                Console.WriteLine("Sten,påse eller sax");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(3);

            if (computerChoice == 0) //Sten
            {
                if (userChoice == "sten")
                {
                    Console.WriteLine("Du valde sten");
                    Console.WriteLine("Det är oavgjort ");
                }
                else if (userChoice == "påse")
                {
                    Console.WriteLine("Du valde påse");
                    Console.WriteLine("Du vann! Påse slår Sten");

                }
                else if (userChoice == "sax")
                {
                    Console.WriteLine("Du valde sax");
                    Console.WriteLine("Du förlorade! Sten slår Sax");
                }
                else
                {
                    Console.WriteLine("Välj mellan sten,påse eller sax!");

                }

            }

            else if (computerChoice == 1) //sax
            {
                if (userChoice == "påse")
                {
                    Console.WriteLine("Du valde Påse");
                    Console.WriteLine("Du förlorade,Sax slår påse");

                }
                else if (userChoice == "sten")
                {
                    Console.WriteLine("Du valde Sten");
                    Console.WriteLine("Du vann,Sten slår sax ");

                }
                else if (userChoice == "sax")
                {
                    Console.WriteLine("Du valde Sax");
                    Console.WriteLine("Det blev oavgjort ");
                }
                else
                {
                    Console.WriteLine("Välj mellan sten,påse eller sax!");
                }
            }
            else if (computerChoice == 2) //Påse
            {
                if (userChoice == "sax")
                {
                    Console.WriteLine("Du valde sax");
                    Console.WriteLine("Du vann,Sax slår påse ");

                }
                else if (userChoice == "påse")
                {
                    Console.WriteLine("Du valde påse");
                    Console.WriteLine("Det blev oavgjort ");

                }
                else if (userChoice == "sax")
                {
                    Console.WriteLine("Du valde sax");
                    Console.WriteLine("Du vann,sax slår påse ");

                }
                else
                {
                    Console.WriteLine("Välj mellan sten,påse eller sax!");

                }

            }

                Console.WriteLine("Nytt spel? tryck valfri knapp eller n");
                ConsoleKeyInfo cki = Console.ReadKey(); //Väntar på att spelaren ska trycka på någon knapp for player to press a key
                if (cki.KeyChar == 'n')
                    keepPlaying = false;                 //Fortsätter tills knappen "n"

                Console.WriteLine("");
            }
            Console.WriteLine("byebye!");
            Console.ReadLine();
        }
    }
}
