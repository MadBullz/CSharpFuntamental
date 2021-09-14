using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            string[] a = str.Split(" ");
            int max = a[0].Length;
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > max)
                {
                    max = a[i].Length;
                    index = i;
                }
            }
            Console.WriteLine(a[index]);
        }
    }
}
