using System;
using System.Diagnostics;
using CocktailShakerSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShakerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanSort()
        {
            int amount = 10000;

            int[] data = new int[amount];
            for (int i = amount - 1; i >= 0; i--)
            {
                data[i] = i;
            }

            Program.CocktailSort(ref data);

            int[] expectedData = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                expectedData[i] = i;
            }

            CollectionAssert.AreEqual(expectedData, data);
        }
    }
}
