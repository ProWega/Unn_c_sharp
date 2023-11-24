using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class Arrays
    {
        public static float[] FlotifyArray(in string[] arr)
        {
            float[] result = new float[arr.Length];
            int i = 0;
            foreach (string element in arr)
            {
                float f = 0;
                try
                {
                    f = float.Parse(element.Replace('.', ','));
                }
                catch { }
                result[i] = f;
                i++;
            }

            return result;
        }

        public static void FindMin(in float[] array, out float min)
        {
            min = float.MaxValue;
            foreach (float f in array)
            {
                if (f < min) min = f;
            }
        }

        public static void FindMax(float[] array, out float max)
        {
            max = float.MinValue;
            foreach (float f in array)
            {
                if (f > max) max = f;
            }
        }
        public static void FindSum(float[] array, out float sum)
        {
            sum = 0;
            foreach (float f in array)
            {
                sum+=f;
            }
        }
    }
}
