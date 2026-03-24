using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Record record = new Record("A", 51, 71, 93);
            record.Display();
            Console.ReadLine();
        }
    }
}
