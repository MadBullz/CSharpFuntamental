using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("25 + 4 = "+(a + b));
            Console.WriteLine("25 - 4 = " + (a - b));
            Console.WriteLine("25 x 4 = " + (a * b));
            Console.WriteLine("25 / 4 = " + (a / b));
            Console.WriteLine("25 mod 4 = " + (a % b));
        }
    }
}
