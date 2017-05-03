using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ.Simple
{
    class Generation
    {
        static void Main(string[] args)
        {
            Sample_DefaultIfEmpty_Lambda_Simple();
            Sample_DefaultIfEmpty_Lambda_DefaultValue();
            Sample_Empty_Lambda();
            Sample_Range_Lambda();
            Sample_Repeat_Lambda();
            Console.ReadLine();
        }
        static void Sample_DefaultIfEmpty_Lambda_Simple()
        {
            string[] emptyStr = { };
            int[] emptyInt = { };
            string[] words = { "one", "two", "three" };

            var resultStr = emptyStr.DefaultIfEmpty(); // Default is null for string

            var resultInt = emptyInt.DefaultIfEmpty(); // Default is 0 for int

            var resultWords = words.DefaultIfEmpty(); // Not empty, so words array is just copied

            Console.WriteLine("resultStr has one element with a value of null:");
            Console.WriteLine(resultStr.Count() == 1 && resultStr.First() == null);

            Console.WriteLine("resultInt has one element with a value of 0:");
            Console.WriteLine(resultInt.Count() == 1 && resultInt.First() == 0);

            Console.WriteLine("resultWords has same content as words array:");
            Console.WriteLine(resultWords.SequenceEqual(words));
        }
        static void Sample_DefaultIfEmpty_Lambda_DefaultValue()
        {
            int[] empty = { };

            var result = empty.DefaultIfEmpty(5);

            Console.WriteLine("result contains one element with a value of 5:");
            Console.WriteLine(result.Count() == 1 && result.First() == 5);
        }
        static void Sample_Empty_Lambda()
        {
            var empty = Enumerable.Empty<string>();
            // To make sequence into an array use empty.ToArray()

            Console.WriteLine("Sequence is empty:");
            Console.WriteLine(empty.Count() == 0);
        }
        static void Sample_Range_Lambda()
        {
            var result = Enumerable.Range(0, 10);

            Console.WriteLine("Counting from 0 to 9:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        static void Sample_Repeat_Lambda()
        {
            string word = "Banana";

            var result = Enumerable.Repeat(word, 5);

            Console.WriteLine("String is repeated 5 times:");
            foreach (string str in result)
                Console.WriteLine(str);
        }

    }
}
