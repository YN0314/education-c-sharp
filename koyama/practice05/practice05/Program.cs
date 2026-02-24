using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();

            c.pi = 3.14;
            c.r = 4;
            c.Circmference();
            c.Area();

            Console.ReadLine();

        }
    }
}
