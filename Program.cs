using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);
            bool win = false;

            do
            {
                Console.Write("Guees a number inbetween 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if(i>winNum)
                {
                    Console.WriteLine("Too high, Guess lower.......");
                }
                else if(i<winNum)
                {
                    Console.WriteLine("Too lower, Guess higher......");

                }
                else if(i==winNum)
                {
                    Console.WriteLine("YOU WIN!!!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Thank You, for playing the game with me. Have a good day.");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
