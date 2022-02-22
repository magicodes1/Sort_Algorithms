namespace SortNumbers
{
    class BubbleSort : Algorithm
    {
        private int[] unSortedArray;

        public BubbleSort(int[] unSortedArray) : base(unSortedArray)
        {
            this.unSortedArray = unSortedArray;
        }

        public override void sort()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if(arr[j]>arr[j+1]){
                        swap(ref arr[j],ref arr[j+1]);
                    }
                }
            }
        }
    }
}