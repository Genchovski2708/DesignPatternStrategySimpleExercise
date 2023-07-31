using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPaternStrategy_Exercise
{
    internal class QuickSort: ISortingStrategy
    {
        public int[] Sort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int pivotIndex = arr.Length / 2;
            int pivotValue = arr[pivotIndex];

            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int leftIndex = 0;
            int rightIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (arr[i] <= pivotValue)
                {
                    left[leftIndex] = arr[i];
                    leftIndex++;
                }
                else
                {
                    right[rightIndex] = arr[i];
                    rightIndex++;
                }
            }

            int[] leftSorted = Sort(TrimArray(left, leftIndex));
            int[] rightSorted = Sort(TrimArray(right, rightIndex));

            return ConcatenateArrays(leftSorted, pivotValue, rightSorted);
        }

        private int[] TrimArray(int[] arr, int size)
        {
            int[] trimmedArray = new int[size];
            Array.Copy(arr, trimmedArray, size);
            return trimmedArray;
        }

        private int[] ConcatenateArrays(int[] left, int pivot, int[] right)
        {
            int[] result = new int[left.Length + right.Length + 1];

            int index = 0;
            for (int i = 0; i < left.Length; i++)
            {
                result[index] = left[i];
                index++;
            }

            result[index] = pivot;
            index++;

            for (int i = 0; i < right.Length; i++)
            {
                result[index] = right[i];
                index++;
            }

            return result;
        }
    }
}
