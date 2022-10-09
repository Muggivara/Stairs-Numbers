using System;


namespace Stairs
{
    internal class Program
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Введите количество ступенек: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("***");
                for (int e = i - 1; e >= -1; e--)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("*");
                for (int e = -1; e < i; e++)
                {
                    Console.Write("  ");
                }
            }


            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                    Console.WriteLine("  000\n 0   0 \n0     0\n0     0\n0     0\n 0   0\n  000\n");
                else if (a == 1)
                    Console.WriteLine("  1\n 11\n  1\n  1\n  1\n  1\n 111");
                else if (a == 2)
                    Console.WriteLine("  222\n 2   2\n 2  2\n   2\n  2\n 2\n 22222");
                else if (a == 3)
                    Console.WriteLine("  333\n 3   3\n     3\n     3\n  333\n     3\n     3\n 3   3\n  333");
                else if (a == 4)
                    Console.WriteLine("    4\n   44\n  4 4\n 4  4\n 444444\n    4\n    4");
                else if (a == 5)
                    Console.WriteLine(" 55555\n 5\n 5\n 5  55\n 55   5\n      5\n      5\n 5    5\n   55");
                else if (a == 6)
                    Console.WriteLine("  666\n 6   6\n 6\n 6\n 66666\n 6   6\n 6   6\n 6   6\n 66666");
                else if (a == 7)
                    Console.WriteLine(" 77777\n     7\n    7\n   7\n  7\n 7\n 7");
                else if (a == 8)
                    Console.WriteLine("  888\n 8   8\n 8   8\n  888\n 8   8\n 8   8\n  888");
                else if (a == 9)
                    Console.WriteLine("  9999\n 9   9\n 9   9\n  9999\n     9\n     9\n     9");
            }






















        }
    }
    
}
