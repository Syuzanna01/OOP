using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)//-
        {
            int[] arr = { 7, 2, 8, 1, 6, 3, 8 };
            int t;
            for (int i = 1; i < arr.Length; i++)
            {
                while ((arr[i - 1] > arr[i]) & i >= 1)
                {
                    t = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = t;
                    i--;
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]);

            Console.ReadKey();
        }

    }
}
