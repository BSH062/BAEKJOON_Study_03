using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line=int.Parse(Console.ReadLine());
            int[] relA = new int[line];
            int[] relB = new int[line];

            var adnum = new StringBuilder();
            for (int i = 0; i < line; i++)
            {
                string[] input = Console.ReadLine().Split( );
                int[] rel = Array.ConvertAll(input, int.Parse);
                relA[i] = rel[0];
                relB[i] = rel[1];
                adnum.Append(relA[i] + relB[i]+"\n");
            }
            Console.WriteLine(adnum.ToString());
        }
    }
}
