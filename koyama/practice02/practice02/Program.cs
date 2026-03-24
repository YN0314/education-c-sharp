using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 40; i++)
            { 
                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    Console.WriteLine($"{i}アホ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
