using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice05
{
    class Circle
    {
        // フィールド
        public double pi;
        public int r;

        // 円周を求めて出力するメソッド
        public void Circmference()
        {
            Console.WriteLine($"円の円周は{2 * pi * r}です。");
        }

        // 面積を求めて出力するメソッド
        public void Area()
        {
            Console.WriteLine($"円の面積は{r * r * pi}です。");
        }
    }
}
