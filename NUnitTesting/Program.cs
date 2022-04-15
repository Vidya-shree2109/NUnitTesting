using System;

namespace NUnitTesting
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("----------Welcome To N Unit Testing Programs----------");
            bool finish = true;
            Console.WriteLine("\n1.Displaying Day Of Week\n2.Temperature Conversion\n3.End The Program");
            while (finish)
            {
                Console.Write("\nEnter an option to execute :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DayOfWeek day = new DayOfWeek();
                        day.PrintDay();
                        break;
                    case 2:
                        TemperatureConversion temp = new TemperatureConversion();
                        temp.CtoF();
                        temp.FtoC();
                        break;
                    case 3:
                        finish = false;
                        break;

                    default:
                        Console.WriteLine("Enter a valid option !");
                        break;
                }
            }

        }
    }
}