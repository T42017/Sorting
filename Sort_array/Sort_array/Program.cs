using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_array
{
    class Program
    {
        private static Random RNG = new Random();
        static void Main(string[] args)
        {
            int[] nums3 = Random(0, 100, 10).ToArray();
            var beforeTime = DateTime.Now.TimeOfDay; 
            Console.WriteLine(beforeTime+ "\r\n");
            InsertionSort(nums3);
            var afterTime = DateTime.Now.TimeOfDay;
            Console.WriteLine("\r\n" + afterTime);
            var elapsedTime = afterTime.TotalMilliseconds - beforeTime.TotalMilliseconds;
            Console.WriteLine("\r\n" + elapsedTime);
            Console.ReadKey();
        }

        public static void InsertionSort(int[] intArray)
        {
            Console.WriteLine("==========Random numbers===============\r\n");
            Console.WriteLine(string.Join(", ", intArray));
            Console.WriteLine("\r\n==========Starts sorting===============\r\n");

            int temp, j;
            for (int i = 1; i < intArray.Length; i++)
            {
                temp = intArray[i];
                j = i - 1;

                while (j >= 0 && intArray[j] > temp)
                {
                    intArray[j+1] = intArray[j];
                    j--;
                    
                }
                
                intArray[j + 1] = temp;
                Console.WriteLine(string.Join(", ", intArray));

            }

            Console.WriteLine("\r\n==========Sorted numbers===============\r\n");
            Console.WriteLine(string.Join(", ", intArray));
        }

        private static IEnumerable<int> Random(int min, int max, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                int rand = RNG.Next(min, max);
                yield return rand;
            }
        }
    }
}
