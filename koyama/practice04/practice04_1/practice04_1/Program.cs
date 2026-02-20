using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice04_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int japanese_max = 0;
            int english_max = 0;
            int math_max = 0;
            int japanese_total = 0;
            int english_total = 0;
            int math_total = 0;
            

            string[,] score = new string[5, 4]
            {
                {"Aさん","55","63","72" },
                {"Bさん","53","99","33" },
                {"Cさん","70","4","26" },
                {"Dさん","49","88","66"},
                {"Eさん","81","78","45" }
            };

            for (int i = 0; i < score.GetLength(0); i++)
            {
                for (int j = 1; j < score.GetLength(1); j++)
                {
                    int point = int.Parse(score[i, j]);

                    // 国語
                    if (j == 1)
                    {
                        japanese_total += point;
                        if (point > japanese_max)
                        {
                            japanese_max = point;
                        }
                    }

                    // 数学
                    if (j == 2)
                    {
                        english_total += point;
                        if (point > english_max)
                        {
                            english_max = point;
                        }
                    }

                    // 数学
                    if (j == 3)
                    {
                        math_total += point;
                        if (point > math_max)
                        {
                            math_max = point;
                        }
                    }
                }
            }
            int japanese_average = japanese_total / score.GetLength(0);
            int english_average = english_total / score.GetLength(0);
            int math_average = math_total / score.GetLength(0);

            Console.WriteLine($"国語の最高得点は{japanese_max}です。");
            Console.WriteLine($"英語の最高得点は{english_max}です。");
            Console.WriteLine($"数学の最高得点は{math_max}です。");
            Console.WriteLine($"国語の平均点は{japanese_average}です。");
            Console.WriteLine($"英語の平均点は{english_average}です。");
            Console.WriteLine($"数学の平均点は{math_average}です。");
            Console.ReadLine();
        }
    }
}
