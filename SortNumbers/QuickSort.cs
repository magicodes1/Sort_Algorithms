namespace SortNumbers
{
    class QuickSort : Algorithm
    {
        private int[] unSortedArray;

        public QuickSort(int[] unSortedArray) : base(unSortedArray)
        {
            this.unSortedArray = unSortedArray;
        }


        private void quickSort(int left, int right, int[] arr)
        {
            int middle = (left + right) / 2;
            int i = left, j = right;
            while (i < j)
            {
                while (arr[i] < arr[middle])
                {
                    i++;
                }

                while (arr[j] > arr[middle])
                {
                    j--;
                }

                if (i <= j)
                {
                    swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }

            if(left<j){
                quickSort(left,j,arr);
            }
            if(i<right){
                quickSort(i,right,arr);
            }
        }

        public override void sort()
        {
            quickSort(0,arr.Length-1,arr);
        }
    }
}