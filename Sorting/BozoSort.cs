using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BozoSort : Sort
    {
        public BozoSort(Action<int[]> display) : base(display)
        {
        }

        public override async Task<int[]> sort(int[] arr)
        {
            int[] sortedArray = new int[arr.Length];
            Array.Copy(arr, sortedArray, arr.Length);
            Array.Sort(sortedArray);

            Random rnd = new Random();
            bool sorted = false;
            while (!sorted)
            {
                var a = rnd.Next(arr.Length);
                var b = rnd.Next(arr.Length);

                var t = arr[a];
                arr[a] = arr[b];
                arr[b] = t;
                await Task.Delay(500);
                displayFunc(arr);

                if(isSorted(arr, sortedArray))
                {
                    sorted = true;
                }
            }

            return arr;

        }
        public bool isSorted(int[] a, int[] sorted)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != sorted[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
