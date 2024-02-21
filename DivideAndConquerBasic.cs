using System;

namespace Algorithm_Homework_1
{
    internal class DivideAndConquerBasic
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 1, 9, 5, 10, 2 };
            int max = FindMax(array);
            Console.WriteLine("The maximum element in the array is: " + max);
        }

        private static int FindMax(int[] arr)
        {
            return FindMaxRecursive(arr, 0, arr.Length - 1);
        }

        private static int FindMaxRecursive(int[] arr, int left, int right)
        {
            if (left == right)
            {
                return arr[left];
            }

            int mid = left + (right - left) / 2;

            int maxLeft = FindMaxRecursive(arr, left, mid);
            int maxRight = FindMaxRecursive(arr, mid + 1, right);

            return Math.Max(maxLeft, maxRight);
        }
    }
}
