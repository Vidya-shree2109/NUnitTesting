using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class DayOfWeek
    {
        public void PrintDay()
        {
            int day, month, year, y0, x, m0, d0;
            Console.Write("Enter the Month number --> ( 1 to 12 ) :");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Day number   --> ( 1 to 31 ) :");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Year         --> ( In 4 Digits ) :");
            year = Convert.ToInt32(Console.ReadLine());
            y0 = year - (14 - month) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = month + 12 * ((14 - month) / 12) - 2;
            d0 = (day + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("\n{0}/{1}/{2} is SUNDAY", day, month, year);
                    break;
                case 1:
                    Console.WriteLine("\n{0}/{1}/{2} is MONDAY", day, month, year);
                    break;
                case 2:
                    Console.WriteLine("\n{0}/{1}/{2} is TUESDAY", day, month, year);
                    break;
                case 3:
                    Console.WriteLine("\n{0}/{ 1}/{ 2} is WEDNESDAY", day, month, year);
                    break;
                case 4:
                    Console.WriteLine("\n{0}/{1}/{2} is THURSDAY", day, month, year);
                    break;
                case 5:
                    Console.WriteLine("\n{0}/{1}/{2} is FRIDAY", day, month, year);
                    break;
                case 6:
                    Console.WriteLine("\n{0}/{1}/{2} is SATURDAY", day, month, year);
                    break;
                default:
                    Console.WriteLine("Day Not Found.. !");
                    break;
            }
        }
    }
}
