using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, Kindly enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " + name + ". Have you forgotten what day it's again?");
            Console.Write("Well, I'm here to help you out. What day of the week is it (0-6)? ");
            int dayNum = Convert.ToInt32(Console.ReadLine());

            // Call the GetDay method to retrieve the day name
            string dayName = GetDay(dayNum);

            Console.WriteLine("Hello " + name + ", today is " + dayName);

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday"; // Corrected spelling of Thursday
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid";
                    break;
            }

            return dayName;
        }
    }
}
