using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            char[] a = str.ToCharArray();
            char x = a[0];
            a[0] = a[a.Length - 1];
            a[a.Length - 1] = x;
            str = new string(a);
            Console.WriteLine(str);
        }
    }
}
