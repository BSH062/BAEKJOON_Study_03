using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                string[] input= Console.ReadLine().Split();
                int[] rel = Array.ConvertAll(input, int.Parse);

                a -= rel[0] * rel[1];
            }

            if (a==0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
