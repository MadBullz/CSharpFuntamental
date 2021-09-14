using System;

namespace Ex5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            Console.Write("The number in reverse order is: "+rev);
        }
    }
}
