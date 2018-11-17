using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Bot : ShipGenerator
    {
        public Bot()
        {
            Number = 0;
            Four(BotField.field);
            while (Number < 2)
            {
                Three(BotField.field);
            }
            Number = 0;
            while (Number < 3)
            {
                Two(BotField.field);
            }
            Number = 0;
            while (Number < 4)
            {
                One(BotField.field);
            }
        }

        public bool HitByBot(int i, int j)
        {
            if (UserField.field[i, j] == 0)
            {
                ShipField.field[i, j] = 3;
                UserField.field[i, j] = 3;
                return false;
            }
            if (UserField.field[i, j] == 1)
            {
                ShipField.field[i, j] = 2;
                UserField.field[i, j] = 2;
                Stroke(UserField.field, i, j);
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Противник попал!");
                return true;
            }
            if (UserField.field[i, j] > 1)
            {
                return false;
            }
            return false;
        }

        public void Strike()
        {
            if (Lose())
            {
                return;
            }
            Random();
            Console.SetCursorPosition(30, Indent++);
            Console.WriteLine("Выстрел противника: " + str1[Letter[Step]] + (Index[Step] + 1));
            if (HitByBot(Index[Step], Letter[Step]))
            {
                Step++;
                Points++;
                Strike();
            }
        }

        private void Random()
        {
            var random = new Random(DateTime.Now.Millisecond);
            Letter[Step] = random.Next(9);
            Index[Step] = random.Next(9);
            if (ShipField.field[Index[Step], Letter[Step]] > 0)
            {
                Random();
            }
        }

        public bool Lose()
        {
            if (Points == 20)
            {
                Console.SetCursorPosition(10, 0);
                Console.Write("Вы проиграли!");
                return true;
            }
            return false;
        }
    }
}