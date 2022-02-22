namespace SortNumbers
{
    class InsertSort : Algorithm
    {
        private int[] unSortedArray;

        public InsertSort(int[] unSortedArray) : base(unSortedArray)
        {
            this.unSortedArray = unSortedArray;
        }

        public override void sort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j>0 && arr[j]<arr[j-1])
                {
                     swap(ref arr[j],ref arr[j-1]);
                     j--;
                }
            }
        }
    }
}