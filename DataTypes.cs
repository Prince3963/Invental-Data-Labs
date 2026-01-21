using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_day
{
    public class DataTypes
    {
        public static void ShowDataTypes()
        {
            // Integer data type
            int intValue = 42;
            Console.WriteLine($"Integer Value: {intValue}");

            Console.WriteLine("---------------------------------");

            // Floating-point data type
            double doubleValue = 3.14159;
            Console.WriteLine($"Double Value: {doubleValue}");

            Console.WriteLine("---------------------------------");

            // Character data type
            char charValue = 'A';
            Console.WriteLine($"Character Value: {charValue}");

            Console.WriteLine("---------------------------------");

            // String data type
            string stringValue = "Hello, World!";
            Console.WriteLine($"String Value: {stringValue}");
            Console.WriteLine("Integer Value: " + stringValue); 

            Console.WriteLine("---------------------------------");

            // Boolean data type
            bool boolValue = true;
            Console.WriteLine($"Boolean Value: {boolValue}");

            Console.WriteLine("---------------------------------");
        }
    }
}
