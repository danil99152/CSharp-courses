using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class User: ShipGenerator
    {
        /* public User()
           {
               Number = 0;
               Four(UserField);
               while (Number < 2)
               {
                   Three(UserField);
               }
               Number = 0;
               while (Number < 3)
               {
                   Two(UserField);
               }
               Number = 0;
               while (Number < 4)
               {
                   One(UserField);
               }
           } */

        ShipRepository repository = new ShipRepository();
        public User()
        {
            repository.InitShips();
        }

        public bool HitByUser(int i, int j)
        {
            if (BotField[i, j] == 0)
            {
                BotField[i, j] = 3;
                ShipField[i, j] = 3;
                Output(ShipField);
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Промах!");
                return false;
            }
            if (BotField[i, j] == 1)
            {
                BotField[i, j] = 2;
                ShipField[i, j] = 2;
                Stroke(BotField, i, j);
                Output(ShipField);
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Попадание!");
                return true;
            }
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Нельзя стрелять в эту клетку");
            Console.SetCursorPosition(30, 4);
            Console.WriteLine();
            Step--;
            return true;
        }

        public void Strike()
        {
            if (Win())
            {
                return;
            }
            Console.SetCursorPosition(30, Indent++);
            Console.WriteLine("(Запись к-т начинается с буквы позиции)");
            Console.SetCursorPosition(30, Indent++);
            Console.WriteLine("Выстрел №: " + ++Step);
            Boolean letter = true;
            while (letter)
            {
                Console.SetCursorPosition(30, Indent++);
                Console.Write("Ваш выстрел: ");
                switch (Console.Read())
                {
                    case 'а':
                        Letter[Step] = 0;
                        letter = false;
                        break;
                    case 'б':
                        Letter[Step] = 1;
                        letter = false;
                        break;
                    case 'в':
                        Letter[Step] = 2;
                        letter = false;
                        break;
                    case 'г':
                        Letter[Step] = 3;
                        letter = false;
                        break;
                    case 'д':
                        Letter[Step] = 4;
                        letter = false;
                        break;
                    case 'е':
                        Letter[Step] = 5;
                        letter = false;
                        break;
                    case 'ж':
                        Letter[Step] = 6;
                        letter = false;
                        break;
                    case 'з':
                        Letter[Step] = 7;
                        letter = false;
                        break;
                    case 'и':
                        Letter[Step] = 8;
                        letter = false;
                        break;
                    case 'к':
                        Letter[Step] = 9;
                        letter = false;
                        break;
                }
            }
            Index[Step] = Convert.ToInt32(Console.ReadLine()) - 1;
            if (HitByUser(Index[Step], Letter[Step]))
            {
                Points++;
                Strike();
            }
        }

        public bool Win()
        {
            if (Points == 20)
            {
                Console.SetCursorPosition(10, 0);
                Console.Write("Вы победили!");
                return true;
            }
            return false;
        }
    }
}