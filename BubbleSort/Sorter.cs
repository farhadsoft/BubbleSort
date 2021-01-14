using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            ArraySort(array, array.Length);
        }

        private static void ArraySort(int[] array, int length)
        {
            if (length <= 1)
            {
                return;
            }

            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }

            ArraySort(array, length - 1);
        }
    }
}
