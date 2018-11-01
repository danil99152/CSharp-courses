using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Bot : Meneger<User>
    {
        Meneger<User> generator = new Meneger<User>();
        public Bot()
        {
            generator.BFour();
            while (Number < two)
            {
                generator.BThree();
            }
            Number = 0;
            while (Number < three)
            {
                generator.BTwo();
            }
            Number = 0;
            while (Number < four)
            {
                generator.BOne();
            }
        }

        public void Strike()
        {
            if (Win())
            {
                return;
            }
            Random();
            Console.SetCursorPosition(30, Indent++);
            Console.WriteLine("Выстрел противника: " + str1[Letter[Step]] + (Index[Step] + 1));
            if (Hit(Index[Step], Letter[Step]))
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
            if (Field1[Index[Step], Letter[Step]] > 0)
            {
                Random();
            }
        }
    }
}