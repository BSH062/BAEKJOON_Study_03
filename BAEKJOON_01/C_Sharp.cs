using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rel = int.Parse(input);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(rel+" * "+i+" = "+rel*i);
            }
        }
    }
}
