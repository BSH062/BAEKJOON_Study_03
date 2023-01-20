using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;

            for (int i = 1; i <= a; i++)
            {
                b += i;
            }
            Console.WriteLine(b);
        }
    }
}
