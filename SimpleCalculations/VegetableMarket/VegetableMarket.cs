using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegKg = int.Parse(Console.ReadLine());
            int fruitKg = int.Parse(Console.ReadLine());

            double vegIncomes = vegPrice * vegKg;
            double fruitIncomes = fruitPrice * fruitKg;
            double totalIncomes = vegIncomes + fruitIncomes;
            double totalIncomesEUR = totalIncomes / 1.94;
            Console.WriteLine("{0:f2}", totalIncomesEUR);  
        }
    }
}
