using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sans_dating_sim
{
    class Program
    {
        static void Main(string[] args)
        {
            //THIS IS A SIN, WE ARE SO SORRY

            //Program starts
            Console.WriteLine("*********************************");
            Console.WriteLine("*                               *");
            Console.WriteLine("*   -------------------------   *");
            Console.WriteLine("*   SANS UNDERTALE DATING SIM   *");
            Console.WriteLine("*   -------------------------   *");
            Console.WriteLine("*                               *");
            Console.WriteLine("*********************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("- START GAME? 'y'");
            Console.WriteLine("");
            Console.Write("- TO EXIT THE GAME, WRITE 'EXIT' ");
            Console.WriteLine("");
            Console.WriteLine("");

            bool datruth = true;

            string input;
            input = Console.ReadLine();


            if (input == "y")
            {
                Console.WriteLine("");
                Console.WriteLine("*You wake up one morning and look at your alarm clock*");
                Console.ReadKey();
                Console.WriteLine("*You're gonna be late for school!*");
                Console.ReadKey();
                Console.WriteLine("*In a swift motion, you put on your ahegao sweatshirt*");
                Console.ReadKey();
                Console.WriteLine("*and stuff a piece of toast into your mouth whilst running out the door*");
                Console.ReadKey();
                Console.WriteLine(" 'I can't be late on my first day of school!' ");
                Console.ReadKey();
                Console.WriteLine("*without thinking, you run around a corner*");
                Console.ReadKey();
                Console.WriteLine("*CRASH*");
                Console.ReadKey();
                Console.WriteLine(" Unknown: 'Ow, what the hell?!' ");
                Console.ReadKey();
                Console.WriteLine(" 'Hey are you ok?' ");
                Console.ReadKey();
                Console.WriteLine("*You come back to your senses and look up at a pale stranger*");
                Console.ReadKey();
                Console.WriteLine("*It's... it's SANS!*");
                Console.ReadKey();
                Console.WriteLine(" 'You ok? you hit your head pretty hard' ");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("Choose a response:");
                Console.WriteLine("");
                Console.WriteLine(" 1 - 'Watch where you're walking nigga' ");
                Console.WriteLine("");
                Console.WriteLine(" 2 - 'Oh..y-yeah, i'm fine' ");
                Console.WriteLine("");
                Console.WriteLine("");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Sans: 'that was uncalled for, i'm just trying to help' ");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Sans: That's great news kiddo, but anyways i gotta jet");
                }

            }
            else if (input == "exit")
            {
                datruth = false;
            }
        }
    }
}