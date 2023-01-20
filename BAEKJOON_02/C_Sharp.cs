using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string line = Console.ReadLine();
            //int Line = int.Parse(line);

            //for (int i = 0; i < Line; i++)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    int[] rel = Array.ConvertAll(input, int.Parse);

            //    Console.WriteLine(rel[0] + rel[1]);
            //}


            //아래가 좀더 문제에 원하는 답인것 같음 
            int a = int.Parse(Console.ReadLine());
            int[] arrA = new int[a];
            int[] arrB = new int[a];

            for (int i = 0; i < a; i++)
            {
                string[] s = Console.ReadLine().Split();
                int[] rel = Array.ConvertAll(s, int.Parse);

                arrA[i] = rel[0];
                arrB[i] = rel[1];
            }

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(arrA[i] + arrB[i]);
            }
        }
    }
}
