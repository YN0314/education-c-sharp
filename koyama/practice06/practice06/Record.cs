using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice06
{
    internal class Record
    {
        public string name;
        public int englishscore;
        public int japanesescore;
        public int mathscore;

        public Record(string name, int englishscore, int japanesescore, int mathscore)
        {
            this.name = name;
            this.englishscore = englishscore;
            this.japanesescore = japanesescore;
            this.mathscore = mathscore;
        }

        public int Sum()
        {
            return englishscore + japanesescore + mathscore;
        }

        public int Avg()
        {
            return Sum() / 3;
        }

        public void Display()
        {
            Console.WriteLine($"名前：{name}");
            Console.WriteLine($"英語：{englishscore}");
            Console.WriteLine($"国語：{japanesescore}");
            Console.WriteLine($"数学：{mathscore}");
            Console.WriteLine($"合計点:{Sum()}");
            Console.WriteLine($"平均点：{Avg()}");
        }
    }
}
