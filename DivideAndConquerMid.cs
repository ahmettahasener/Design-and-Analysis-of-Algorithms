using System;

namespace Algorithm_Homework_1
{
    internal class DivideAndConquerMid
    {

        public static void Main(string[] args)
        {
            int[] array = { 3, 1, 2, 4, 5 };
            int inversionCount = CountInversions(array);
            Console.WriteLine("The number of inversions in the array is: " + inversionCount);
        }

        public static int CountInversions(int[] arr)
        {
            return MergeSort(arr, 0, arr.Length - 1);
        }

        private static int MergeSort(int[] arr, int left, int right)
        {
            int inverseCount = 0;

            if (left < right)
            {
                int mid = left + (right - left) / 2;

                inverseCount += MergeSort(arr, left, mid);
                inverseCount += MergeSort(arr, mid + 1, right);
                inverseCount += Merge(arr, left, mid, right);
            }

            return inverseCount;
        }

        private static int Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1;
            int inversionCount = 0;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                    inversionCount += (mid - i + 1);
                }
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            for (i = 0; i < k; i++)
            {
                arr[left + i] = temp[i];
            }

            return inversionCount;
        }

    }


}
