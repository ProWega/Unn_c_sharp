using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    public class OneDimArray
    {
        int size;
        float[] array;
        Random random =  new Random();
        public OneDimArray(int size)
        {
            this.size = size;
            array = new float[size];
        }
        public void InputData()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите значение: ");
                float el = float.Parse(Console.ReadLine());
                array[i] = el;
            }
        }
        public void InputDataRandom()
        {
            for (int i = 0;i < array.Length; i++)
            {
                array[i] = (float) random.Next(0, 800);
            }
        }
        public void print()
        {
            Console.WriteLine();
            foreach(float el in array)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
        public void FindValue(in float el, out List<int> indexes)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == el)
                {
                    list.Add(i);
                }
            }
            indexes = list;
        }
        public void DelValue(in float el)
        {
            List<int> indexes;
            FindValue(el, out indexes);
            float[] new_array = new float[array.Length-indexes.Count()];
            int k = 0;
            for (int i = 0; i< array.Length; i++)
            {
                if (!indexes.Contains(i)){
                    new_array[k++] = array[i];
                }
            }
        }
        public float FindMax()
        {
            float max = float.MinValue;
            foreach (float el in array)
            {
                if (el> max)
                {
                    max = el;
                }
            }
            return max;
        }
        public float[] Add(in float[] array2)
        {
            if (array.Length != array2.Length)
            {
                Console.WriteLine("Массивы разной длины");
                return array;
            }
            float[] new_array = new float[array.Length];
            for (int i = 0;i < array2.Length; i++)
            {
                new_array[i] = array2[i]+array[i];
            }
            return new_array;
        }
        float[] SortArray(float[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    float temp = array[i];
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
        public void sort()
        {
            array = SortArray(array, 0, array.Length-1);
        }
    }
}
