using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ.Simple
{
    class Aggregate
    {
        static void Main(string[] args)
        {
			
			
            Sample_Aggregate_Lambda_Simple();
            Sample_Aggregate_Lambda_Seed();
            Sample_Average_Lambda();
            Sample_Count_Lambda();
            Sample_LongCount_Lambda();
            Sample_Max_Lambda();
            Sample_Min_Lambda();
            Sample_Sum_Lambda();
            Console.ReadLine();
        }

        private static void Sample_Aggregate_Lambda_Simple()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }


        private static void Sample_Aggregate_Lambda_Seed()
        {
            var numbers = new int[] { 1, 2, 3 };

            var result = numbers.Aggregate(10, (a, b) => a + b);

            Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
            Console.WriteLine(result);
        }

        private static void Sample_Average_Lambda()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }

        static void Sample_Count_Lambda()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }

        static void Sample_LongCount_Lambda()
        {
            // Create array which is 5 elements larger than Int32.MaxValue
            var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));
            
            Int64 result = largeArr.LongCount();

            Console.WriteLine("Counting largeArr elements:");
            Console.WriteLine(result);
        }

        static void Sample_Max_Lambda()
        {
            int[] numbers = { 2, 8, 5, 6, 1 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }



        static void Sample_Min_Lambda()
        {
            int[] numbers = { 6, 9, 3, 7, 5 };

            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }

        static void Sample_Sum_Lambda()
        {
            int[] numbers = { 2, 5, 10 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);
        }

    }
}
