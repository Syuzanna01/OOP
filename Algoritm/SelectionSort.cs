using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 4, 9, 3, 7, 8 };
            int t, k = 0;

            while (k < arr.Length)
            {
                int min = k;
                for (int i = k + 1; i < arr.Length; i++)
                {
                    if (arr[min] > arr[i])
                        min = i;
                }
                t = arr[k];
                arr[k] = arr[min];
                arr[min] = t;
                k++;
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
