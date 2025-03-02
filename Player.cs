using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Player
    {
        public string name = "Nitesh";
        private int health = 60;

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int h)
        {
            health = h;
        }

        // Oops Concept :- Classes and Object

        static void Main(String[] args)
        {

            Player tommy = new Player();

            Console.WriteLine(tommy.getHealth());

            tommy.setHealth(80);

            Console.WriteLine(tommy.getHealth());

        }



    }
}
