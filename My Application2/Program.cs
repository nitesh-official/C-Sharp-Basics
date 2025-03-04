using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Application2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Switch Case Today First Program (20-02-2025)

            //int day;
            //Console.WriteLine("Please enter your choice ");
            //day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;

            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;

            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;

            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;

            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;


            // Switch Case with default Today Second Program (20-02-2025)

            //int day;
            //        Console.Write("Please enter your choice :- ");
            //        day = Convert.ToInt32(Console.ReadLine());

            //        switch (day)
            //        {
            //            case 1:
            //                Console.WriteLine("Monday");
            //                break;

            //            case 2:
            //                Console.WriteLine("Tuesday");
            //                break;

            //            case 3:
            //                Console.WriteLine("Wednesday");
            //                break;

            //            case 4:
            //                Console.WriteLine("Thursday");
            //                break;

            //            case 5:
            //                Console.WriteLine("Friday");
            //                break;

            //            case 6:
            //                Console.WriteLine("Saturday");
            //                break;

            //            case 7:
            //                Console.WriteLine("Sunday");
            //                break;

            //            default:
            //                Console.WriteLine("Invalid choice, Please Enter between : 1 - 7 ");
            //                break;
            //        }

            // While Loop Today Third Program (20-02-2025) :- 

            //int i = 3;
            //Console.Write("Enter Your Choice:- ");
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // While Loop With user input Today Fourth Program (20-02-2025)

            //int i;
            //Console.Write("Enter Your Choice:- ");
            //i = Convert.ToInt32(Console.ReadLine());
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Do While Loop With user input Today Fifth Program (20-02-2025) :- 

            //int i;
            //Console.Write("Enter Your Choice:- ");
            //i = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 5);


            // For Loop Today Sixth Program (20-02-2025)

            //for (int i = 0; i<5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 10; i= i+2)
            //{
            //    Console.WriteLine(i);
            //}


            // Nested For Loop Today Seventh Program (20-02-2025)

            //for (int i=1; i<=2; ++i)
            //{
            //    Console.WriteLine("Outer:" + i);  // Execute 2 Times 

            //    // inner Loop: 

            //    for (int j =1; j<=3; j++)
            //    {
            //        Console.WriteLine("inner: " + j); // Execute six times 
            //    }
            //} 

            //For Each Loop Today Eight Program (20-02-2025)

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);  
            //}


            // Break Statement Today Ninth Program (20-02-2025)

            //for (int i=0; i<=10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}


            // Continue Statement Today Tenth Program (20-02-2025)

            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }


            /* Today All Program Completed */


        }
    }
}
