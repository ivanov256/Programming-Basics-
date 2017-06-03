using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCurrencyConvertor
{
    class ConsoleCurrencyConvertor
    {
        static void Main(string[] args)
        {
            decimal currencyAmount = decimal.Parse(Console.ReadLine());
            string currencyInput = Console.ReadLine();
            string currencyOutput = Console.ReadLine();

            if (currencyInput == "BGN")
            {
                if (currencyOutput == "USD")
                {
                    currencyAmount /= 1.79549m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }

                else if (currencyOutput == "EUR")
                {
                    currencyAmount /= 1.95583m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }

                else if (currencyOutput == "GBP")
                {
                    currencyAmount /= 2.53405m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }
            }

            else if (currencyInput == "USD")
            {
                if (currencyOutput == "EUR")
                {
                    currencyAmount *= 1.79549m / 1.95583m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }

                else if (currencyOutput == "GBP")
                {
                    currencyAmount *= 1.79549m / 2.53405m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }

                else if (currencyOutput == "BGN")
                {
                    currencyAmount *= 1.79549m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }
            }

            else if (currencyInput == "EUR")
            {
                if (currencyOutput == "USD")
                {
                    currencyAmount *= 1.95583m / 1.79549m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }

                else if (currencyOutput == "GBP")
                {
                    currencyAmount *= 1.95583m / 2.53405m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }

                else if (currencyOutput == "BGN")
                {
                    currencyAmount *= 1.95583m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }
            }

            else if (currencyInput == "GBP")
            {
                if (currencyOutput == "EUR")
                {
                    currencyAmount *= 2.53405m / 1.95583m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }

                else if (currencyOutput == "USD")
                {
                    currencyAmount *= 2.53405m / 1.79549m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }

                else if (currencyOutput == "BGN")
                {
                    currencyAmount *= 2.53405m;
                    Console.WriteLine(Math.Round(currencyAmount, 2));
                }
            }               
        }
    }
}
