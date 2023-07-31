using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPaternStrategy_Exercise
{
    internal class MergeSort : ISortingStrategy
    {
        public int[] Sort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int mid = arr.Length / 2;

            int[] left = new int[mid];
            Array.Copy(arr, 0, left, 0, mid);

            int[] right = new int[arr.Length - mid];
            Array.Copy(arr, mid, right, 0, arr.Length - mid);

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int[] result = new int[leftLength + rightLength];

            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while (leftIndex < leftLength && rightIndex < rightLength)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                }

                resultIndex++;
            }

            while (leftIndex < leftLength)
            {
                result[resultIndex] = left[leftIndex];
                leftIndex++;
                resultIndex++;
            }

            while (rightIndex < rightLength)
            {
                result[resultIndex] = right[rightIndex];
                rightIndex++;
                resultIndex++;
            }

            return result;
        }
    }
}
