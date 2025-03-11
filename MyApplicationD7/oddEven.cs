using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicaationD8
{
    internal class oddEven
    {
        public static void checkOddEven()
        {

            Console.WriteLine("Please Enter Any Number");
            int num = Convert.ToInt32(Console.ReadLine());

           string check = num % 2 == 1 ? "Even" : "Odd";

            Console.WriteLine(check);
        }
        

    }
}
