using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Meneger: Battleship
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
            if (BotField.field[i, j] == 0)
            {
                BotField.field[i, j] = 3;
                Field1.field[i, j] = 3;
                Output(Field1.field);
                Console.SetCursorPosition(30, 0);
                Console.Write("Промах!   ");
                return false;
            }
            if (BotField.field[i, j] == 1)
            {
                BotField.field[i, j] = 2;
                Field1.field[i, j] = 2;
                Stroke(BotField.field, i, j);
                Output(Field1.field);
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
            if (UserField.field[i, j] == 0)
            {
                Field1.field[i, j] = 3;
                UserField.field[i, j] = 3;
                return false;
            }
            if (UserField.field[i, j] == 1)
            {
                Field1.field[i, j] = 2;
                UserField.field[i, j] = 2;
                Stroke(UserField.field, i, j);
                return true;
            }
            if (UserField.field[i, j] > 1)
            {
                return false;
            }
            return false;
        }

        public void Four<U>()
        {
            var random = new Random();
            int x = random.Next(10);
            int y = random.Next(10);
            if (x > 5)
            {
                y = random.Next(5);
                for (int i = y; i < y + 4; i++)
                {
                    UserField.field[i, x] = 1;
                }
                return;
            }
            if (y > 5)
            {
                x = random.Next(5);
                for (int j = x; j < x + 4; j++)
                {
                    UserField.field[y, j] = 1;
                }
                return;
            }
            int k = random.Next(1);
            if (k == 0)
            {
                for (int i = y; i < y + 4; i++)
                {
                    UserField.field[i, x] = 1;
                }
            }
            else
            {
                for (int j = x; j < x + 4; j++)
                {
                    UserField.field[y, j] = 1;
                }
            }
        }
        public void Three<U>()
        {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            if (y > 6)
            {
                x = random.Next(7);
                for (int i = y - 1; i < y + 2; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 4; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (UserField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int j = x; j < x + 3; j++)
                {
                    UserField.field[y, j] = 1;
                }
                Number++;
                return;
            }
            if (x > 6)
            {
                y = random.Next(7);
                for (int i = y - 1; i < y + 4; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 2; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        {
                            if (UserField.field[i, j] != 0)
                            {
                                return;
                            }
                        }
                    }
                }
                for (int i = y; i < y + 3; i++)
                {
                    UserField.field[i, x] = 1;
                }
                Number++;
                return;
            }
            int k = random.Next(1);
            if (k == 0)
            {
                for (int i = y - 1; i < y + 4; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 2; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (UserField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int i = y; i < y + 3; i++)
                {
                    UserField.field[i, x] = 1;
                }
                Number++;
            }
            else
            {
                for (int i = y - 1; i < y + 2; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 4; j++)
                    {
                        if (j < 0)
                        {
                            j = 0;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (UserField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int j = x; j < x + 3; j++)
                {
                    UserField.field[y, j] = 1;
                }
                Number++;
            }
        }
        public void Two<U>()
        {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            if (y > 7)
            {
                x = random.Next(8);
                for (int i = y - 1; i < y + 2; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 3; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (UserField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int j = x; j < x + 2; j++)
                {
                    UserField.field[y, j] = 1;
                }
                Number++;
                return;
            }
            if (x > 7)
            {
                y = random.Next(8);
                for (int i = y - 1; i < y + 3; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 2; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (UserField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int i = y; i < y + 2; i++)
                {
                    UserField.field[i, x] = 1;
                }
                Number++;
                return;
            }
            int k = random.Next(1);
            if (k == 0)
            {
                for (int i = y - 1; i < y + 3; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 2; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (UserField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int i = y; i < y + 2; i++)
                {
                    UserField.field[i, x] = 1;
                }
                Number++;
            }
            else
            {
                for (int i = y - 1; i < y + 2; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 3; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (UserField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int j = x; j < x + 2; j++)
                {
                    UserField.field[y, j] = 1;
                }
                Number++;
            }
        }
        public void One<U>()
        {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            for (int i = y - 1; i < y + 2; i++)
            {
                if (i < 0)
                {
                    i++;
                }
                if (i > 9)
                {
                    break;
                }
                for (int j = x - 1; j < x + 2; j++)
                {
                    if (j < 0)
                    {
                        j++;
                    }
                    if (j > 9)
                    {
                        break;
                    }
                    if (UserField.field[i, j] != 0)
                    {
                        return;
                    }
                }
            }
            UserField.field[y, x] = 1;
            Number++;
        }

        public void Four()
        {
            var random = new Random();
            int x = random.Next(10);
            int y = random.Next(10);
            if (x > 5)
            {
                y = random.Next(5);
                for (int i = y; i < y + 4; i++)
                {
                    BotField.field[i, x] = 1;
                }
                return;
            }
            if (y > 5)
            {
                x = random.Next(5);
                for (int j = x; j < x + 4; j++)
                {
                    BotField.field[y, j] = 1;
                }
                return;
            }
            int k = random.Next(1);
            if (k == 0)
            {
                for (int i = y; i < y + 4; i++)
                {
                    BotField.field[i, x] = 1;
                }
            }
            else
            {
                for (int j = x; j < x + 4; j++)
                {
                    BotField.field[y, j] = 1;
                }
            }
        }
        public void Three()
        {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            if (y > 6)
            {
                x = random.Next(7);
                for (int i = y - 1; i < y + 2; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 4; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (BotField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int j = x; j < x + 3; j++)
                {
                    BotField.field[y, j] = 1;
                }
                Number++;
                return;
            }
            if (x > 6)
            {
                y = random.Next(7);
                for (int i = y - 1; i < y + 4; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 2; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (BotField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int i = y; i < y + 3; i++)
                {
                    BotField.field[i, x] = 1;
                }
                Number++;
                return;
            }
            int k = random.Next(1);
            if (k == 0)
            {
                for (int i = y - 1; i < y + 4; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 2; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (BotField.field[i, j] != 0)
                        {
                            return;
                        }

                    }
                }
                for (int i = y; i < y + 3; i++)
                {
                    BotField.field[i, x] = 1;
                }
                Number++;
            }
            else
            {
                for (int i = y - 1; i < y + 2; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 4; j++)
                    {
                        if (j < 0)
                        {
                            j = 0;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (BotField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int j = x; j < x + 3; j++)
                {
                    BotField.field[y, j] = 1;
                }
                Number++;
            }
        }
        public void Two()
        {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            if (y > 7)
            {
                x = random.Next(8);
                for (int i = y - 1; i < y + 2; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 3; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (BotField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int j = x; j < x + 2; j++)
                {
                    BotField.field[y, j] = 1;
                }
                Number++;
                return;
            }
            if (x > 7)
            {
                y = random.Next(8);
                for (int i = y - 1; i < y + 3; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 2; j++)
                    {
                        if (j > 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (BotField.field[i, j] != 0)
                        {
                            return;
                        }
                    }
                }
                for (int i = y; i < y + 2; i++)
                {
                    BotField.field[i, x] = 1;
                }
                Number++;
                return;
            }
            int k = random.Next(1);
            if (k == 0)
            {
                for (int i = y - 1; i < y + 3; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 2; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (BotField.field[i, j] != 0)
                        {
                            return;
                        }

                    }
                }
                for (int i = y; i < y + 2; i++)
                {
                    BotField.field[i, x] = 1;
                }
                Number++;
            }
            else
            {
                for (int i = y - 1; i < y + 2; i++)
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i > 9)
                    {
                        break;
                    }
                    for (int j = x - 1; j < x + 3; j++)
                    {
                        if (j < 0)
                        {
                            j++;
                        }
                        if (j > 9)
                        {
                            break;
                        }
                        if (BotField.field[i, j] != 0)
                        {
                            return;
                        }

                    }
                }
                for (int j = x; j < x + 2; j++)
                {
                    BotField.field[y, j] = 1;
                }
                Number++;
            }
        }
        public void One()
        {
            var random = new Random();
            var x = random.Next(10);
            var y = random.Next(10);
            for (int i = y - 1; i < y + 2; i++)
            {
                if (i < 0)
                {
                    i++;
                }
                if (i > 9)
                {
                    break;
                }
                for (int j = x - 1; j < x + 2; j++)
                {
                    if (j < 0)
                    {
                        j++;
                    }
                    if (j > 9)
                    {
                        break;
                    }
                    if (BotField.field[i, j] != 0)
                    {
                        return;
                    }
                }
            }
            BotField.field[y, x] = 1;
            Number++;
        }
    }
}