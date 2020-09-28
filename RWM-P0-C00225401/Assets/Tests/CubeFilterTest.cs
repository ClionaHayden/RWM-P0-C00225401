using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CubeFilterTest
    {
        [Test]
        public void CubeFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9, 999 };
            int[] output = CubeFilter.cubes(input);
            int[] expected = { 1, 27, 125, 343, 729, 997002999 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void CubeFilterFact()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = CubeFilter.fact(input);
            int[] expected = { 24, 2, 40320, 6, 362880, 24, 3628800 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

