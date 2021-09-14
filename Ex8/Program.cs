using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of array: ");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine("Input {0} elements in the array in ascending order: ", n);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - " + i + " : ");
                a[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Input the value to be inserted: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted: ");
            int index = int.Parse(Console.ReadLine());



            Console.WriteLine("The current list of the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

            int[] b = new int[a.Length + 1];
            for (int i = 0; i < index-1; i++)
            {
                b[i] = a[i];
            }
            b[index-1] = num;
            for (int i = index; i < b.Length; i++)
            {
                b[i] = a[i-1];
            }

            Console.WriteLine();
            Console.WriteLine("After Insert the element, the new list is: ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
    }
}
