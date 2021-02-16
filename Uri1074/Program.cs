using System;

namespace Uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num;

            n = int.Parse(Console.ReadLine());

            for (int c = 1; c <= 4; c++)
            {
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine("Null");
                }
                if (num % 2 == 0 && num != 0)
                {
                    Console.Write("Even ");
                    if (num > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                }
                else if (num % 2 != 0 && num != 0)
                {
                    Console.Write("Odd ");
                    if (num > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                }
            }
        }
    }
}
