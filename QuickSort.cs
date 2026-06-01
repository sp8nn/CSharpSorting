namespace Sorting
{
    public class QuickSort : Sort
    {
        public QuickSort(Action<int[]> display) : base(display)
        {
        }

        public override async Task<int[]> sort(int[] arr, CancellationToken token)
        {
            await QuickSortArray(arr, 0, arr.Length - 1, token);
            displayFunc(arr);
            return arr;
        }

        private async Task QuickSortArray(int[] arr, int low, int high, CancellationToken token)
        {
            if (low < high)
            {
                int pivot = await Partition(arr, low, high, token);

                await QuickSortArray(arr, low, pivot - 1, token);
                await QuickSortArray(arr, pivot + 1, high, token);
            }
        }

        private async Task<int> Partition(int[] arr, int low, int high, CancellationToken token)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                token.ThrowIfCancellationRequested();

                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);

                    displayFunc(arr);
                    await Task.Delay(25, token);
                }
            }

            Swap(arr, i + 1, high);

            displayFunc(arr);
            await Task.Delay(25, token);

            return i + 1;
        }

        private void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}