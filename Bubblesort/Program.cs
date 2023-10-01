using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[99999];
            foreach (int num in numbers)
            {
                Random rdn = new Random();
               for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i] = rdn.Next(1, 1500);
                }
            }


            //Console.WriteLine("BEFORE SORT");

            //DisplayElements(numbers);

            Console.WriteLine("AFTER SORT");

            BubbleSort(numbers);

          //  DisplayElements(numbers);

            SelectionSort(numbers);

            Console.Read();

        }

        private static void SelectionSort(int[] ar)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            int minIndex;
            for (int i=0; i< ar.Length - 1; i++)
            {
                minIndex = i;
                for (int x = (i + 1); x < ar.Length; x++)
                {
                    if (ar[x] < ar[minIndex])
                    {
                        minIndex = x;
                    }
                }

                int temp = ar[i];
                ar[i] = ar[minIndex];
                ar[minIndex] = temp;
            }
            Console.WriteLine($"Selection Sort: {st.ElapsedMilliseconds}");
        }

      
        private static void DisplayElements(int[] numbers)
        {
            foreach(int num in numbers) 
            {
             Console.WriteLine(num + " ");
            }
        }

        private static void BubbleSort(int[] ar)
        {
            Stopwatch stb = new Stopwatch();
            stb.Start();
            int length = ar.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = (i + 1); j < ar.Length; j++)
            {
                    if (true)
                    {
                        if (ar[j] < ar[i])
                        {
                            int temp = ar[j];
                            ar[j] = ar[i];
                            ar[i] = temp;
                        }
                    }
            }
            }
        }


    }
}
