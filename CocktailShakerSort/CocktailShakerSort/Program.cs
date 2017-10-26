using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CocktailShakerSort
{
    public class Program
    {
        private static int[] Data;

        public static void Main(string[] args)
        {
            while (true)
            {
                Stopwatch stopWatch = new Stopwatch();

                Data = GetRandomData(80000);

                stopWatch.Start();
                CocktailSort(ref Data);
                stopWatch.Stop();

                Console.WriteLine(stopWatch.ElapsedMilliseconds);
                Console.ReadLine();
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void CocktailSort(ref int[] data)
        {
            while (true)
            {
                int[] start = { 1, data.Length - 1 };
                int[] end = { data.Length, 0 };
                int[] inc = { 1, -1 };

                for (var it = 0; it < 2; ++it)
                {
                    var flag = true;

                    for (var i = start[it]; i != end[it]; i += inc[it])
                    {
                        if (data[i - 1] <= data[i]) continue;

                        Swap(ref data[i - 1], ref data[i]);
                        flag = false;
                    }

                    if (flag)
                        return;
                }
            }
        }

        public static int[] GetRandomData(int numbers)
        {
            Random r = new Random();
            int[] data = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                data[i] = r.Next(int.MaxValue);
            }

            return data;
        }
    }
}
