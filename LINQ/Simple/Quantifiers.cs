using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ.Simple
{
    class Quantifiers
    {
        static void Main(string[] args)
        {
            Sample_All_Lambda();
            Sample_Any_Lambda();
            Sample_Contains_Lambda();
            Console.ReadLine();
        }

        static void Sample_All_Lambda()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        static void Sample_Any_Lambda()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        static void Sample_Contains_Lambda()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }

    }
}
