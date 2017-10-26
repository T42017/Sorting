using System;
using System.Text;

namespace QuickSort
{
    public class Program
    {
        #region Fields
        private static readonly Random _random = new Random();
        private const int _lengthOfArray = 100;
        private const int _minValue = 0;
        private const int _maxValue = 50;

        #endregion

        #region Main
        private static void Main(string[] args)
        {
            Console.WriteLine($"Sorting {_lengthOfArray} numbers...\r\n");
            // Create array and initialize it with random values
            var nums = new int[_lengthOfArray];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = _random.Next(_minValue, _maxValue);
            }

            // Initialize parameters for quicksort
            int left = 0;
            int right = nums.Length - 1;

            // Log time after creating array
            var beforeTime = DateTime.Now.TimeOfDay;
            Console.WriteLine("\tBefore sorting");
            Console.WriteLine("\t--------------------");
            Console.WriteLine("\t" + beforeTime);
            Console.WriteLine("\t" + string.Join(", ", nums));
            Console.WriteLine("\t--------------------\r\n");

            // Sort array
            Console.WriteLine("\tSorting...\r\n");
            QuickSort(nums, left, right);

            // Log time after sorting array
            Console.WriteLine("\tAfter sorting");
            Console.WriteLine("\t--------------------");
            var afterTime = DateTime.Now.TimeOfDay;
            Console.WriteLine("\t" + afterTime);
            Console.WriteLine("\t" + string.Join(", ", nums));
            Console.WriteLine("\t--------------------\r\n");

            // Log total amount of time taken by algorithm
            Console.WriteLine($"Total elapsed milliseconds: {afterTime.TotalMilliseconds - beforeTime.TotalMilliseconds}.");

            Console.ReadKey();
        }
        #endregion

        #region QuickSort using Hoare's partition scheme
        private static void QuickSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int partition = Partition(input, low, high);
                QuickSort(input, low, partition);
                QuickSort(input, partition + 1, high);
            }
        }

        private static int Partition(int[] A, int lo, int hi)
        {
            int pivot = A[lo];
            int i = lo - 1;
            int j = hi + 1;

            while (true)
            {
                do i++; while (A[i] < pivot);
                do j--; while (A[j] > pivot);

                if (i >= j)
                    return j;

                var temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
        }
        #endregion

        #region Helper methods
        private static void WriteAll<T>(params T[] args)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < args.Length; i++)
            {
                var currentArg = args[i];
                builder.Append(currentArg);

                if (i != args.Length - 1)
                    builder.Append(", ");
            }
            Console.WriteLine(builder.ToString());
        } 
        #endregion
    }
}