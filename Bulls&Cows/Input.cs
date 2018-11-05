using System;

namespace BullsNCows
{
    class Input
    {
        internal string UserInput(string input)
        {
            string type   = Console.ReadLine();
            string length  = TypeLength(type);
            string origin = OriginalType(length);
            return origin; 
        }


        private string OriginalType(string print)
        {
            if (print[0] == print[1] || 
                print[0] == print[2] ||
                print[0] == print[3] ||
                print[1] == print[2] || 
                print[1] == print[3] ||  
                print[2] == print[3])
            {
                Console.WriteLine("Нужно больше оригинальности!");
                string origin = UserInput(print);
                return origin;
            }
            else
            {
                return print;
            }
        }

        private string TypeLength(string type)
        {
            if (type.Length != 4)
            {
                string result = "";
                while (result.Length != 4)
                {
                    Console.WriteLine("Я сказал 4 числа!");
                    string l = Console.ReadLine();
                    result = l;
                }
                type = result;
            }
            return type;
        }

        public string CompRandInput()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            string res = rand.Next(0, 9).ToString();
            while (res.Length <= 3)
            {
                string i = rand.Next(0, 9).ToString();
                if (res.IndexOf(i) == -1)
                {
                    res += i.ToString();
                }
            }
            return res;
        }
    }
}
