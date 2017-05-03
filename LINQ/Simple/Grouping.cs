using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ.Simple
{
    class Grouping
    {
        static void Main(string[] args)
        {
            Sample_GroupBy_Lambda();
            Console.ReadLine();
        }
        static void Sample_GroupBy_Lambda()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35 };

            var result = numbers.GroupBy(n => (n % 10 == 0));

            Console.WriteLine("GroupBy has created two groups:");
            foreach (IGrouping<bool, int> group in result)
            {
                if (group.Key == true)
                    Console.WriteLine("Divisible by 10");
                else
                    Console.WriteLine("Not Divisible by 10");

                foreach (int number in group)
                    Console.WriteLine(number);
            }
        }

    }
}
