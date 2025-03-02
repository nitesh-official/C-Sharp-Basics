//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

// namespace HelloWorld
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
            /*
                // My First Hello World program in c#

                Console.WriteLine("Hello World !!"); // This command is use to display the output 
                Console.WriteLine("Hello Nitesh Maurya !!");
                Console.WriteLine("I Love c#");
                Console.ReadLine(); // We use this command for getting input but here we use this because hold the output screen 

             */


            // Comments in C# :- 

            // 1.This is a single line comment 

            /*
             2.This is a multi-line comment
              spanning across multiple lines
            */


            /* 

               // Now we learn how to take input in c#

               Console.WriteLine("What is your name ?"); // This command is use to display the output
               string name = Console.ReadLine(); // This command is use for taking a string type value
               Console.WriteLine("Welcome " + name);
               Console.ReadLine();

            */


            /*

            // Now we learn to take integer, float, char type input in c#


            Console.Write("Enter Any number type Value (0-9) to get output: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); // This command is use to take an integer type value
            Console.WriteLine("Yes you entered correct input and Your input number is: " + num1);


            Console.Write("Enter Any Decimal/Float type Value to get output: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine()); // This command is use to take an float/decimal type value "but By default this type of value is categories in to double"
            Console.WriteLine("Yes you entered correct input and Your input number is: " + num2);
            

            Console.Write("Enter Any Character type Value to get output: ");
            char character = Convert.ToChar(Console.ReadLine()); // This command is use to take an character type value 
            Console.WriteLine("Yes you entered correct input and Your input character is: " +character);
            Console.ReadLine();
        
            */


            //Data types in C# :- 

            /*

               Integer ->  int num = 2; --> It Takes 4 Bytes

               Float/decimal ->  decimal num = 2.65; --> It Takes 4 Bytes

               character ->  int num = 'A'; -->It Takes 4 Bytes

               Boolean ->  bol brave = True; -->It Takes 1 Bit

               String ->  string inp = "Nitesh"; -->It Takes 2 Bytes per character


              //Some Examples

              int x = 34;
              float y = 23.3f; // By Default float is double
              double z = 23.555;
              bool lionisbrave = true;
              char Hash = '#';
              string name = "Nitesh Maurya";

              Console.WriteLine(x);
              Console.WriteLine(y);
              Console.WriteLine(z);
              Console.WriteLine(lionisbrave);
              Console.WriteLine(Hash);
              Console.WriteLine(name);
              Console.ReadLine(); // Use for hold the screen 

            */

            /*

               // Here We Learn About Type-Casting 

               // There are two type of type casting 

               // 1.Implicit casting 

               // --> char to int to long to float to double

               // 2.Explicit casting 

               // Some Examples

               int j = 6;
               float k = 7.66f;
               float varr = Convert.ToInt32(k);
               float l = 65.4f;
               Convert.ToDouble(l);
               string n = "String";

               Console.WriteLine(j);
               Console.WriteLine(k);
               Console.WriteLine(varr);
               Console.WriteLine(l);
               Console.WriteLine(n);
               Console.WriteLine(); // For hold the output screen

            */


            /*

            // Now we learn addition,subtraction,multiplication,division

            int num1 = 50;
            int num2 = 50;

            Console.WriteLine("Addition of two number (num1=50 + num2=50) is: " +(num1 + num2));

            Console.WriteLine("Subtraction of two number (num1=50 - num2=50) is: " + (num1 - num2));

            Console.WriteLine("Multiplication of two number (num1=50 * num2=50) is: " + (num1 * num2));

            Console.WriteLine("Division of two number (num1=50 / num2=50) is: " + (num1 / num2));

            Console.ReadLine();

           */

            /* 
               // Operators in c# :-

                 1.Arithmetic Operator 
                 2.Assignment Operator
                 3.Comparison Operator
                 4.Logical Operator 

             */

            /*
               // Now we learn about to take value from user and using arithmetic operator (Add,subtract,multiply,divide)

                Console.Write("Enter your first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your Second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Addition of two number (num1 + num2) is: " + (num1 + num2));

                Console.WriteLine("Subtraction of two number (num1 - num2) is: " + (num1 - num2));

                Console.WriteLine("Multiplication of two number (num1 * num2) is: " + (num1 * num2));

                Console.WriteLine("Division of two number (num1 / num2) is: " + (num1 / num2));

                Console.ReadLine(); // This line is use for hold the output screen

            */


            /*

            // Now we learn about Assignment operator ( = )

            int a = 20;
            int b = a;

            b += 6;
            b -= 6;
            b *= 6;
            b /= 6;

            Console.WriteLine(b);
            Console.ReadLine();

            */

            /* 

               // Comparison or Relational Operators

               int a = 33;
               int b = 30;
               int c = 5;
               int d = 5; 

               Console.WriteLine(a > b);  // This is true because 33 is greater than 30
               Console.WriteLine(a < b);  // This is false because 33 is greater than 30 not lesser
               Console.WriteLine(a >= b);  // This is True because 33 is greater than 30 (but not equal to 30)
               Console.WriteLine(a <= b);  // This is false because 33 is not equal to or lesser than 30, it is grater than 30
               Console.WriteLine(c != d);  // This is false because here c is equal to in this case 
               Console.WriteLine(c == d);  // This is true because 5 is equal to 5
               Console.ReadLine();

            */

            /*

               // Logical Operator

               Console.WriteLine(true && true);  // Return True because it is mandatory to satisfied both condition true
               Console.WriteLine(true && false); // Return false because it is mandatory to satisfied both condition true
               Console.WriteLine(false && true); // Return false because it is mandatory to satisfied both condition true
               Console.WriteLine(false && false); // Return false because it is mandatory to satisfied both condition true

               Console.WriteLine(true || true);  // Return True because if any one condition is true then it return true nor false
               Console.WriteLine(true || false); // Return True because if any one condition is true then it return true nor false
               Console.WriteLine(false || true); // Return True because if any one condition is true then it return true nor false
               Console.WriteLine(false || false); // Return false because if any one condition is true then it return true nor false

               Console.WriteLine(!(true && true)); // This is true but it returns false because the (not operator) return opposite value
               Console.WriteLine(!(false || false)); // This is false but it returns true because the (not operator) return opposite value


         */

            /*

                  // Using math class library

                  Console.WriteLine(Math.Max(10, 20));
                  Console.WriteLine(Math.Min(10, 20));
                  Console.WriteLine(Math.Abs(-20));
                  Console.WriteLine(Math.Abs(20));
                  Console.WriteLine(Math.Sqrt(36));
                  Console.WriteLine(Math.Log10(10));
                  Console.WriteLine(Math.Cos(0));
                  Console.WriteLine(Math.Round(10.35266));
                  Console.WriteLine(Math.Round(10.65334));


            */

            /*

                  // Working on String :-

                  string name = "Nitesh"; // We use double inverted comma ("") to declare a string 
                  string hello = "Hello";

                  Console.WriteLine(name);
                  Console.WriteLine(hello);

                  Console.WriteLine(name.Length); // Length of string
                  Console.WriteLine(name.ToUpper());
                  Console.WriteLine(name.ToLower());

                  Console.WriteLine("My name is "+ name + " and number of character in my name is "+name.Length);

                  Console.WriteLine(name[0]);
                  Console.WriteLine(name[1]);
                  Console.WriteLine(name[2]);
                  Console.WriteLine(name[3]);
                  Console.WriteLine(name[4]);
                  Console.WriteLine(name[5]);

                  // Console.WriteLine(name[6]); // Unhandled Exception

                  // Index of string character

                  Console.WriteLine(hello.IndexOf("H"));
                  Console.WriteLine(hello.IndexOf("o"));
                  Console.WriteLine(hello.IndexOf("Hello"));

                  Console.WriteLine(hello.Substring(1));

                  // String Concat :- 

                  Console.WriteLine(string.Concat(hello , name , " Welcome to the Journey of coding world")); // To concat two strings 

                  // String interpolation :-

                  Console.WriteLine($"Hey {hello}. My name is {name}");

                  // Escape sequence character 

                  Console.WriteLine(" Hello My name is \"Nitesh\" "); // We use  \" to get a inverted comma (") in my sentences
                  Console.WriteLine(" Hello My name is \n Nitesh"); // We use  \n for got to next line
                  Console.WriteLine(" Hello My name is \t Nitesh"); // We use  \t for getting a tab                                                  


            */

            // Conditional Operator :- 

            /*

                  // 1. Condition first if and else or (else if)


                  Console.Write("Enter Your age :- ");
                  int age = Convert.ToInt32(Console.ReadLine());

                  if (age < 10)
                  {
                      Console.WriteLine("You are a child");
                  }
                  else if (age < 18 && age >= 10)
                  {
                      Console.WriteLine("You are not an adult");
                  }
                  else if (age >= 18 && age <=100)
                  {
                      Console.WriteLine("You are an adult");
                  }
                  else
                  {
                      Console.WriteLine("Please Enter Your Correct age");
                  }

            */

            /*

             // Switch Case with default :-

               Console.Write("Enter Any Number between 1 to 5 :- ");
               int num = Convert.ToInt32(Console.ReadLine());

               switch (num)
               {
                   case 1:
                       Console.WriteLine("Namaste, You Choose 1");
                       break;

                   case 2:
                       Console.WriteLine("Ram Ram, You Choose 2");
                       break;

                   case 3:
                       Console.WriteLine("Radhe Radhe, You Choose 3");
                       break;

                   case 4:
                       Console.WriteLine("Hello, You Choose 4");
                       break;

                   case 5:
                       Console.WriteLine("Hey Dear, you Choose 5");
                       break;

                   default:
                       Console.WriteLine("Please Enter Correct Number");
                       break;
               }

         */

                                      // Loop :- 

         /*

               // 1.While loop => Firstly Condition is Checked and then execute the program

               //int i = 0;

               //while ( i <= 10)
               //{
               //    Console.WriteLine(i);
               //    i++;
               //}

               // 2.do While loop => Firstly execute the program once and then check the Condition

               //int i = 5;

               //do
               //{
               //    Console.WriteLine(i);
               //    i++;
               //}
               //while (i > 10);

               // 3.For Loop :- Initialization, Condition check, increment or decrement 

               //for ( int i = 0; i <= 10; i++)
               //{
               //    Console.WriteLine(i);
               //}

          */

                     // Break and Continue Statement :- 

          /*

               // Break => Leave this loop forever

               //for (int i = 0; i <= 10; i++)
               //{
               //    Console.WriteLine(i);
               //    break;
               //}

               // Continue => Leave this particular iteration for the loop 

               for (int i = 0; i <= 10; i++)
               {
                   if(i == 0)  // Escape once for 0 and then continue the upcoming iteration 
                   {
                       continue;
                   }              
                   Console.WriteLine(i);        
               }

          */

//        }
//    }
//}


            // Function (Method) :- 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    internal class Program
    {
        /*

        // Created a function here and then call in main function 

        static void greeting()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Namaste");
        }

        static void Main(String[] args)
        {
            // Calling the gretting function here 

            greeting();

        }

        */

        // Function with arguments :-

        /*

        // Created a function here with arguments and then call in main function and passing these arguments

        static void greeting(string name)
        {
            Console.WriteLine("Hello " +name);          
        }

        static void age(int age)
        {
            Console.WriteLine("Your age is: " + age);
        }

        static void Main(String[] args)
        {
            // Calling the gretting function here and passing the arguments

            greeting("Nitesh");
            age(20);

        }

        */

        // Function with return some value 

        /*

          //static int Average(int a, int b, int c)
          //{
          //    return (a + b + c) / 3;
          //}

          //static void Main(String[] args)
          //{

          //    Console.WriteLine(Average(3,3,3)); // Here we call the function and return with passing arguments

          //}

          //static float Average(int a, int b, int c)
          //{
          //    float sum = a + b + c;
          //    return sum / 3;
          //}

          //static void Main(String[] args)
          //{
          //    float temp = Average(3, 3, 3); // Here we call the function with passing arguments and assign the value in temp 
          //    Console.WriteLine("Average is : " +temp); 

          //}

          */


        // Function Overloading :- It Allows a function to perform different task depending on argument passed,it improve code readability and maintainability


            static float Average(int a, int b)
            {
                float sum = a + b ;
                return sum / 2;
            }

            static float Average(int a, int b, int c)
            {
                float sum = a + b + c;
                return sum / 3;
            }


            static void Main(String[] args)
            {

                float avg1 = Average(2, 2);
                float avg2 = Average(2, 2, 3);
                Console.WriteLine("Average First is : " +avg1);
                Console.WriteLine("Average Second is : " +avg2);

            }
     
              
    }
}