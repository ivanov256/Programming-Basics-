using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class SchoolLab
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            var rows = (h * 100) / 120;
            var cols = ((w * 100) - 100) / 70;
            var places = Math.Floor(rows) * Math.Floor(cols) - 3;
            Console.WriteLine(places);

            
        }
    }
}
