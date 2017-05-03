using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ.Simple
{
    class Projection
    {
        static void Main(string[] args)
        {
            Sample_Select_Lambda_Simple();
            Sample_Select_Lambda_Anonymous();
            Sample_Select_Lambda_Indexed();
            Sample_SelectMany_Lambda();
            Console.ReadLine();
        }
        static void Sample_Select_Lambda_Simple()
        {
            decimal[] numbers = { 3.4M, 8.33M, 5.225M };

            var result = numbers.Select(n => Math.Floor(n));

            Console.WriteLine("Numbers rounded down:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        static void Sample_Select_Lambda_Anonymous()
        {
            double[] angles = { 30D, 60D, 90D }; // Angles in radians

            var result = angles.Select(a => new { Angle = a, Cos = Math.Cos(a), Sin = Math.Sin(a) });

            Console.WriteLine("Calculated values:");
            foreach (var res in result)
                Console.WriteLine(String.Format("Angle {0}: Cos = {1}, Sin = {2}", res.Angle, res.Cos, res.Sin));
        }
        static void Sample_Select_Lambda_Indexed()
        {
            string[] words = { "one", "two", "three" };

            var result = words.Select((w, i) => new
            {
                Index = i,
                Value = w
            });

            Console.WriteLine("Words with index and value:");
            foreach (var word in result)
                Console.WriteLine(String.Format("Index {0} is {1}", word.Index, word.Value));
        }
        static void Sample_SelectMany_Lambda()
        {
            string[] fruits = { "Grape", "Orange", "Apple" };
            int[] amounts = { 1, 2, 3 };

            var result = fruits.SelectMany(f => amounts, (f, a) => new
            {
                Fruit = f,
                Amount = a
            });

            Console.WriteLine("Selecting all values from each array, and mixing them:");
            foreach (var o in result)
                Console.WriteLine(o.Fruit + ", " + o.Amount);
        }

    }
}
