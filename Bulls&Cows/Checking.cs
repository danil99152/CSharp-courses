using System;

namespace BullsNCows
{
    class Checking
    {
        internal int Check(string rand, string type)
        {
            string comp = rand;
            string user = type;
            int c = 0;
            int b = 0;
            int n = 4;
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (comp[i] == user[j])
                    {
                        c = c + 1;
                    }
                    if (comp[i] == user[j] && i == j )
                    {
                        b = b + 1; 
                    }
                }
            }
            Console.WriteLine("Коров {0} штук(a), быков {1} штук(а)", c, b);
            return c+b;
        }
    }
}
