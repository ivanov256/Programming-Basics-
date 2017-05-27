using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareofStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            StringBuilder strBeg = new StringBuilder(new string('*', a));
            Console.WriteLine(strBeg.ToString());
            for (int i = 0; i < a - 2; i++)
            {
                StringBuilder strMiddle = new StringBuilder(new string(' ', a - 2));
                Console.Write("*");
                Console.Write(strMiddle.ToString());
                Console.WriteLine("*"); // To Ask
            }
            StringBuilder strEnd = new StringBuilder(new string('*', a));

            Console.WriteLine(strEnd.ToString());
        }
    }
}
