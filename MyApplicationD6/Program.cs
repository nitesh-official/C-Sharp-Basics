//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyApplicationD6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            // Exception handling :-

//            //try
//            //{
//            //    int[] mynumbers = { 1, 2, 3 };
//            //    Console.WriteLine(mynumbers[11]);
//            //}
//            //catch(Exception e)
//            //{
//            //    Console.WriteLine("Something Went Wrong");
//            //}
//            //finally 
//            //{
//            //    Console.WriteLine("Service Restored");
//            //}



//        }
//    }
//}

//using System;

//class Animal
//{
//    public void AnimalSound()
//    {
//        Console.WriteLine("The animals makes a sound");
//    }
//}
//class Pig : Animal
//{
//    public void AnimalSound()
//    {
//        Console.WriteLine("The animals makes a sound");
//    }
//}
//class mydog : Animal
//{
//    public void AnimalSound()
//    {
//        Console.WriteLine("The animals makes a sound");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {

//        Animal 
//    }

//}

using System;

abstract class Animal
{
    // Abstract method (does not a body)

    public abstract void animalSound();

    // Regular Method

    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class inherit from animal
class pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The Pig Says: wee we");
    }
}
class Program
{
    static void Main(String[] args)
    {
        pig myPig = new pig();  // Create a pig object
        myPig.animalSound();  // Call Abstract Method 
        myPig.sleep();  // Call the regular method 
    }
}

