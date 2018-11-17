using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class User: ShipGenerator
    {
        public User()
        {
            Number = 0;
            Four(UserField.field);
            while (Number < 2)
            {
                Three(UserField.field);
            }
            Number = 0;
            while (Number < 3)
            {
                Two(UserField.field);
            }
            Number = 0;
            while (Number < 4)
            {
                One(UserField.field);
            }
        }

        public delegate void MethodContainer();

        public event MethodContainer HitUser;

        public event MethodContainer Miss; 

        public bool HitByUser(int i, int j)
        {
            if (BotField.field[i, j] == 0)
            {
                BotField.field[i, j] = 3;
                ShipField.field[i, j] = 3;
                Output(ShipField.field);
                Miss();
                return false;
            }
            if (BotField.field[i, j] == 1)
            {
                BotField.field[i, j] = 2;
                ShipField.field[i, j] = 2;
                Stroke(BotField.field, i, j);
                Output(ShipField.field);
                HitUser();
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