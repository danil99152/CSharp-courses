using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Bot : Meneger
    {
        public Bot()
        {
            Four();
            while (Number < three)
            {
                Three();
            }
            Number = 0;
            while (Number < two)
            {
                Two();
            }
            Number = 0;
            while (Number < one)
            {
                One();
            }
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
            if (HitbyBot(Index[Step], Letter[Step]))
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
    }
}