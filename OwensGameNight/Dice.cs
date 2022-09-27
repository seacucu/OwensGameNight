using System;
using System.Diagnostics;

namespace OwensGameNight
{
    static class Dice
    {
        // 屬性
        public static int Sides { get; set; }

        public static int Rolls { get; set; }

        // 方法
        /// <summary>
        /// 擲 d 顆 s 面骰並回傳結果
        /// </summary>
        /// <param name="dices">骰子個數</param>
        /// <param name="sides">骰子面數，預設6面骰</param>
        /// <returns>擲骰結果</returns>
        public static int RollDice(int dices, int sides = 6)
        {
            Random random = new Random();
            int result = 0;
            for (int i = 0; i < dices; i++)
            {
                result += random.Next(1, sides + 1);
            }
            Debug.WriteLine($"rolled 3d6, result is {result}.");
            return result;
        }
    }
}