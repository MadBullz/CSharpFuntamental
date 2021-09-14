using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the index of desired removal: ");
            int index = int.Parse(Console.ReadLine());
            str = str.Substring(0, index) + str.Substring(index+1, str.Length-index-1);
            Console.WriteLine(str);
        }
    }
}
