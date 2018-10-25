using System;

namespace BullsNCows
{
    class Game
    {
        public void Game1()
        {
            var input = new Input();
            string rand = input.CompRandInput();
            Console.WriteLine("\n{0} (типа тайное число, которое вы должны угадать)", rand);
            string type = "";
            Console.WriteLine("Введите 4 оригинальных числа:");
            string typing = input.UserInput(type);
            Result result = new Result();
            result.GameResult(rand, typing);
        }

        public void Game2()
        {
            var input = new Input();
            string type = "";
            Console.WriteLine("\nВведите 4 хитрых оригинальных числа:");
            string typing = input.UserInput(type);
            Console.WriteLine("{0} (типа тайное число, которое вы должны  были ввести)", typing);
            Console.WriteLine("Теперь компуктер должен обыграть вас:");
            string rand = input.CompRandInput();
            Console.WriteLine(rand);
            Result result = new Result();
            result.GameResultRevert(rand, typing); 
        }
    }
}