/* 3. Звичайний консольний застосунок. Для квадратної матриці цілих чисел В відсортувати у порядку спадання чисел кожний стовпець. Сортування організувати вручну. */

using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a dimention af the matrix: ");
            var dimention = Convert.ToInt32(Console.ReadLine());
            var matrix = new int[dimention,dimention];
            Console.WriteLine("Enter numbers: ");
            for (var i = 0; i < dimention; i++)
            {
                for (var j = 0; j < dimention; j++)
                {
                    Console.WriteLine($"i =  " + i + " j = " + j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(var i = 0; i< dimention; i++)
            {
                var buffer = new int[dimention];
                for(var j = 0; j <dimention; j++)
                {
                    buffer[j] = matrix[j, i];
                }

                BubbleSort(buffer);
                //QuickSort(buffer);
                //MergeSort(buffer);

                for(var k = 0; k< dimention; k++)
                {
                    matrix[k, i] = buffer[k];
                }

            }

            for(var i = 0; i<dimention; i++)
                    {
                for(var j =0; j < dimention; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            Console.Read();
        }

        static void MergeSort(int[] arr)
        {
            Merge(arr, 0, arr.Length - 1);
        }

        static void Merge(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                var middleIndex = (leftIndex + rightIndex) / 2;
                Merge(arr, leftIndex, middleIndex);
                Merge(arr, middleIndex + 1, rightIndex);
                MergeGlue(arr, leftIndex, middleIndex, rightIndex);
            }
        }

        static void MergeGlue(int[] arr, int leftIndex, int middleIndex, int rightIndex)
        {
            var left = leftIndex;
            var right = middleIndex + 1;
            var buffer = new int[rightIndex - leftIndex + 1];
            var currentIndex = 0;

            while (left <= middleIndex && right <= rightIndex)
            {
                if (arr[left] > arr[right])
                {
                    buffer[currentIndex] = arr[left];
                    left++;
                }
                else
                {
                    buffer[currentIndex] = arr[right];
                    right++;
                }

                currentIndex++;
            }

            if (left <= middleIndex)
            {
                Array.Copy(arr, left, buffer, currentIndex, middleIndex - left + 1);
            }

            else if (right <= rightIndex)
            {
                Array.Copy(arr, right, buffer, currentIndex, rightIndex - right + 1);
            }

            Array.Copy(buffer, 0, arr, leftIndex, buffer.Length);


        }

        static int[] QuickSort(int[] arr)
        {
            return Quick(arr, 0, arr.Length-1);
        }
        static int[] Quick(int[] arr, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return arr;

            var pivotIndex = GetPivotIndex(arr, minIndex, maxIndex);

            Quick(arr, minIndex, pivotIndex - 1);
            Quick(arr, pivotIndex + 1, maxIndex);

            return arr;
        }

        static int GetPivotIndex(int[] arr, int minIndex, int maxIndex)
        {
            var pivotIndex = minIndex - 1;

            for (var i = minIndex; i < maxIndex; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    pivotIndex++;
                    // Console.Write("Iteration: " + i + " Pivot Index: " + pivotIndex + " Ar: " + arr[pivotIndex] + " " + arr[i]);
                    (arr[pivotIndex], arr[i]) = (arr[i], arr[pivotIndex]);
                    // Console.Write("->" + arr[pivotIndex] + " " + arr[i] + "\n");
                }

            }

            pivotIndex++;
            (arr[pivotIndex], arr[maxIndex]) = (arr[maxIndex], arr[pivotIndex]);

            return pivotIndex;
        }

        static int[] BubbleSort(int[] arr)
        {
            for (var i = 1; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        //Console.WriteLine(arr[j] + " " + arr[j + 1]);
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        //Console.WriteLine(arr[j] + " " + arr[j + 1] + "\n");
                    }

                }
            }

            return arr;
        }
    }
}
