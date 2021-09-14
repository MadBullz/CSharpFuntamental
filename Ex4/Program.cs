using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter the Fourth number: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", a, b, c, d, (a+b+c+d)/4);
        }
    }
}
