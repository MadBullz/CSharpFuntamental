using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array: ", n);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - " + i + " : ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Even elements are: ");
            for (int i = 0; i < n; i++)
            {
                if(a[i]%2==0) Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Odd elements are: ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0) Console.Write(a[i] + " ");
            }
        }
    }
}
