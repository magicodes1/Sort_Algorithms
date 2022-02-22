namespace SortNumbers
{
    class MaxHeapSort : Algorithm
    {
        private int[] unSortedArray;

        public MaxHeapSort(int[] unSortedArray) : base(unSortedArray)
        {
            this.unSortedArray = unSortedArray;
        }


        private void maxHeapSort(int[] arr)
        {
            int size = arr.Length;

            buildMaxHeap(size, arr);

            for (int i = size - 1; i >= 0; --i)
            {
                swap(ref arr[0], ref arr[i]);

                heapify(0, i, arr);
            }
        }

        private void buildMaxHeap(int size, int[] arr)
        {
            int startIndex = size / 2;
            for (int i = startIndex; i >= 0; i--)
            {
                heapify(i, size, arr);
            }
        }

        private void heapify(int top, int size, int[] arr)
        {
            int index = top, left = (top * 2) + 1, right = (top * 2) + 2;

            if (left < size && arr[left] > arr[index])
            {
                index = left;
            }

            if (right < size && arr[right] > arr[index])
            {
                index = right;
            }

            if (index == top)
            {
                return;
            }
            swap(ref arr[index], ref arr[top]);
            heapify(index, size, arr);
        }

        public override void sort()
        {
            maxHeapSort(arr);
        }
    }
}