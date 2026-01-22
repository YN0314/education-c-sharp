using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int [5] { 1, 2, 3, 4, 5, };
            int[] second = new int [5] { 6, 7, 8, 9, 10 };
            int[] total = new int[first.Length];

            for (int i = 0; i < total.Length; i++)
            {
                total[i] = first[i] + second[i];
                Console.WriteLine(total[i]);
            }
            Console.ReadLine();
        }
    }
}
