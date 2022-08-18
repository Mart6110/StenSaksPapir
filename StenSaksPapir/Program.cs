using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StenSaksPapir
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Game();
        }
        static void Game()
        {
            Console.WriteLine("Vælg sten, saks eller papir?");
            string userChoice = Console.ReadLine().ToLower();

            Random r = new Random();
            int computerChoice = r.Next(4);

            Console.WriteLine("Sten");
            Thread.Sleep(1000);
            Console.WriteLine("Saks");
            Thread.Sleep(1000);
            Console.WriteLine("Papir");
            Thread.Sleep(1000);

            if (computerChoice == 1)
            {
                if (userChoice == "sten")
                {
                    Console.WriteLine("Computeren valgte sten. Du valgte sten");
                    Console.WriteLine("Det blev uafgjort");
                }
                else if (userChoice == "papir")
                {
                    Console.WriteLine("Computeren valgte sten. Du valgte papir");
                    Console.WriteLine("Du vandt");

                }
                else if (userChoice == "saks")
                {
                    Console.WriteLine("Computeren valgte sten. Du valgte saks");
                    Console.WriteLine("Du tabte");
                }
                else
                {
                    Console.WriteLine("Du skal vælge imellem sten, saks eller papir!");
                }

            }
            else if (computerChoice == 2)
            {
                if (userChoice == "sten")
                {
                    Console.WriteLine("Computeren valgte Saks. Du valgte sten");
                    Console.WriteLine("Du vandt");

                }
                else if (userChoice == "papir")
                {
                    Console.WriteLine("Computeren valgte Saks. Du valgte papir");
                    Console.WriteLine("Du tabte");

                }
                else if (userChoice == "saks")
                {
                    Console.WriteLine("Computeren valgte Saks. Du valgte saks");
                    Console.WriteLine("Det blev uafgjort");
                }
                else
                {
                    Console.WriteLine("Du skal vælge imellem sten, saks eller papir!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "sten")
                {
                    Console.WriteLine("Computeren valgte papir. Du valgte sten");
                    Console.WriteLine("Du tabte");

                }
                else if (userChoice == "papir")
                {
                    Console.WriteLine("Computeren valgte papir. Du valgte papir");
                    Console.WriteLine("Det blev uafgjort");

                }
                else if (userChoice == "saks")
                {
                    Console.WriteLine("Computeren valgte papir. Du valgte saks");
                    Console.WriteLine("Du tabte");
                }
                else
                {
                    Console.WriteLine("Du skal vælge imellem sten, saks eller papir!");
                }
            }
            Program.Repeat();
        }
        static void Repeat()
        {
            Thread.Sleep(15000);
            Console.WriteLine();
            Console.WriteLine("Vil du spille igen? (ja/nej)");
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain == "nej")
            {
                Environment.Exit(1);
            }
            else
            {
                Program.Game();
            }
        }
    }
}
