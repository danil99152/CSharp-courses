using System;

namespace BullsNCows
{
    class Result
    {
        public void GameResult (string rand, string typing)
        {
            var input = new Input();
            var checking = new Checking();
            string type = "";
            int result = checking.Check(rand, typing);
            while (result != 8)
            {
                typing = input.UserInput(type);
                result = checking.Check(rand, typing);
            }
            if (result == 8)
            {
                Console.WriteLine("Вы угадали число!");
            }
        }

        public void GameResultRevert(string rand, string typing)
        {
            var input = new Input();
            var checking = new Checking();
            int result = checking.Check(rand, typing);
            while (result != 8)
            {
                rand = input.CompRandInput();
                Console.WriteLine(rand);
                result = checking.Check(rand, typing);
            }
            if (result == 8)
            {
                Console.WriteLine("Компуктер угадал число!");
            }
        }
    }
}
