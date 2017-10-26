using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnomeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGnomeSort();

            Console.ReadKey();
        }


        private static void TestGnomeSort()
        {
            int[] data = { 36, 83, 28, 47, 54, 93, 19, 65, 71 };

            data.GnomeSort();

            foreach (int datas in data)
                Console.Write(datas + " ");
            

        }
        
    }
}
