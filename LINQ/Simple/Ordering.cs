using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ.Simple
{
    class Ordering
    {
        static void Main(string[] args)
        {
            Sample_OrderBy_Lambda_Numbers();
            Sample_OrderBy_Lambda_Dates();
            Sample_OrderBy_Lambda_Objects();
            Sample_OrderByDescending_Lambda();
            Sample_Reverse_Lambda();
            Sample_ThenBy_Lambda();
            Sample_ThenByDescending_Lambda();
            Console.ReadLine();
        }
        static void Sample_OrderBy_Lambda_Numbers()
        {
            int[] numbers = { 7, 9, 5 };

            var result = numbers.OrderBy(n => n);

            Console.WriteLine("Ordered list of numbers:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        static void Sample_OrderBy_Lambda_Dates()
        {
            var dates = new DateTime[] {
                new DateTime(2015, 2, 15),
                new DateTime(2015, 3, 25),
                new DateTime(2015, 1, 5)
            };

            var result = dates.OrderBy(d => d);

            Console.WriteLine("Ordered list of dates:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }
        #region Sample_OrderBy_Lambda_Objects
        class Car
        {
            public string Name { get; set; }
            public int HorsePower { get; set; }
        }

        static void Sample_OrderBy_Lambda_Objects()
        {
            Car[] cars = {
                        new Car { Name = "Super Car", HorsePower = 215 },
                        new Car { Name = "Economy Car", HorsePower = 75 },
                        new Car { Name = "Family Car", HorsePower = 145 },
                    };

            var result = cars.OrderBy(c => c.HorsePower);

            Console.WriteLine("Ordered list of cars by horsepower:");
            foreach (Car car in result)
                Console.WriteLine(String.Format("{0}: {1} horses", car.Name, car.HorsePower));
        }

        #endregion

        static void Sample_OrderByDescending_Lambda()
        {
            string[] names = { "Ned", "Ben", "Susan" };

            var result = names.OrderByDescending(n => n);

            Console.WriteLine("Descending ordered list of names:");
            foreach (string name in result)
                Console.WriteLine(name);
        }
        static void Sample_Reverse_Lambda()
        {
            char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

            var result = characters.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach (char character in result)
                Console.WriteLine(character);
        }
        static void Sample_ThenBy_Lambda()
        {
            string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London", 
                          "Athens", "Beijing", "Seoul" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);
        }
        static void Sample_ThenByDescending_Lambda()
        {
            var dates = new DateTime[] {
                new DateTime(2015, 3, 1),
                new DateTime(2014, 7, 1),
                new DateTime(2013, 5, 1),
                new DateTime(2015, 1, 1),
                new DateTime(2015, 7, 1)
            };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }

    }
}
