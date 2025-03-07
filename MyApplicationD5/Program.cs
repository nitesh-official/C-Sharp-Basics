using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationD5
{
    //internal class Program
    //{

    //    static int PlusMethodint(int x,int y)
    //    {
    //        return x + y;
    //    }
    //    static double PlusMethoddouble(double x, double y)
    //    {
    //        return x + y;
    //    }
    //    static void Main(string[] args)
    //    {

    //        int myNum1 = PlusMethodint(8, 5);
    //        double myNum2 = PlusMethoddouble(4.3, 6.26);

    //        Console.WriteLine("Int:" + myNum1);
    //        Console.WriteLine("Double:" + myNum2);

    //    }
    //}

    //class car
    //{
    //    string color = "RED";

    //    static void Main(string[] args)
    //    {
    //        car myobj1 = new car();


    //        Console.WriteLine(myobj1.color);

    //    }
    //}

    class car
    {
        string color = "RED";

        static void Main(string[] args)
        {
            car myobj1 = new car();
            car myobj2 = new car();

            Console.WriteLine(myobj1.color);
            Console.WriteLine(myobj2.color);


        }
    }
}
