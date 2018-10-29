using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary; 

namespace BattleShip
{
    public class User: Meneger<User>
    {
        ShipGenerator generator = new ShipGenerator();
        public User()
        {
            Number = 0;
            generator.UFour();
            while (Number < three)
            {
                generator.UThree();
            }
            Number = 0;
            while (Number < two)
            {
                generator.UTwo();
            }
            Number = 0;
            while (Number < one)
            {
                generator.UOne();
            }
        }

        public void Strike()
        {
            if (Win<User>())
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
            if (Hit<User>(Index[Step], Letter[Step]))
            {
                Points++;
                Strike();
            }
        }
    }
}