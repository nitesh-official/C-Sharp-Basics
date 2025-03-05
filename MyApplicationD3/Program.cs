using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array First Program

            //string[] cars = { "Volvo","BMW", "Ford", "Mazda" };
            //Console.WriteLine(cars[0]);

            // Array Second Program

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //cars[0] = "Opel";
            //Console.WriteLine(cars[0]);

            // Array Third Program

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Console.WriteLine(cars.Length);

            // Array Fourth Program

            //string[] cars;
            //cars = new string[] { "Volvo", "BMW", "Ford" };

            //Console.WriteLine(cars[3]);  // Unhandled exception 

            // Array Fifth Program

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //// Sorting a string Sixth Program

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Array.Sort(cars);
            //foreach(string i in cars)
            //{
            //    Console.WriteLine(i);
            //}

            // Sorting a string Seventh Program

            int[] Mynumbers = { 5, 1, 8, 9 };
            Array.Sort(Mynumbers);
            foreach (int i in Mynumbers)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadLine()

            // New Program using linq Eighth Program

            //int[] Mynumbers = { 5, 1, 8, 9 };

            //Console.WriteLine(Mynumbers.Max());
            //Console.WriteLine(Mynumbers.Min());
            //Console.WriteLine(Mynumbers.Sum());



        }
    }
}
