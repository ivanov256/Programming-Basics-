using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            //CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime result = DateTime.ParseExact(birthDate, "dd-MM-yyyy", null);
            DateTime date = result.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
            
        }
    }
}
