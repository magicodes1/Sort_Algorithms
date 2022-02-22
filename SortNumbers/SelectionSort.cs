namespace SortNumbers
{
    class SelectionSort : Algorithm
    {
        private int[] unSortedArray;

        public SelectionSort(int[] unSortedArray) : base(unSortedArray)
        {
            this.unSortedArray = unSortedArray;
        }



        public sealed override void sort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex=j;
                    }
                }
                base.swap(ref arr[i], ref arr[minIndex]);
            }
        }

    }
}