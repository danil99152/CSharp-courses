using System;

namespace BullsNCows
{
    class Choise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим игры:\n " +
                "1. Угадывает число пользователь;\n " +
                "2. Угадывает число компьютер.\n");
            Console.Write("Режим: ");
            string n = Console.ReadLine();
            while (n !="1" || n != "2") {
                if (n == "1")
                {
                    var game1 = new Game();
                    game1.Game1();
                    break;
                }
                else if (n == "2")
                {
                    var game2 = new Game();
                    game2.Game2();
                    break;
                }
                else
                {
                    Console.Write("Такого режима нет\nПовторите запрос заново: ");
                    n = Console.ReadLine();
                }
            }
        }
    }
}
