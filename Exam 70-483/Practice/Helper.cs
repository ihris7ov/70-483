using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Helper
    {
        public delegate void PrintGreeting();

        public PrintGreeting greeting;

        public Helper()
        {
            greeting += PrintHello;
            greeting += PrintSpace;
            greeting += PrintWorld;
        }

        public void PrintHello()
        {
            Console.Write("Hello");
        }

        public void PrintSpace()
        {
            Console.Write(" ");
        }

        public void PrintWorld()
        {
            Console.WriteLine("World!!!");
        }
    }
}
