using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_day
{
    public class ControlFlow
    {
        public void show()
        {
            int age = 20;
            Console.WriteLine("If-Else Statement");

            if (age >= 20)
            {
                Console.WriteLine("Condition is True");
            }
            else
            {
                Console.WriteLine("Condition is False");
            }

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Switch Statement");

            int day = 3;
            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday"); 
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                default:
                    Console.WriteLine("Another Day");
                    break;
            }

            Console.WriteLine("---------------------------------");

            Console.WriteLine("For Loop");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Iteration: {i}");
            }

            Console.WriteLine("---------------------------------");

            Console.WriteLine("For each");
            int[] arr = { 10, 20, 30, 40, 50 };
            foreach (int num in arr)
            {
                Console.WriteLine($"Number: {num}");
            }
        }
    }
}
