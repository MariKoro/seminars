using System;

namespace Seminar_003
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, i;
            i = 1;
            while (i <= 15)
            {
                if (i % 2 == 0)
                {
                    s = s + i;
                }
                i++;
            }
            Console.WriteLine(s);
        }
    }
}
