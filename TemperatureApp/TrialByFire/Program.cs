using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialByFire
{
    public class Program
    {
        

        public static void Main()
        {
            TemperatureConverter tempc = new TemperatureConverter();
            Console.WriteLine("If you wish to convert Fahrenheit to Celsius, please enter 1. If you would like to convert Celsius to Fahrenheit, please enter 2.");
            string x = Console.ReadLine();
            double f, c;
            switch (x)
            {
                case "1":
                        Console.WriteLine("Please enter the value for Fahrenheit:");
                        string a = Console.ReadLine();
                        // double f = 14.0;
                        //bool wasSuccessful = double.TryParse(a, out f);
                        if (double.TryParse(a, out f))
                        {
                            c = tempc.ToCelcius(f);
                            Console.WriteLine("You entered " + f + " for Fahrenheit, so it will be " + c + " Celcius.");
                        }
                        else
                        {
                            Console.WriteLine("You did not enter a number.");
                        }
                        break;
                case "2":
                        Console.WriteLine("Please enter the value for Celcius:");
                        string b = Console.ReadLine();
                        //bool wasSuccessful2 = double.TryParse(b, out c);
                        if (double.TryParse(b, out c))
                        {
                            f = tempc.ToFahrenheit(c);
                            Console.WriteLine("You entered " + c + " for Celcius, so it will be " + f + " in Fahreinheit.");
                        }
                        else
                        {
                            Console.WriteLine("You did not enter a number.");
                        }
                        break;
                default:
                    Console.WriteLine("Does not compute. Please enter a valid option.");
                    break;
            }
            string temp = Console.ReadLine();
        }
    }
}
