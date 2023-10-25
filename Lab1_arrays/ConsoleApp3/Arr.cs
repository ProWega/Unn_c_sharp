using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Arr
    {
        Random random = new Random();
        public int[] arr;
        public Arr(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }
            Array.Sort(arr);
            this.arr = arr;
        }
        public void PlusAnotherArr(Arr a)
        {   
            if (this.arr.Length == a.arr.Length)
            {
                int[] newArr = new int[a.arr.Length];
                for (int i = 0; i < a.arr.Length; i++)
                {
                    newArr[i] = a.arr[i] + arr[i];
                }
                this.arr = newArr;
            }
            else
            {
                Console.WriteLine("ОШИБКА - сложение массивов разной длины");
            }       
        }
        public int[] MultArr(int k)
        {
            for (int i = 0; i<this.arr.Length; i++)
            {
                this.arr[i] *= k;
            }
            return this.arr;
        }
        public static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write($"Массив: [{a[i]}, ");
                }
                else if (i == a.Length - 1)
                {
                    Console.Write($"{a[i]}]\n");
                }
                else
                {
                    Console.Write($"{a[i]}, ");
                }

            }
        }
        public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] > pivot)
                {
                    i++;
                }

                while (array[j] < pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);
            return array;
        }
        public void FindCommonElementsWith(Arr arr)
        {
            int x_pointer = 0;
            int y_pointer = 0;
            int[] x = arr.arr;
            int[] y = this.arr;
            while (x_pointer < x.Length && y_pointer < y.Length)
            {
                if ((x[x_pointer] == y[y_pointer]))
                {
                    Console.WriteLine($"Общий элемент {x[x_pointer]}");
                    x_pointer++;
                    y_pointer++;
                }
                else if ((x[x_pointer] > y[y_pointer]))
                {
                    y_pointer++;
                }
                else
                {
                    x_pointer++;
                }

            }
        }
        public static int FindMinValue(int[] a)
        {
            int minValue = int.MaxValue;
            foreach (int x in a)
            {
                if (x < minValue)
                {
                    minValue = x;
                }
            }
            return minValue;
        }
        public static int FindMaxValue(int[] a)
        {
            int maxValue = int.MinValue;
            foreach (int x in a)
            {
                if (x > maxValue)
                {
                    maxValue = x;
                }
            }
            return maxValue;
        }
        public static float FindMean(int[] a)
        {
            float sum = 0;
            foreach (int x in a)
            {
                sum += x;
            }
            return sum/a.Length;
        }
    }
}
