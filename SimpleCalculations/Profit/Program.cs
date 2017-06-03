using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            float wage = float.Parse(Console.ReadLine());
            float dollarRate = float.Parse(Console.ReadLine());

            double monthlySalary = workDays * wage;
            double bonus = monthlySalary * 2.5;
            double annualSalary = monthlySalary * 12 + bonus;            
            double incomeTaxes = annualSalary * 0.25;
            double annualIncome = (annualSalary - incomeTaxes) * dollarRate;
            double averageDayEarnings = annualIncome / 365;
            Console.WriteLine("{0:f2}", averageDayEarnings);


        }
    }
}
