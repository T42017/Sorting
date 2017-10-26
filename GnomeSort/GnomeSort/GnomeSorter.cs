using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnomeSort
{
    public static class GnomeSorter
    {
        public static void GnomeSort(this int[] data)
        {
            for (int i = 1; i < data.Length;)
            {
                if (data[i - 1] <= data[i])
                    ++i;
                else
                {
                    int tmp = data[i];
                    data[i] = data[i - 1];
                    data[i - 1] = tmp;
                    --i;
                    if (i == 0)
                        i = 1;
                }
            }
        }
    }
}
