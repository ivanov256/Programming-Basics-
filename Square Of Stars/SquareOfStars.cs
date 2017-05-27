using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStarsSoftUni
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', a));
            for (int i = 1; i <= a - 2; i++)
                Console.WriteLine("*" + new string(' ', a - 2) + "*");
            Console.WriteLine(new string('*', a));         
        }
    }
}
