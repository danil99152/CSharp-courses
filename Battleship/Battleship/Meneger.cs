using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary;
using System.Reflection; 

namespace BattleShip
{
    public class Meneger<U> : Battleship
        where U : User
    {
        public bool Win<U>()
        {
            if (Points == 20)
            {
                Console.SetCursorPosition(10, 0);
                Console.Write("Вы победили!");
                return true;
            }
            return false;
        }
        
        public bool Win() 
        {
            if (Points == 20)
            {
                Console.SetCursorPosition(10, 0);
                Console.Write("Вы проиграли!");
                return true;
            }
            return false;
        }

        public bool Hit<U>(int i, int j)
        {
            if (BotField[i, j] == 0)
            {
                BotField[i, j] = 3;
                Field1[i, j] = 3;
                Output(Field1);
                Console.SetCursorPosition(30, 0);
                Console.Write("Промах!   ");
                return false;
            }
            if (BotField[i, j] == 1)
            {
                BotField[i, j] = 2;
                Field1[i, j] = 2;
                Stroke(BotField, i, j);
                Output(Field1);
                Console.SetCursorPosition(30, 0);
                Console.Write("Попадание!");
                return true;
            }
            Console.SetCursorPosition(30, 0);
            Console.Write("Нельзя стрелять в эту клетку");
            Console.SetCursorPosition(30, 4);
            Console.WriteLine();
            Step--;
            return true;
        }


        public bool Hit(int i, int j)
        {
            if (UserField[i, j] == 0)
            {
                Field1[i, j] = 3;
                UserField[i, j] = 3;
                return false;
            }
            if (UserField[i, j] == 1)
            {
                Field1[i, j] = 2;
                UserField[i, j] = 2;
                Stroke(UserField, i, j);
                return true;
            }
            if (UserField[i, j] > 1)
            {
                return false;
            }
            return false;
        }
    }
}