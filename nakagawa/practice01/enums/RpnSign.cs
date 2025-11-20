using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice01.enums
{
    /// <summary>
    /// じゃんけんの手
    /// </summary>
    public enum RpsSign
    {
        Rock = 0, // グー
        Paper = 1, // パー
        Scissors = 2, // チョキ
    }
    /// <summary>
    /// Enum拡張クラス
    /// </summary>
    public static partial class RpsSignExtentions
    {
        /// <summary>
        /// RpsSignの値を取得します。
        /// </summary>
        public static int Value(this RpsSign sign)
        {
            return (int)sign;
        }

        /// <summary>
        /// int値からRpsSignを返します。
        /// </summary>
        public static RpsSign FromInt(int value)
        {
            return value switch
            {
                0 => RpsSign.Rock,
                1 => RpsSign.Paper,
                2 => RpsSign.Scissors,
                _ => throw new InvalidEnumArgumentException(),
            };
        }

        /// <summary>
        /// RpsSignの名前を取得します。
        /// </summary>
        public static String GetName(this RpsSign sign)
        {
            return sign switch
            {
                RpsSign.Rock => "グー",
                RpsSign.Paper => "パー",
                RpsSign.Scissors => "チョキ",
                _ => throw new InvalidEnumArgumentException(),
            };
        }
    }
}
