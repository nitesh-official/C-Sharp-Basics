//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyApplicationD4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            // 2D Array :- 

//            // Today First Program

//            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
//            //Console.WriteLine(numbers[0, 2]);

//            // Today second Program

//            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
//            //numbers[0, 0] = 5; // Change Value to 5 
//            //Console.WriteLine(numbers[0, 0]);

//            // Today third Program

//            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//            //foreach(int i in numbers)
//            //{
//            //    Console.Write(i);
//            //}

//            // Today fourth Program

//            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
//            //for (int i = 0; i < numbers.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < numbers.GetLength(1); j++)
//            //    {
//            //        Console.Write(numbers[i, j]);
//            //    }
//            //}


//        }
//    }
//}


// C# Methods :- Today fifth Program 


//using System;

//namespace MyApplicationD4
//{

//    internal class Program
//    {

//        static void firstmethod()
//        {
//            Console.WriteLine("This is my First Method");
//        }


//        static void Main(string[] args)
//        {
//            firstmethod();
//            firstmethod();
//            firstmethod();

//        }

//    }

//}


// C# Methods parameters Passing :- Today sixth Program



using System;

namespace MyApplicationD4
{

    internal class Program
    {

        static void Mymethod(string fname, int age)
        {
            Console.WriteLine(string.Concat("Your name is ",fname," And age is ",age));
        }


        static void Main(string[] args)
        {
            Mymethod("Nitesh",20);
            Mymethod("Vivek",20);
            Mymethod("Ruhul",20);

        }

    }

}