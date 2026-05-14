using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public abstract class Sort
    {
        protected Action<int[]> displayFunc;
        public Sort(Action<int[]> display)
        {
            this.displayFunc = display;
        }
        public abstract Task<int[]> sort(int[] arr);
    }
}
