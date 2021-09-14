using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            string[] a = str.Split(" ");
            string s = "";
            for (int i = a.Length-1; i >= 0; i--)
            {
                s += a[i];
                s += " ";
            }
            Console.WriteLine(s);
        }
    }
}
