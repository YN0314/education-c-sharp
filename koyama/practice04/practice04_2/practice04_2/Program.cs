using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] box = new int[20, 20];
            for (int i = 0; i < box.GetLength(0); i++)
            {
                for (int j = 0; j < box.GetLength(1); j++)
                {
                    int addition = i + j;
                    int subtraction = i - j;

                    if (addition % 6 == 0 || subtraction % 6 == 0)
                    {
                        box[i, j] = 1;
                    }
                    else 
                    {
                        box[i, j] = 0;
                    }
                }
            }

            for (int i = 0;i < box.GetLength(0); i++)
            {
                for (int j = 0;j < box.GetLength(1); j++)
                {
                    if (box[i, j] == 0)
                    {
                        Console.Write("■");
                    }

                    else if (box[i, j] == 1)
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
