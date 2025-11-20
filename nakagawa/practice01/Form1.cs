using System.ComponentModel;
using practice01.enums;

namespace practice01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rock_click(object sender, EventArgs e)
        {
            var yourSign = RpsSign.Rock;
            ShowResult(yourSign, GenerateOpponetSign());
        }

        private void scissors_click(object sender, EventArgs e)
        {
            var yourSign = RpsSign.Scissors;
            ShowResult(yourSign, GenerateOpponetSign());
        }

        private void paper_click(object sender, EventArgs e)
        {
            var yourSign = RpsSign.Paper;
            ShowResult(yourSign, GenerateOpponetSign());
        }

        /// <summary>
        /// 相手の手をランダムに返します。
        /// </summary>
        private RpsSign GenerateOpponetSign()
        {
            var rnd = new Random();
            return RpsSignExtentions.FromInt(rnd.Next(3));
        }

        /// <summary>
        /// じゃんけんの勝敗メッセージを表示します。
        /// </summary>
        private void ShowResult(RpsSign you, RpsSign oppnent)
        {
            var judge = Judge(you, oppnent);
            var signs = $"あなたは、{you.GetName()}です。相手は、{oppnent.GetName()}です。";
            switch (judge)
            {
                case JudgeSign.Win:
                    MessageBox.Show($"{signs}あなたの勝ち！");
                    break;
                case JudgeSign.Lose:
                    MessageBox.Show($"{signs}あなたの負け・・・。");
                    break;
                case JudgeSign.Draw:
                    MessageBox.Show($"{signs}あいこです。もう一度？");
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        /// <summary>
        /// じゃんけんの勝敗を判定します
        /// </summary>
        private JudgeSign Judge(RpsSign sign, RpsSign opponetSign)
        {
            var subtraction = sign.Value() - opponetSign.Value();
            var result = subtraction < 0 ? subtraction + 3 : subtraction;
            return result switch
            {
                0 => JudgeSign.Draw,
                1 => JudgeSign.Win,
                2 => JudgeSign.Lose,
                _ => throw new InvalidEnumArgumentException(),
            };
        }
    }
}
