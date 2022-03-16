using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 6, 3, 8, 9, 5, 4, 7 };
            int t;
            bool k = true;
            while (k)
            {
                k = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = t;
                        k = true;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
