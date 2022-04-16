using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class MonthlyPayment
    {
        public void Payment()
        {
            double principle, rate;
            int year;
            Console.Write("Enter the principal amount :");
            principle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the year :");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the rate :");
            rate = Convert.ToDouble(Console.ReadLine());

            int n = 12 * year;
            double r = (rate) / (12 * 100);

            double payment = (principle * r) / 1 - Math.Pow((1 + r), -n);
            Console.WriteLine("Monthly Payment : " + payment);
        }
    }
}
