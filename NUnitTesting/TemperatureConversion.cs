using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class TemperatureConversion
    {
        public void CtoF()
        {
            float farenheit, celcius;
            Console.Write("Enter The Temprature In Celcius :");
            celcius= float.Parse(Console.ReadLine());
            farenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("Temprature --> Celsius To Fahrenheit :" + farenheit + "°F");
        }
        public void FtoC()
        {
            float cel, faren;
            Console.Write("\nEnter The Temprature In Fahrenheit :");
            faren = float.Parse(Console.ReadLine());
            cel = (faren - 32) * 5 / 9;
            Console.WriteLine("Temprature --> Fahrenheit To Celsius :" + cel + "°C");
        }
    }
}
