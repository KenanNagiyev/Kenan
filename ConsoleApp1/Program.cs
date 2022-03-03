using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int say = 0;
            for (int i = n; i < m; i++)
            {
                if (i % 7 == 0)
                {
                    say++;
                }
            }
            Console.WriteLine(say);
            Console.ReadLine();
        }
    }
    
}
