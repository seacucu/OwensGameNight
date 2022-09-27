using System;
using static System.Console;

namespace OwensGameNight
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                // 實例化
                SwordDamage swordDamage = new SwordDamage(Dice.RollDice(3));
                ArrowDamage arrowDamage = new ArrowDamage(Dice.RollDice(1));

                Greet();
                char selectedWeapon = Char.ToUpper(ReadKey(false).KeyChar);
                Greet(selectedWeapon);
                char buffChoice = Char.ToUpper(ReadKey(false).KeyChar);

                switch (selectedWeapon)
                {
                    case 'S':
                        // 擲骰，並為劍傷設定火/魔屬性
                        swordDamage.Roll = Dice.RollDice(swordDamage.RollTimes);
                        if (buffChoice == '1' || buffChoice == '3')
                            swordDamage.Magic = true;
                        if (buffChoice == '2' || buffChoice == '3')
                            swordDamage.Flaming = true;
                        // 顯示結果
                        WriteLine($"\n擲骰結果 {swordDamage.Roll}，" +
                            $"傷害為 {swordDamage.Damage} HP");
                        break;

                    case 'A':
                        // 擲骰，並為箭傷設定火/魔屬性
                        arrowDamage.Roll = Dice.RollDice(arrowDamage.RollTimes);
                        if (buffChoice == '1' || buffChoice == '3')
                            arrowDamage.Magic = true;
                        if (buffChoice == '2' || buffChoice == '3')
                            arrowDamage.Flaming = true;
                        // 顯示結果
                        WriteLine($"\n擲骰結果 {arrowDamage.Roll}，" +
                            $"傷害為 {arrowDamage.Damage} HP");
                        break;

                    default:
                        return;
                }

                Write("按任意鍵再擲一次：");
                ReadKey(); Clear();
            }
        }

        public static void Greet(char greetType = '\0')
        {
            string greet;
            switch (greetType)
            {
                default:
                    greet =
@"
歡迎使用傷害計算程式
 S - 開始計算劍傷
 A - 開始計算箭傷
或按任意鍵退出：";
                    break;

                case 'S':
                    greet =
@"
正在計算劍傷！
 0 - 基本劍（無火焰/魔法）
 1 - 魔法劍
 2 - 火焰劍
 3 - 火焰魔法劍
或按任意鍵退出：";
                    break;

                case 'A':
                    greet =
@"
正在計算箭傷！
 0 - 基本箭（無火焰/魔法）
 1 - 魔法箭
 2 - 火焰箭
 3 - 火焰魔法箭
或按任意鍵退出：";
                    break;
            }
            WriteLine(greet);
        }
    }
}