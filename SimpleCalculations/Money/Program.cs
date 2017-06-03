using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinNum = int.Parse(Console.ReadLine());
            float chineseYuans = float.Parse(Console.ReadLine());
            float changeComission = float.Parse(Console.ReadLine());
            //TODO with decimal:
            double bitcoinsValue = bitcoinNum * (1168 / 1.95);
            double cnyValue = chineseYuans * (0.15 * (1.76 / 1.95));
            double currencyReform = bitcoinsValue + cnyValue;
            double reformComission = currencyReform * (changeComission / 100);
            double euros = currencyReform - reformComission;
            Console.WriteLine("{0:f2}", euros);
            //double bitcoinsBGN = bitcoinNum * 1168;
            //double cnyUSD = chineseYuans * 0.15;
            //double cnyBGN = cnyUSD * 1.76;
            //double currencyEUR = (bitcoinsBGN + cnyBGN) / 1.95;
            //double reformComission = currencyEUR * (changeComission / 100);
            //double euros = currencyEUR - reformComission;
            //Console.WriteLine("{0:f2}", euros);
        }
    }
}
