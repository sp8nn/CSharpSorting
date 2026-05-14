using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort : Sort
    {
        public BubbleSort(Action<int[]> display) : base(display)
        {
        }

        public override async Task<int[]> sort(int[] arr)
        {
            this.displayFunc(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    var t = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = t;
                    i = -1;

                    await Task.Delay(500);
                    this.displayFunc(arr);
                }
            }
            return arr;
        }

    }
}
