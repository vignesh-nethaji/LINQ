using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ.Simple
{
    class Conversion
    {
        static void Main(string[] args)
        {
            Sample_AsEnumerable_Lambda();
            Sample_Cast_Lambda();
            Sample_OfType_Lambda();
            Sample_ToArray_Lambda();
            Sample_ToDictionary_Lambda_Simple();
            Sample_ToDictionary_Lambda_Conditional();
            Sample_ToList_Lambda();
            Sample_ToLookup_Lambda();
            Console.ReadLine();
        }
        static void Sample_AsEnumerable_Lambda()
        {
            string[] names = { "John", "Suzy", "Dave" };

            var result = names.AsEnumerable();

            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);
        }
        static void Sample_Cast_Lambda()
        {
            List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

            var result = vegetables.Cast<string>();

            Console.WriteLine("List of vegetables casted to a simple string array:");
            foreach (string vegetable in result)
                Console.WriteLine(vegetable);
        }
        static void Sample_OfType_Lambda()
        {
            object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

            var result = objects.OfType<string>();

            Console.WriteLine("Objects being of type string have the values:");
            foreach (string str in result)
                Console.WriteLine(str);
        }
        static void Sample_ToArray_Lambda()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToArray();

            Console.WriteLine("New array contains identical values:");
            foreach (int number in result)
                Console.WriteLine(number);
        }


        #region Sample_ToDictionary_Lambda_Simple
        class English2German
        {
            public string EnglishSalute { get; set; }
            public string GermanSalute { get; set; }
        }

        static void Sample_ToDictionary_Lambda_Simple()
        {
            English2German[] english2German = 
                { 
                    new English2German { EnglishSalute = "Good morning", GermanSalute = "Guten Morgen" },
                    new English2German { EnglishSalute = "Good day", GermanSalute = "Guten Tag" },
                    new English2German { EnglishSalute = "Good evening", GermanSalute = "Guten Abend" },
                };

            var result = english2German.ToDictionary(k => k.EnglishSalute, v => v.GermanSalute);

            Console.WriteLine("Values inserted into dictionary:");
            foreach (KeyValuePair<string, string> dic in result)
                Console.WriteLine(String.Format("English salute {0} is {1} in German", dic.Key, dic.Value));
        }

        #endregion

        static void Sample_ToDictionary_Lambda_Conditional()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");

            Console.WriteLine("Numbers labeled Odd and Even in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
        }
        static void Sample_ToList_Lambda()
        {
            string[] names = { "Brenda", "Carl", "Finn" };

            List<string> result = names.ToList();

            Console.WriteLine(String.Format("names is of type: {0}", names.GetType().Name));
            Console.WriteLine(String.Format("result is of type: {0}", result.GetType().Name));
        }
        static void Sample_ToLookup_Lambda()
        {
            string[] words = { "one", "two", "three", "four", "five", "six", "seven" };

            var result = words.ToLookup(w => w.Length);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("Elements with a length of {0}:", i));
                foreach (string word in result[i])
                    Console.WriteLine(word);
            }
        }

    }
}
