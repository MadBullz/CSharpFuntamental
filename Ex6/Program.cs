using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input {0} number of elements in the array: ", n);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - "+i+" : ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("The values store into the array in reverse are: ");
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
