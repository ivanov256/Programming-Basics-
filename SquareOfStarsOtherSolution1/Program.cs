using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_SquareOfStarsOtherSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            int i, k;

            for (i = 0; i < a; i++) //We draw the top of the square
            {
                Console.Write("*");
            }
            for (i = 0; i < a - 2; i++) //Determines what to do on each row
            {
                Console.WriteLine();
                Console.Write("*");

                for (k = 0; k < a - 2; k++) //Draws the inner of the square
                {
                    Console.Write(" ");
                }

                Console.Write("*");
            }
            Console.WriteLine(); //We draw the bottom of the square
            for (i = 0; i < a; i++)
            {
                Console.Write("*");
            }
        }
    }
}
